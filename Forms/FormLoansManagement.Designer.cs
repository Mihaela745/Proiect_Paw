﻿namespace WindowsFormsApp3.Forms
{
    partial class FormLoansManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddLoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddLoan
            // 
            this.buttonAddLoan.Location = new System.Drawing.Point(102, 313);
            this.buttonAddLoan.Name = "buttonAddLoan";
            this.buttonAddLoan.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLoan.TabIndex = 1;
            this.buttonAddLoan.Text = "Add Loan";
            this.buttonAddLoan.UseVisualStyleBackColor = true;
            this.buttonAddLoan.Click += new System.EventHandler(this.buttonAddLoan_Click);
            // 
            // FormLoansManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddLoan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLoansManagement";
            this.Text = "FormLoansManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddLoan;
    }
}