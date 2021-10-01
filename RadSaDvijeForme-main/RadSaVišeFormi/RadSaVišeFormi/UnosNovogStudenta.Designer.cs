
namespace RadSaVišeFormi
{
    partial class UnosNovogStudenta
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
            this.textBoxBrojIndeksa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSmjer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBrojIndeksa
            // 
            this.textBoxBrojIndeksa.Location = new System.Drawing.Point(504, 80);
            this.textBoxBrojIndeksa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBrojIndeksa.Name = "textBoxBrojIndeksa";
            this.textBoxBrojIndeksa.Size = new System.Drawing.Size(280, 22);
            this.textBoxBrojIndeksa.TabIndex = 0;
            this.textBoxBrojIndeksa.TextChanged += new System.EventHandler(this.textBoxBrojIndeksa_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(41, 174);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(280, 22);
            this.textBoxPrezime.TabIndex = 1;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(41, 80);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(280, 22);
            this.textBoxIme.TabIndex = 2;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj indeksa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Smjer";
            // 
            // comboBoxSmjer
            // 
            this.comboBoxSmjer.FormattingEnabled = true;
            this.comboBoxSmjer.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrezni administrator"});
            this.comboBoxSmjer.Location = new System.Drawing.Point(41, 250);
            this.comboBoxSmjer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSmjer.Name = "comboBoxSmjer";
            this.comboBoxSmjer.Size = new System.Drawing.Size(280, 24);
            this.comboBoxSmjer.TabIndex = 9;
            this.comboBoxSmjer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSmjer_SelectedIndexChanged);
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(504, 174);
            this.dateTimePickerDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDatumRodjenja.TabIndex = 10;
            this.dateTimePickerDatumRodjenja.ValueChanged += new System.EventHandler(this.dateTimePickerDatumRodenja_ValueChanged);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(41, 341);
            this.buttonSnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(281, 53);
            this.buttonSnimi.TabIndex = 11;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(716, 341);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(240, 53);
            this.buttonOtkazi.TabIndex = 12;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.Controls.Add(this.comboBoxSmjer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxBrojIndeksa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrojIndeksa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSmjer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}