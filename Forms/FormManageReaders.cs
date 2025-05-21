using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormManageReaders : Form
    {
        public FormManageReaders()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.FormManageReaders_Load);

        }

        private void LoadReaders()
        {
            string connection = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;
            if(connection == null)
            {
                MessageBox.Show("Conexiunea la baza de date lipseste!");
                return;
            }
            try
            {
                using(SqlConnection conn=new SqlConnection(connection))
                using(SqlDataAdapter data=new SqlDataAdapter("SELECT * FROM READERS", conn))
                {
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dataGridViewReaders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea cititorilor: " + ex.Message);
            }
        }

        private void FormManageReaders_Load(object sender,EventArgs e)
        {
            LoadReaders();
        }

        private void dataGridViewReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAdd=new FormAddReader();
            formAdd.ShowDialog();
            LoadReaders();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridViewReaders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un cititor");
                return;
            }

            var row = dataGridViewReaders.SelectedRows[0];
            Guid id = (Guid)row.Cells["Id"].Value;
            string name = row.Cells["Name"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString() ;

            var formUpdate=new FormUpdateReaders(id,name,email,phone);
            formUpdate.ShowDialog();

            LoadReaders();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewReaders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o carte din listă.");
                return;
            }

            var row = dataGridViewReaders.SelectedRows[0];
            Guid id = (Guid)row.Cells["Id"].Value;

            DialogResult confirm = MessageBox.Show("Esti sigur ca vrei sa stergi acest cititor?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
       
            if(confirm != DialogResult.Yes)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["BookShopDataBase"]?.ConnectionString;


            if(connectionString == null)
            {
                MessageBox.Show("Conexiunea la baza de date lipsește.");
                return;
            }

            try
            {
                using(SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "delete from readers where id=@ID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        int rows = command.ExecuteNonQuery();
                        if (rows>0)
                        {
                            MessageBox.Show("Citittorul a fost sters!");
                        }
                        else
                        {
                            MessageBox.Show("Cititorul nu a fost sters!");
                        }
                    }
                }
                LoadReaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere: " + ex.Message);
            }

        }
    }
}
