using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3.Forms
{
    public partial class FormUpdateReaders : Form
    {
        private Guid readerId;
        public FormUpdateReaders(Guid Id,string name,string email,string phone)
        {
            InitializeComponent();
            readerId = Id;
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxTelefon.Text = phone;

            buttonSubmit.Click += buttonSubmit_Click;
            buttonClose.Click += (s, e) => this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if(string.IsNullOrEmpty(connectionString))
            {

                MessageBox.Show("Conexiunea la baza de date lipsește.");
                return;
            }



            if (!IsValidEmail(textBoxEmail.Text.ToString()))
            {
                MessageBox.Show("Email-ul nu este valid.");
                return;
            }

            if (!IsValidPhone(textBoxTelefon.Text.ToString()))
            {
                MessageBox.Show("Numărul de telefon nu este valid. Trebuie să înceapă cu 07 și să aibă 10 cifre.");
                return;
            }


            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"update readers
                                   set name=@name, email=@email,phone=@phone
                                    where id=@id";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", readerId);
                        command.Parameters.AddWithValue("@name",textBoxName.Text);
                        command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@phone",textBoxTelefon.Text);

                        int rowsAffected= command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                            MessageBox.Show(" Citittorul a fost actualizat cu succes.");
                        }
                        else
                        {
                            MessageBox.Show("Cititorul nu a fost gasit.");
                        }
                    }
                }
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(" Eroare la actualizare: " + ex.Message);
            }
        }

        private void FormUpdateReaders_Load(object sender, EventArgs e)
        {

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
    }
}
