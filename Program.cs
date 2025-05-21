using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using WindowsFormsApp3;
using WindowsFormsApp3.Forms;

namespace Proiect_PAW
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["BookShopDataBase"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed: " + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
