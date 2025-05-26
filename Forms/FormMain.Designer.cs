namespace WindowsFormsApp3
{
    partial class FormMain
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
            this.labelOpenDataBase = new System.Windows.Forms.Label();
            this.buttonAccesDatabase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReaders = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoans = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOpenDataBase
            // 
            this.labelOpenDataBase.AutoSize = true;
            this.labelOpenDataBase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenDataBase.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelOpenDataBase.Location = new System.Drawing.Point(178, 46);
            this.labelOpenDataBase.Name = "labelOpenDataBase";
            this.labelOpenDataBase.Size = new System.Drawing.Size(183, 23);
            this.labelOpenDataBase.TabIndex = 0;
            this.labelOpenDataBase.Text = "Acces Baza De Date";
            this.labelOpenDataBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAccesDatabase
            // 
            this.buttonAccesDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAccesDatabase.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccesDatabase.ForeColor = System.Drawing.Color.Purple;
            this.buttonAccesDatabase.Location = new System.Drawing.Point(515, 46);
            this.buttonAccesDatabase.Name = "buttonAccesDatabase";
            this.buttonAccesDatabase.Size = new System.Drawing.Size(99, 42);
            this.buttonAccesDatabase.TabIndex = 1;
            this.buttonAccesDatabase.Text = "OPEN";
            this.buttonAccesDatabase.UseVisualStyleBackColor = false;
            this.buttonAccesDatabase.Click += new System.EventHandler(this.buttonAccesDatabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(178, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificarea datelor din lista de carti:";
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBooks.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ForeColor = System.Drawing.Color.Purple;
            this.buttonBooks.Location = new System.Drawing.Point(515, 94);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(99, 42);
            this.buttonBooks.TabIndex = 3;
            this.buttonBooks.Text = "OPEN";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(178, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modificarea cititorilor:";
            // 
            // buttonReaders
            // 
            this.buttonReaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonReaders.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReaders.ForeColor = System.Drawing.Color.Purple;
            this.buttonReaders.Location = new System.Drawing.Point(515, 142);
            this.buttonReaders.Name = "buttonReaders";
            this.buttonReaders.Size = new System.Drawing.Size(99, 42);
            this.buttonReaders.TabIndex = 5;
            this.buttonReaders.Text = "OPEN";
            this.buttonReaders.UseVisualStyleBackColor = false;
            this.buttonReaders.Click += new System.EventHandler(this.buttonReaders_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(179, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modificarea imprumuturilor: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLoans
            // 
            this.buttonLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLoans.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoans.ForeColor = System.Drawing.Color.Purple;
            this.buttonLoans.Location = new System.Drawing.Point(515, 190);
            this.buttonLoans.Name = "buttonLoans";
            this.buttonLoans.Size = new System.Drawing.Size(99, 42);
            this.buttonLoans.TabIndex = 7;
            this.buttonLoans.Text = "OPEN";
            this.buttonLoans.UseVisualStyleBackColor = false;
            this.buttonLoans.Click += new System.EventHandler(this.buttonLoans_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Purple;
            this.buttonClose.Location = new System.Drawing.Point(352, 314);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 42);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLoans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReaders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccesDatabase);
            this.Controls.Add(this.labelOpenDataBase);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpenDataBase;
        private System.Windows.Forms.Button buttonAccesDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReaders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoans;
        private System.Windows.Forms.Button buttonClose;
    }
}

