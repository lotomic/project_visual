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
    public partial class frmRacun : Form
    {

        public frmRacun()
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
            frmMain.sumaTroskova = 0;
            this.Close();
        }

        /// <summary>
        /// gumb pošalji račun šalje račun u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosaljiRacun_Click(object sender, EventArgs e)
        {
            frmMain.broj = Int32.Parse(cmbOdaberi.SelectedValue.ToString());
            queriesTableAdapter1.G8_KreirajRacun(dtpDatumPolaska.Value, dtpDatumPovratka.Value, frmMain.broj);
            frmMain.zapisiStatusnuTraku("Račun je poslan!", 1, 1);
            MessageBox.Show("Račun je poslan!");
            this.Close();
        }

        /// <summary>
        /// učitavanjem forme za račun se popunjava table adapter sa nalozima logiranog korisnika, jer samo za njih može unijeti račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByVlasnikOdobren(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            this.putniNalogTableAdapter.FillByVlasnikOdobren15(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
        }

        /// <summary>
        /// promjena id-a naloga u comboboxu za koji se unosi račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOdaberi_SelectedIndexChanged(object sender, EventArgs e)
        {
          // izbor korisnika sa comboboxa se sprema u varijablu broj
          frmMain.broj = Convert.ToInt32(cmbOdaberi.SelectedValue); 
        }

        /// <summary>
        /// gumb unos troškova otvara formu za unos troškova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnosTroskova_Click(object sender, EventArgs e)
        {
            Nullable<int> id = Convert.ToInt32(cmbOdaberi.SelectedValue);
            if (id != 0)
            {
                //u slučaju da korisnik ne mijenja id naloga u comboboxu, tada se već odabrana vrijednost sprema u varijablu broj
                frmMain.broj = Convert.ToInt32(id);
                frmUnosTroskova formaUnos = new frmUnosTroskova();
                formaUnos.Show();
            }

            else MessageBox.Show("Nije odabran putni nalog za kojeg želite unijeti troškove!");


           /* //u slučaju da korisnik ne mijenja id naloga u comboboxu, tada se već odabrana vrijednost sprema u varijablu broj
            frmMain.broj = Int32.Parse(cmbOdaberi.SelectedValue.ToString());
            frmUnosTroskova formaUnos = new frmUnosTroskova();
            formaUnos.Show();*/
        }

        /// <summary>
        /// gumb unos izvješća otvara formu za unos izvješća
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnosIzvjesca_Click(object sender, EventArgs e)
        {

            Nullable<int> id = Convert.ToInt32(cmbOdaberi.SelectedValue);
            if (id != 0)
            {
                //u slučaju da korisnik ne mijenja id naloga u comboboxu, tada se već odabrana vrijednost sprema u varijablu broj
                frmMain.broj = Convert.ToInt32(id);
                frmUnosIzvjesca formaUnosIzvjesca = new frmUnosIzvjesca();
                formaUnosIzvjesca.Show();
            }

            else MessageBox.Show("Nije odabran putni nalog za kojeg želite unijeti izvješće!");


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.putniNalogTableAdapter.FillByVlasnikOdobren15(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
            if(tabControl1.SelectedIndex == 1)
            {
                this.putniNalogTableAdapter.FillByVlasnikOdobrenVisekratni(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
        }

        private void btnOdustaniVisekratni_Click(object sender, EventArgs e)
        {
            frmMain.sumaTroskova = 0;
            this.Close();
        }

        private void btnPosaljiRacunVisekratni_Click(object sender, EventArgs e)
        {
            TimeSpan var = dtpPovratak.Value - dtpOdlazak.Value;
            int days = var.Days;
            int hours = var.Hours;
            int brSati = 0;

            if (hours == 0)
            {
                if (days == 0)
                {
                    MessageBox.Show("Niste unijeli ispravnu razliku između odlaska i povratka");
                    dtpOdlazak.Focus();
                }
                else
                {
                    brSati = days * 24;
                }
            }
            else
            {
                if (days != 0)
                {
                    brSati = (days * 24) + hours;
                }
                else
                {
                    brSati = hours;
                }
            }

            frmMain.broj = Int32.Parse(cmbOdaberi.SelectedValue.ToString());
            queriesTableAdapter1.G8_UnosTroskovaVisekratni(dtpOdlazak.Value, dtpPovratak.Value, brSati, frmMain.broj);
            frmMain.zapisiStatusnuTraku("Račun je poslan!", 1, 1);
            MessageBox.Show("Račun je poslan!");
            this.Close();
        }

        private void btnUnosTroskovaVisekratni_Click(object sender, EventArgs e)
        {
            frmMain.broj = Int32.Parse(cmbOdaberi.SelectedValue.ToString());
            frmUnosTroskovaVisekratni formaUnos = new frmUnosTroskovaVisekratni();
            formaUnos.Show();
        }
    }
}
