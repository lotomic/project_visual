using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Uprava.NET
{
    public partial class frmAkontacija : Form
    {
        public frmAkontacija()
        {
            InitializeComponent();
        }

        /// <summary>
        /// učitavanjem forme puni se tableAdapter odobrenim nalozima prijavljenog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAkontacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByVlasnikOdobren(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            this.putniNalogTableAdapter.FillByVlasnikOdobren15(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
        }

        /// <summary>
        /// varijabla broj (idNaloga) se prilikom promjene vrijednosti u comboBoxu ažurira
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOdaberi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // izbor korisnika sa comboboxa se sprema u varijablu broj
            frmMain.broj = Convert.ToInt32(cmbOdaberi.SelectedValue); 
        }

        /// <summary>
        /// Klik na gumb pošalji zahtjev šalje zahtjev u bazu i zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.broj = Convert.ToInt32(cmbOdaberi.SelectedValue);
            string akon = txtAkontacija.Text;

            if (txtAkontacija.Text == "")
            {
                MessageBox.Show("Niste unijeli ispravan broj!");
                txtAkontacija.Text = "";
                txtAkontacija.Focus();
            }
            else if (!(new Regex("^[0-9]{1,45}$").Matches(akon).Count >= 1))
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }

            else
            {
                decimal ak = Decimal.Parse(txtAkontacija.Text);
                if (ak != 0)
                {
                    queriesTableAdapter1.G8_ZahtjevZaAkontacijom(frmMain.broj, Decimal.Parse(txtAkontacija.Text));
                    frmMain.zapisiStatusnuTraku("Zahtjev za akontacijom je poslan! Akontaciju možete podići nakon što računovodstvo evidentira promjene!", 1, 1);
                    MessageBox.Show("Zahtjev za akontacijom je poslan!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Akontacija ne može biti nula!");
                    txtAkontacija.Text = "";
                    txtAkontacija.Focus();
                }
            }
        }

    }
}
