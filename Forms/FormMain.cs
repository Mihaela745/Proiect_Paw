﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccesDatabase_Click(object sender, EventArgs e)
        {
            var formAllData=new FormAllData();
            formAllData.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            var formBooks = new FormManageBooks();
            formBooks.Show();
        }

        private void buttonReaders_Click(object sender, EventArgs e)
        {
            var formReaders=new FormManageReaders();
            formReaders.Show();
        }

        private void buttonLoans_Click(object sender, EventArgs e)
        {
            var formLoans=new FormLoansManagement();
            formLoans.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pa pa <3");
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
