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
    public partial class FormLoansManagement : Form
    {
        public FormLoansManagement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormLoansManagement_Load);
        }

        private void LoadLoans()
        {
            string connection = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if(string.IsNullOrEmpty(connection) )
            {
                MessageBox.Show("Conexiunea nu a putut fi facuta!");
                return;
            }
            try
            {
                using(SqlConnection conn=new SqlConnection(connection))
                using(SqlDataAdapter da=new SqlDataAdapter("Select * from loans",conn))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLoansManagement_Load(object sender, EventArgs e)
        {
            LoadLoans();
        }

        private void buttonAddLoan_Click(object sender, EventArgs e)
        {
            var form= new FormAddLoan();
            form.ShowDialog();
            LoadLoans() ;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if (string.IsNullOrEmpty(connection))
            {
                MessageBox.Show("Conexiunea la baza de date lipsește.");
                return;
            }
            try
            {
                using(SqlConnection conn=new SqlConnection(connection))
                {
                    conn.Open();
                    string query = @"update loans set returndate=@date where id=@id";
                    using(SqlCommand  cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", System.DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", (Guid)dataGridView1.SelectedRows[0].Cells[0].Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("A fost returnata cartea!");
                            query = @"update books set isAvailable=1 where @id=@id";
                            using(SqlCommand c=new SqlCommand(query, conn))
                            {
                                c.Parameters.AddWithValue("@id", (Guid)dataGridView1.SelectedRows[0].Cells[1].Value);
                                c.ExecuteReader();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu merge returul!");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadLoans();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLoansManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}
