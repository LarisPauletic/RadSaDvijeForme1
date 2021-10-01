
namespace RadSaVišeFormi
{
    partial class Studenti
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisiStudent = new System.Windows.Forms.Button();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(16, 27);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(200, 28);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj novog studenta";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisiStudent
            // 
            this.buttonObrisiStudent.Location = new System.Drawing.Point(709, 197);
            this.buttonObrisiStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObrisiStudent.Name = "buttonObrisiStudent";
            this.buttonObrisiStudent.Size = new System.Drawing.Size(140, 28);
            this.buttonObrisiStudent.TabIndex = 1;
            this.buttonObrisiStudent.Text = "Obrisi studenta";
            this.buttonObrisiStudent.UseVisualStyleBackColor = true;
            this.buttonObrisiStudent.Click += new System.EventHandler(this.buttonObrisiStudent_Click);
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.Location = new System.Drawing.Point(16, 406);
            this.buttonObrisiSve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObrisiSve.Name = "buttonObrisiSve";
            this.buttonObrisiSve.Size = new System.Drawing.Size(148, 28);
            this.buttonObrisiSve.TabIndex = 2;
            this.buttonObrisiSve.Text = "Obrisi sve studente";
            this.buttonObrisiSve.UseVisualStyleBackColor = true;
            this.buttonObrisiSve.Click += new System.EventHandler(this.buttonObrisiSve_Click);
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(16, 63);
            this.listBoxStudenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(684, 324);
            this.listBoxStudenti.TabIndex = 3;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.buttonObrisiStudent);
            this.Controls.Add(this.buttonDodaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisiStudent;
        private System.Windows.Forms.Button buttonObrisiSve;
        private System.Windows.Forms.ListBox listBoxStudenti;
    }
}

