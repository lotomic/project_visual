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
    public partial class frmUnosTroskova : Form
    {
        public static decimal iznos;
        public frmUnosTroskova()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gumb gotovo zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGotovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// gumb dodaj upisuje trošak u bazu, računa sumu troškova, briše txtboxove te omogućava ponovni unos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string trosak = txtIznosTroska.Text;
            //   queriesTableAdapter1.G8_UnosTroskova(txtOpisTroska.Text, Decimal.Parse(txtIznosTroska.Text), frmMain.broj, Int32.Parse(cmbVrstaTroska.SelectedValue.ToString()));

            if (txtIznosTroska.Text == "")
            {
                iznos = 0;
            }
            else if (txtOpisTroska.Text == "")
            {
                MessageBox.Show("Niste popunili polje opis troška!");
            }

            else if (!(new Regex("^[0-9]{1,45}$").Matches(trosak).Count >= 1))
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
            else
            {
                iznos = Decimal.Parse(txtIznosTroska.Text);
                queriesTableAdapter1.G8_UnosTroskova(txtOpisTroska.Text, Decimal.Parse(txtIznosTroska.Text), frmMain.broj, Int32.Parse(cmbVrstaTroska.SelectedValue.ToString()));
                frmMain.sumaTroskova = frmMain.sumaTroskova + iznos;
                txtUkupniIznos.Text = frmMain.sumaTroskova.ToString();

                frmMain.zapisiStatusnuTraku("Trošak je dodan!", 1, 1);
                txtOpisTroska.Text = "";
                txtIznosTroska.Text = "";
                txtOpisTroska.Focus();

            }
        }

        /// <summary>
        /// učitavanjem forme, popunjava se tableAdapter za odabir vrste troška
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUnosTroskova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaTrosak' table. You can move, or remove it, as needed.
            this.vrstaTrosakTableAdapter.Fill(this.piDB1DataSet.vrstaTrosak);

        }

        /// <summary>
        /// klik na spremi brojila ažurira podatke o brojilima u bazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string pocetno = txtPocetnoBrojilo.Text;
            string zavrsno = txtZavrsnoBrojilo.Text;
            if (!(new Regex("^[0-9]{1,45}$").Matches(pocetno).Count >= 1))
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
            else if (!(new Regex("^[0-9]{1,45}$").Matches(zavrsno).Count >= 1))
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
            else
            {

                queriesTableAdapter1.G8_AzurirajBrojila(Int32.Parse(txtPocetnoBrojilo.Text), Int32.Parse(txtZavrsnoBrojilo.Text), frmMain.broj);
                txtPocetnoBrojilo.Enabled = false;
                txtZavrsnoBrojilo.Enabled = false;
                frmMain.zapisiStatusnuTraku("Brojila su ažurirana", 1, 1);
            }
        }
    }
}
