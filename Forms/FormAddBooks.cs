using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Proiect_PAW.Entities;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAddBooks : Form
    {
        public FormAddBooks()
        {
            InitializeComponent();
            buttonSubmit.Click += ButtonSubmit_Click;
        }

    private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Conexiunea la baza de date nu este configurată corect.");
                return;
            }

            try
            {
                string title = textBoxTitle.Text.Trim();
                string author = textBoxAuthor.Text.Trim();
                int publishingYear = int.Parse(textBoxPublishingYear.Text.Trim());

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO Books (Id, Title, Author, PublishingYear, IsAvailable) 
                                 VALUES (@Id, @Title, @Author, @PublishingYear, @IsAvailable)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@PublishingYear", publishingYear);
                    cmd.Parameters.AddWithValue("@IsAvailable", true);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("📚 Carte adăugată cu succes!");

                // Curăță câmpurile
                textBoxTitle.Clear();
                textBoxAuthor.Clear();
                textBoxPublishingYear.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Eroare la salvare: " + ex.Message);
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPublishingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPublishingYear_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
