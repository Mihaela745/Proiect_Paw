using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAllData : Form
    {
        public FormAllData()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Lipsă conexiune la baza de date");
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

              
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Readers", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewReaders.DataSource = dt;
                }

               
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Loans", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewLoans.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}