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
            this.labelOpenDataBase.Location = new System.Drawing.Point(12, 9);
            this.labelOpenDataBase.Name = "labelOpenDataBase";
            this.labelOpenDataBase.Size = new System.Drawing.Size(132, 16);
            this.labelOpenDataBase.TabIndex = 0;
            this.labelOpenDataBase.Text = "Acces Baza De Date";
            this.labelOpenDataBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAccesDatabase
            // 
            this.buttonAccesDatabase.Location = new System.Drawing.Point(150, 6);
            this.buttonAccesDatabase.Name = "buttonAccesDatabase";
            this.buttonAccesDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonAccesDatabase.TabIndex = 1;
            this.buttonAccesDatabase.Text = "OPEN";
            this.buttonAccesDatabase.UseVisualStyleBackColor = true;
            this.buttonAccesDatabase.Click += new System.EventHandler(this.buttonAccesDatabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificarea datelor din lista de carti:";
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(252, 44);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonBooks.TabIndex = 3;
            this.buttonBooks.Text = "OPEN";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modificarea cititorilor:";
            // 
            // buttonReaders
            // 
            this.buttonReaders.Location = new System.Drawing.Point(158, 76);
            this.buttonReaders.Name = "buttonReaders";
            this.buttonReaders.Size = new System.Drawing.Size(75, 23);
            this.buttonReaders.TabIndex = 5;
            this.buttonReaders.Text = "OPEN";
            this.buttonReaders.UseVisualStyleBackColor = true;
            this.buttonReaders.Click += new System.EventHandler(this.buttonReaders_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modificarea imprumuturilor: ";
            // 
            // buttonLoans
            // 
            this.buttonLoans.Location = new System.Drawing.Point(200, 109);
            this.buttonLoans.Name = "buttonLoans";
            this.buttonLoans.Size = new System.Drawing.Size(75, 23);
            this.buttonLoans.TabIndex = 7;
            this.buttonLoans.Text = "OPEN";
            this.buttonLoans.UseVisualStyleBackColor = true;
            this.buttonLoans.Click += new System.EventHandler(this.buttonLoans_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(293, 264);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

