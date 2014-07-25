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
    public partial class frmUnosTroskovaVisekratni : Form
    {
        public static decimal iznos;
        public frmUnosTroskovaVisekratni()
        {
            InitializeComponent();
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnosTroskovaVisekratni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaTrosak' table. You can move, or remove it, as needed.
            this.vrstaTrosakTableAdapter.Fill(this.piDB1DataSet.vrstaTrosak);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!(new Regex("^[0-9]{1,45}$").Matches(txtIznosTroska.Text).Count >= 1))
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
            else if (txtIznosTroska.Text != "" && Convert.ToDecimal(txtIznosTroska.Text) != 0 && txtOpisTroska.Text != "")
            {
                queriesTableAdapter1.G8_UnosTroskova(txtOpisTroska.Text, Decimal.Parse(txtIznosTroska.Text), frmMain.broj, Int32.Parse(cmbVrstaTroska.SelectedValue.ToString()));

                iznos = Decimal.Parse(txtIznosTroska.Text);
                frmMain.sumaTroskova = frmMain.sumaTroskova + iznos;
                txtUkupniIznos.Text = frmMain.sumaTroskova.ToString();

                frmMain.zapisiStatusnuTraku("Trošak je dodan!", 1, 1);
                txtOpisTroska.Text = "";
                txtIznosTroska.Text = "";
                txtOpisTroska.Focus();
            }
            else
            {
                MessageBox.Show("Niste ispravno popunili sva polja!");
                txtIznosTroska.Text = "";
                txtIznosTroska.Focus();
            }
        }
    }
}
