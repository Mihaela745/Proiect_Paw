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
        }
    }
}
