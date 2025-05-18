using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormUpdateBook : Form
    {
        private Guid bookId;

        public FormUpdateBook(Guid id, string title, string author, int year)
        {
            InitializeComponent();

            bookId = id;
            textBoxTitle.Text = title;
            textBoxAuthor.Text = author;
            textBoxPublishingYear.Text = year.ToString();

            // 🔗 Leagă evenimentele butoanelor
            buttonSubmit.Click += buttonUpdate_Click;
            buttonClose.Click += (s, e) => this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
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

                    string query = @"
                        UPDATE Books 
                        SET Title = @Title, Author = @Author, PublishingYear = @Year
                        WHERE Id = @Id AND IsAvailable = 1"; // ✅ verificare IsAvailable

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                        cmd.Parameters.AddWithValue("@Author", textBoxAuthor.Text);
                        cmd.Parameters.AddWithValue("@Year", int.Parse(textBoxPublishingYear.Text));
                        cmd.Parameters.AddWithValue("@Id", bookId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("✔ Cartea a fost actualizată cu succes.");
                        }
                        else
                        {
                            MessageBox.Show("⚠ Cartea nu este disponibilă sau nu a fost găsită.");
                        }
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Eroare la actualizare: " + ex.Message);
            }
        }
    }
}
