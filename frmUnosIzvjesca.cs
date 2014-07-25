using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uprava.NET
{
    public partial class frmUnosIzvjesca : Form
    {
        public frmUnosIzvjesca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gumb odustani zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// gumb unesi izvješće sprema izvješće u bazu i ispisuje mbox da je uneseno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnesiIzvjesce_Click(object sender, EventArgs e)
        {
            if (txtIzvjesce.Text == "")
            {
                MessageBox.Show("Ne možete poslati prazno izvješće!");
            }
            else
            {
                queriesTableAdapter1.G8_UnosIzvjesca(txtIzvjesce.Text, frmMain.broj);
                MessageBox.Show("Izvješće je uneseno");
                this.Close();
            }
        }
    }
}
