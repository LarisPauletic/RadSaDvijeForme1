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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta myForm = new UnosNovogStudenta();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

            UnosNovogStudenta frm = new UnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();
     
            if (rez == System.Windows.Forms.DialogResult.OK)

                listBoxStudenti.Items.Add(frm.Student1.ToString());
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonObrisiStudent_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))

                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }
    }
}
