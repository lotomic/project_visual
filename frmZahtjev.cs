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
    public partial class frmZahtjev : Form
    {
        public frmZahtjev()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gumb odustani zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// gumb pošalji zahtjev šalje podatke u bazu i ispisuje poruku u ss traku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosaljiZahtjev_Click(object sender, EventArgs e)
        {
            if (txtOpis.Text == "" || txtPolaziste.Text == "" || txtOdrediste.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                queriesTableAdapter1.G8_KreirajZahtjev(dtpDatumPolaska.Value.Date, txtOpis.Text, txtPolaziste.Text, txtOdrediste.Text, frmMain.loggedUser.UserName);
                frmMain.zapisiStatusnuTraku("Zahtjev za jednokratnim putnim nalogom je poslan!", 1, 1);
                MessageBox.Show("Zahtjev za jednokratnim putnim nalogom je poslan!");
                this.Close();
            }
        }

        /// <summary>
        /// podaci za nositelja troškova i vozilo koje korisnik može odabrati iz combobox-a se pune učitavanjem forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmZahtjev_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaPutniNalog' table. You can move, or remove it, as needed.
            this.vrstaPutniNalogTableAdapter.Fill(this.piDB1DataSet.vrstaPutniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet.nositeljTroskova' table. You can move, or remove it, as needed.
            this.nositeljTroskovaTableAdapter.Fill(this.piDB1DataSet.nositeljTroskova);
        }

        /// <summary>
        /// gumb odustani zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustaniVisekratni_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// slanje zahtjeva za višekratni putni nalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosaljiVisekratni_Click(object sender, EventArgs e)
        {
            if (txtOpisVisekratni.Text == "" || txtPolazisteVisekratni.Text == "" || txtOdredisteVisekratni.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                queriesTableAdapter1.G8_KreirajVisekratniZahtjev(dtpOdVisekratni.Value, dtpDoVisekratni.Value, txtOpisVisekratni.Text, txtPolazisteVisekratni.Text, txtOdredisteVisekratni.Text, frmMain.loggedUser.UserName);
                frmMain.zapisiStatusnuTraku("Zahtjev za višekratnim putnim nalogom je poslan!", 1, 1);
                MessageBox.Show("Zahtjev za višekratnim putnim nalogom je poslan!");
                this.Close();
            }
        }
    }
}
