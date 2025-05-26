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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewCititori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCititori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCititori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCititori.GridColor = System.Drawing.Color.Purple;
            this.dataGridViewCititori.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewCititori.Name = "dataGridViewCititori";
            this.dataGridViewCititori.RowHeadersWidth = 51;
            this.dataGridViewCititori.RowTemplate.Height = 24;
            this.dataGridViewCititori.Size = new System.Drawing.Size(373, 346);
            this.dataGridViewCititori.TabIndex = 0;
            // 
            // dataGridViewCarti
            // 
            this.dataGridViewCarti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarti.GridColor = System.Drawing.Color.Purple;
            this.dataGridViewCarti.Location = new System.Drawing.Point(439, 13);
            this.dataGridViewCarti.Name = "dataGridViewCarti";
            this.dataGridViewCarti.RowHeadersWidth = 51;
            this.dataGridViewCarti.RowTemplate.Height = 24;
            this.dataGridViewCarti.Size = new System.Drawing.Size(349, 346);
            this.dataGridViewCarti.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Purple;
            this.buttonSubmit.Location = new System.Drawing.Point(363, 386);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(96, 27);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Purple;
            this.buttonCancel.Location = new System.Drawing.Point(363, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "CLOSE";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
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