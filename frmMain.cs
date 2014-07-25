using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using foi.pi;
using TIM18_racunovodstvo;

namespace Uprava.NET
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        #region Varijable

        //Prijavljeni korisnik
        public static iUser loggedUser;
        public static Login loginAuthenticate= new Login();

        //id putnog naloga i suma troškova - nastavnik koristi
        public static int broj;
        public static decimal sumaTroskova = 0;

        //statusna traka
        public static ToolStripStatusLabel statusna_traka;

        public static ToolStripMenuItem upravaIzbornik;
        public static ToolStripMenuItem nastavnikIzbornik;
        public static ToolStripMenuItem tajnicaIzbornik;
        public static ToolStripMenuItem prijenosPrava;
        public static ToolStripMenuItem pregledNaloga;
        public static ToolStripMenuItem generiranjeNalogaRasporedom;
        public static ToolStripMenuItem racunovodstvoIzbornik;
      
        #endregion

        /// <summary>
        /// Metoda za prikaz login forme
        /// Forma ce se prikazati unutar MDI roditelja
        /// </summary>
        private void openLogin()
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.MdiParent = this;
            FrmLogin.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //poveži statičnu varijablu sa statusnom trakom na formi nakon učitanja forme
            statusna_traka = ssLabel;
            upravaIzbornik = this.upravaToolStripMenuItem;
            tajnicaIzbornik = this.tajnicaToolStripMenuItem;
            nastavnikIzbornik = this.lstNastavnik;
            prijenosPrava = this.prijenosPravaToolStripMenuItem;
            pregledNaloga=this.pregledNalogaToolStripMenuItem;
            generiranjeNalogaRasporedom=this.generiranjeNalogaPoRasporeduToolStripMenuItem;
            racunovodstvoIzbornik = this.racunovodstvoToolStripMenuItem; 

            //omoguci izbornike na temelju korisnika
            omoguciIzbornike();
            //otvori login formu
            openLogin();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prikaz login forme
            openLogin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            loggedUser = null;
            omoguciIzbornike();

            //zatvori sve prozore
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
            zapisiStatusnuTraku("", 2, 2);
            openLogin();

        }

        /// <summary>
        /// Prikaz dijaloškog okvira sa pitanjem da li korisnik želi
        /// zatvoriti aplikaciju
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show(
                "Želite li zatvoriti aplikaciju?",this.Text, 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                )==DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        /// <summary>
        /// Metoda za zapis teksta u statusnu traku
        /// </summary>
        /// <param name="text">Tekst koji se prikazuje</param>
        /// <param name="duration">Trajanje prikaza teksta</param>
        /// <param name="priority">Prioritet poruke 0 - najveći 5 - najmanji</param>
        public static void zapisiStatusnuTraku(string text, int duration, int priority)
        {
            statusna_traka.Text = text;
        }
        private void prijenosPravaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrijenosPrava prijenosPrava = new frmPrijenosPrava();
            prijenosPrava.MdiParent = this;
            prijenosPrava.Show();
        }

        public static void omoguciIzbornike(){
           //ako je korisnik logiran
            if (loggedUser!=null)
	        {
                List<iRole> uloge = loginAuthenticate.GetRoles();
                foreach (iRole uloga in loggedUser.AssignedRoles)
                {
                    switch (uloga.RoleName.ToString().ToLower())
                    {
                        case "nastavnik":
                            nastavnikIzbornik.Enabled = true;
                            break;
                        case "dekan":
                            upravaIzbornik.Enabled = true;
                            prijenosPrava.Enabled = true;
                            pregledNaloga.Enabled = true;
                            generiranjeNalogaRasporedom.Enabled = true;
                            break;
                        case "prodekan":
                            upravaIzbornik.Enabled = true;
                            prijenosPrava.Enabled = true;
                            pregledNaloga.Enabled = true;
                            generiranjeNalogaRasporedom.Enabled = true;
                            break;
                        case "tajnik":
                            tajnicaIzbornik.Enabled = true;
                            break;

                        case "racunovoda":
                            racunovodstvoIzbornik.Enabled = true; 
                            break;
                    }     
                }
            //ako korisnik nije logiran
	        }else
	        {
                tajnicaIzbornik.Enabled = false;
                nastavnikIzbornik.Enabled = false;
                upravaIzbornik.Enabled = false;
                prijenosPrava.Enabled = false;
                pregledNaloga.Enabled = false;
                generiranjeNalogaRasporedom.Enabled = false;
                racunovodstvoIzbornik.Enabled = false; 
	        }
        }

        private void pregledNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNaloga pregledNaloga = new frmPregledNaloga();
            pregledNaloga.MdiParent = this;
            pregledNaloga.Show();
        }

        private void debugWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about infoWindow = new about();
            infoWindow.MdiParent = this;
            infoWindow.Show();
        }

        private void generiranjeNalogaPoRasporeduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRasporedGeneriranje pregledNaloga = new frmRasporedGeneriranje();
            pregledNaloga.MdiParent = this;
            pregledNaloga.Show();
        }

        private void evidencijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvidencijaAuta evidencijaAuta = new frmEvidencijaAuta();
            evidencijaAuta.MdiParent = this;
            evidencijaAuta.Show();
        }

        private void pregledPristiglizZahtjevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledZahtjeva pregledZahtjeva = new frmPregledZahtjeva();
            pregledZahtjeva.MdiParent = this;
            pregledZahtjeva.Show();

        }

        private void unosNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosNaloga unosNaloga = new frmUnosNaloga();
            unosNaloga.MdiParent = this;
            unosNaloga.Show();
        }

        private void pregledPutnihNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNalogaTaj pregledNalogaTaj = new frmPregledNalogaTaj();
            pregledNalogaTaj.MdiParent = this;
            pregledNalogaTaj.Show();
        }

        private void lstNastavnikKreirajZahtjev_Click(object sender, EventArgs e)
        {
            frmZahtjev forma = new frmZahtjev();
            forma.MdiParent = this;
            forma.Show();
        }

        private void lstNastavnikKreirani_Click(object sender, EventArgs e)
        {
            frmPregledKreiranogNaloga forma = new frmPregledKreiranogNaloga();
            forma.MdiParent = this;
            forma.Show();
        }

        private void lstNastavnikAkontacija_Click(object sender, EventArgs e)
        {
            frmAkontacija form = new frmAkontacija();
            form.MdiParent = this;
            form.Show();
        }

        private void lstNastavnikPutniRacun_Click(object sender, EventArgs e)
        {
            frmRacun formaRacun = new frmRacun();
            formaRacun.MdiParent = this;
            formaRacun.Show();
        }

        private void lstNastavnikObavijesti_Click(object sender, EventArgs e)
        {
            frmObavijesti formaObavijesti = new frmObavijesti();
            formaObavijesti.MdiParent = this;
            formaObavijesti.Show();
        }

        private void lstNastavnikArhiva_Click(object sender, EventArgs e)
        {
            frmArhivaPutniNalozi formaArhiva = new frmArhivaPutniNalozi();
            formaArhiva.MdiParent = this;
            formaArhiva.Show();
        }

        private void lstNastavnikRadSBazom_Click(object sender, EventArgs e)
        {
            kataloskiPodaci forma = new kataloskiPodaci();
            forma.MdiParent = this;
            forma.Show();
        }

        private void lstNastavnikSviPutniNalozi_Click(object sender, EventArgs e)
        {
            frmSviPutniNalozi formaSvi = new frmSviPutniNalozi();
            formaSvi.MdiParent = this;
            formaSvi.Show();
        }

        private void lstNastavnikPutniNaloziPoDatumu_Click(object sender, EventArgs e)
        {
            frmIzvjestajPutniNaloziDatum forma = new frmIzvjestajPutniNaloziDatum();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pretrazivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formapretrazivanje formapretrazivanje = new formapretrazivanje();
            formapretrazivanje.MdiParent = this;
            formapretrazivanje.Show();
        }

        private void pregledGlavneKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaknjizenje citaj = new formaknjizenje();
            citaj.citaj_knjigu();
            citaj.MdiParent = this;
            citaj.Show();
        }

        }
    }
