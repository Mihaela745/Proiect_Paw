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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

