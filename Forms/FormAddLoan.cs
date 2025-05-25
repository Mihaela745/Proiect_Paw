using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAddLoan : Form
    {
        public FormAddLoan()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageGrids_Load);
        }

        private void LoadGrids()
        {
            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if (connString == null)
            {
                MessageBox.Show("Nu merge conexiunea!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlDataAdapter adapterCititor = new SqlDataAdapter("select id,name from readers", conn))
                using (SqlDataAdapter adapterCarte = new SqlDataAdapter("select id,title from books where isavailable=1", conn))
                {

                    DataTable dt1 = new DataTable();
                    adapterCarte.Fill(dt1);
                    dataGridViewCarti.DataSource = dt1;
                    DataTable dt2 = new DataTable();
                    adapterCititor.Fill(dt2);
                    dataGridViewCititori.DataSource = dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageGrids_Load(object sender, EventArgs e)
        {
            LoadGrids();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Nu merge conexiunea!");
                return;
            }

            if (dataGridViewCarti.SelectedRows.Count == 0 || dataGridViewCititori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează un cititor și o carte.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open(); // ❗ important

                    Guid bookId = (Guid)dataGridViewCarti.SelectedRows[0].Cells["Id"].Value;
                    Guid readerId = (Guid)dataGridViewCititori.SelectedRows[0].Cells["Id"].Value;

                    string query = @"
                INSERT INTO Loans (Id, BookId, ReaderId, LoanDate, ReturnDate)
                VALUES (@id, @book, @reader, @loan, @return)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
                        cmd.Parameters.AddWithValue("@book", bookId);
                        cmd.Parameters.AddWithValue("@reader", readerId);
                        cmd.Parameters.AddWithValue("@loan", DateTime.Now);
                        cmd.Parameters.AddWithValue("@return", DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string updateBookQuery = @"UPDATE Books SET IsAvailable = 0 WHERE Id = @id";
                            using (SqlCommand cmd2 = new SqlCommand(updateBookQuery, conn))
                            {
                                cmd2.Parameters.AddWithValue("@id", bookId);
                                cmd2.ExecuteNonQuery();
                            }

                            MessageBox.Show("Împrumut adăugat cu succes!");
                            LoadGrids(); // Reîncarcă grilele
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a putut adăuga împrumutul.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            this.Close();
        }
    }
}