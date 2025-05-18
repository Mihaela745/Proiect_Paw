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
    public partial class FormManageBooks : Form
    {
        public FormManageBooks()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormManageBooks_Load);
        }
        private void LoadBooks()
        {
            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Conexiunea la baza de date lipsește!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea cărților: " + ex.Message);
            }
        }
        private void FormManageBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBooks_Click(object sender, EventArgs e)
        {
            FormAddBooks formAdd = new FormAddBooks();
            formAdd.ShowDialog();

            LoadBooks();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o carte din listă.");
                return;
            }

            var row = dataGridViewBooks.SelectedRows[0];
            Guid id = (Guid)row.Cells["Id"].Value;
            string title = row.Cells["Title"].Value.ToString();
            string author = row.Cells["Author"].Value.ToString();
            int year = Convert.ToInt32(row.Cells["PublishingYear"].Value);

            FormUpdateBook updateForm = new FormUpdateBook(id, title, author, year);
            updateForm.ShowDialog();

            LoadBooks();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o carte pentru a o șterge.");
                return;
            }

            var row = dataGridViewBooks.SelectedRows[0];

            if (row.Cells["Id"].Value == null)
            {
                MessageBox.Show("Id-ul cărții nu este valid.");
                return;
            }

            Guid bookId;
            try
            {
                bookId = Guid.Parse(row.Cells["Id"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Id-ul cărții nu este într-un format valid.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Ești sigur că vrei să ștergi această carte?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Conexiunea la baza de date lipsește.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string deleteLoansQuery = "DELETE FROM Loans WHERE BookId = @BookId";
                    using (SqlCommand cmdDeleteLoans = new SqlCommand(deleteLoansQuery, conn))
                    {
                        cmdDeleteLoans.Parameters.AddWithValue("@BookId", bookId);
                        int loansDeleted = cmdDeleteLoans.ExecuteNonQuery();
                        // Optional: MessageBox.Show($"{loansDeleted} împrumuturi șterse.");
                    }

                    string deleteBookQuery = "DELETE FROM Books WHERE Id = @BookId";
                    using (SqlCommand cmdDeleteBook = new SqlCommand(deleteBookQuery, conn))
                    {
                        cmdDeleteBook.Parameters.AddWithValue("@BookId", bookId);
                        int rows = cmdDeleteBook.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("📕 Cartea a fost ștearsă cu tot cu împrumuturi.");
                        }
                        else
                        {
                            MessageBox.Show("❗ Cartea nu a putut fi ștearsă (poate nu mai e disponibilă).");
                        }
                    }
                }

                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere: " + ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
