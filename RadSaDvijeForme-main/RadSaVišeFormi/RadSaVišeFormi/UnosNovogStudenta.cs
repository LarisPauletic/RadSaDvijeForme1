using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaVišeFormi
{
    public partial class UnosNovogStudenta : Form

    {
        private Student student1;
        public UnosNovogStudenta()
        {
            InitializeComponent();
        }
        public Student Student1

        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBrojIndeksa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatumRodenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student();       
            student1.Ime = textBoxIme.Text;
            student1.Prezime = textBoxPrezime.Text;
            student1.BrojIndeksa = textBoxBrojIndeksa.Text;
            student1.Smjer = comboBoxSmjer.SelectedItem.ToString();
            student1.DatumRodjenja = dateTimePickerDatumRodjenja.Value;
            DialogResult = DialogResult.OK;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
