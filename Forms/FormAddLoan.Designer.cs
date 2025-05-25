namespace WindowsFormsApp3.Forms
{
    partial class FormAddLoan
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
            this.dataGridViewCititori = new System.Windows.Forms.DataGridView();
            this.dataGridViewCarti = new System.Windows.Forms.DataGridView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCititori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCititori
            // 
            this.dataGridViewCititori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCititori.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewCititori.Name = "dataGridViewCititori";
            this.dataGridViewCititori.RowHeadersWidth = 51;
            this.dataGridViewCititori.RowTemplate.Height = 24;
            this.dataGridViewCititori.Size = new System.Drawing.Size(397, 346);
            this.dataGridViewCititori.TabIndex = 0;
            // 
            // dataGridViewCarti
            // 
            this.dataGridViewCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarti.Location = new System.Drawing.Point(448, 13);
            this.dataGridViewCarti.Name = "dataGridViewCarti";
            this.dataGridViewCarti.RowHeadersWidth = 51;
            this.dataGridViewCarti.RowTemplate.Height = 24;
            this.dataGridViewCarti.Size = new System.Drawing.Size(340, 346);
            this.dataGridViewCarti.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(394, 386);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(394, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dataGridViewCarti);
            this.Controls.Add(this.dataGridViewCititori);
            this.Name = "FormAddLoan";
            this.Text = "FormAddLoan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCititori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCititori;
        private System.Windows.Forms.DataGridView dataGridViewCarti;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}