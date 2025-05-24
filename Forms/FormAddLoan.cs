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
            if(connString == null)
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

        }
    }
}
