using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAddReader : Form
    {
        public FormAddReader()
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

            string nume = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefon = textBoxTelefon.Text.Trim();


            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email-ul nu este valid.");
                return;
            }
           
            if (!IsValidPhone(telefon))
            {
                MessageBox.Show("Numărul de telefon nu este valid. Trebuie să înceapă cu 07 și să aibă 10 cifre.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO READERS (ID, NAME, EMAIL, PHONE) VALUES (@ID, @NAME, @EMAIL, @PHONE)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", Guid.NewGuid());
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@PHONE", telefon); 

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Cititor adăugat cu succes!");
                textBoxName.Clear();
                textBoxEmail.Clear();
                textBoxTelefon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhone(string phone)
        {
            string pattern = @"^(\+4)?07\d{8}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
