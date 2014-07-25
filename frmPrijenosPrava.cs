using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using foi.pi;

namespace Uprava.NET
{
    public partial class frmPrijenosPrava : Form
    {
       

        public frmPrijenosPrava()
        {
            InitializeComponent();
        }

       

        private void frmPrijenosPrava_Load(object sender, EventArgs e)
        {
            puniKorisnikePrenesenihPrava();
            puniKorisnikeZaPrijenosPrava();
        }

        /// <summary>
        /// Puni korisnike kojima je  moguće prenijeti prava
        /// </summary>
        private void puniKorisnikeZaPrijenosPrava(){
            //sprema sve korisnike iz baze
            List<iUser> korisnici = frmMain.loginAuthenticate.GetUser();
            //makni logiranog korisnika iz liste
            korisnici.RemoveAll(iUser => iUser.UserName == frmMain.loggedUser.UserName);
            //dohvati ulogu logiranog korisnika
            List<iRole> uloga = frmMain.loginAuthenticate.GetRoles(frmMain.loggedUser.UserName.ToString(), true);
            //dohvati ulogu None za default prava
            iRole defaultUloga = frmMain.loginAuthenticate.GetRoles("None", true).First();
            //lista u koju spremamo korisnike koji vec imaju ulogu
            List<string> korisniciIzbacivanje = new List<string>();
            //prodji kroz sve korisnike
            for (int i = 0; i < korisnici.Count; i++)
            {
                //pokusaj dohvatiti uloge ( ako slucajno postoji neka da nema ulogu bacit ce exception, pa ga necemo maknut iz liste)
                 try 
	                {	
                    //prodji kroz sve uloge korisnika
                    for (int j = 0; j < korisnici[i].AssignedRoles.Count; j++)
			        {
			               //ako korisnik sadrzi ulogu logiranog korisnika
		                    if (korisnici[i].AssignedRoles[j].RoleName==uloga[0].RoleName)
	                        {
                                //smjesti tog korisnika u listu za izbacivanje
                                korisniciIzbacivanje.Add(korisnici[i].UserName);
	                        }
	                
			        }
                }
                 catch (Exception)
                 {
                     continue; //ako korisnik nema uloga nastavi na iduceg korisnika ( necemo ga izbaciti)
                 }
                
            }
            //prodji kroz sve korisnike za izbacivanje i izbaci ih iz ukupne liste
            foreach (string user in korisniciIzbacivanje)
            {
                korisnici.RemoveAll(iUser => iUser.UserName == user);
            }
           
           //povezi cmbKorisnici display i value member sa username-om (da zna koju varijablu iz objekta da koristi)
            cmbKorisnici.DisplayMember = "username";
            cmbKorisnici.ValueMember = "username";
            //postavi datasource kao listu korisnika
            cmbKorisnici.DataSource = korisnici;
        
        }
        
        /// <summary>
        /// Ispuni listu sa korisnicima koji vec imaju prava 
        /// logiranog korisnika
        /// </summary>
        private void puniKorisnikePrenesenihPrava()
        {
            //kreiraj listu u koju cemo spremati korisnike sa prenesenim pravima
            List<iUser> korisniciPrenesenihPrava = new List<iUser>();
            //spremi ulogu logiranog korisnika
            List<iRole> uloga = frmMain.loginAuthenticate.GetRoles(frmMain.loggedUser.UserName.ToString(), true);
            //dohvati korisnike sa prenesenim pravima
            korisniciPrenesenihPrava.AddRange(frmMain.loginAuthenticate.GetUser(uloga[0]));
            //makni logiranog korisnika iz liste
            korisniciPrenesenihPrava.RemoveAll(iUser => iUser.UserName == frmMain.loggedUser.UserName);
            //ako ne postoji korisnik s prenesenim pravima obavijesti user-a
            if(korisniciPrenesenihPrava.Count==0)
            {
                frmMain.zapisiStatusnuTraku("Ne postoji korisnik s prenesenim pravima", 1, 1);
            }
            //poveži lbox sa datasourceom korisnici prenesenih prava
            lboxPrenesenaPrava.DisplayMember = "username";
            lboxPrenesenaPrava.ValueMember = "username";
            lboxPrenesenaPrava.DataSource = korisniciPrenesenihPrava;

        
        }

        private void btnPrenesiPrava_Click(object sender, EventArgs e)
        {
            //dohvati ulogu ulogiranog korisnika
            iRole logiraniUserUloga = frmMain.loginAuthenticate.GetRoles(frmMain.loggedUser.UserName.ToString(),true).First();
            iRole noneUloga = frmMain.loginAuthenticate.GetRoles("None", true).First();
            if (cmbKorisnici.SelectedValue.ToString() != "")
            {
                //dohvati korisnika kome mijenjamo prava
                iUser korisnikPrijenosPrava = frmMain.loginAuthenticate.GetUser(cmbKorisnici.SelectedValue.ToString(), true).First();

                if (MessageBox.Show(
                "Jeste li sigurni da zelite predati ovlasti korisniku: " + cmbKorisnici.SelectedValue.ToString() + "?", "Predavanje ovlasti",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                {
                    //ako korisnik odustane vrati ga na prethodni ekran
                    return;
                }
                else //ako nastavi s izmjenom prava
                {
                    if (chkTrajniPrijenosPrava.Checked)//ako prenosimo trajni prijenos prava upisi null  u trajanje
                    {
                        //dodaj trajna prava
                        frmMain.loginAuthenticate.Grant(korisnikPrijenosPrava, logiraniUserUloga, eGrant.Add);
                        frmMain.loginAuthenticate.Grant(korisnikPrijenosPrava, noneUloga, eGrant.Remove);
                        //obavijesti korisnika o promjeni prava
                        frmMain.zapisiStatusnuTraku("Uspješna promjena prava korisnika: " + korisnikPrijenosPrava.UserName.ToString(), 1, 1);
                        //refreshaj stanja korisnika
                        puniKorisnikePrenesenihPrava();
                        puniKorisnikeZaPrijenosPrava();
                    }
                    else // promjena ovlasti na određeno vrijeme
                    {
                        //snimi trajanje u tablicu prijenosPrava
                        try
                        {
                            this.prijenosPravaTableAdapter1.unosPrijenosaPrava(korisnikPrijenosPrava.UserName, dtpTrajanjePrijenosa.Value,
                           logiraniUserUloga.RoleName, frmMain.loggedUser.UserName);
                        }
                        catch (Exception)
                        {
                            //vec prenesena prava
                           
                        }
                       
                        //dodaj prava u lokalnoj bazi
                        frmMain.loginAuthenticate.Grant(korisnikPrijenosPrava, logiraniUserUloga, eGrant.Add);
                        frmMain.loginAuthenticate.Grant(korisnikPrijenosPrava, noneUloga, eGrant.Remove);
                        //obavijesti korisnika o promjeni prava
                        frmMain.zapisiStatusnuTraku("Uspješna promjena prava korisnika: " + korisnikPrijenosPrava.UserName.ToString(), 1, 1);
                        //refreshaj stanja korisnika
                        puniKorisnikePrenesenihPrava();
                        puniKorisnikeZaPrijenosPrava();
                    }
                    
                }
            }
            else
            {
                frmMain.zapisiStatusnuTraku("Molimo odaberite korisnika za prijenos prava", 2, 2);
            }
        }

        private void chkTrajniPrijenosPrava_CheckedChanged(object sender, EventArgs e)
        {
            //iskljuci odabir datuma ako je odabrano trajno prenosenje prava
            if (chkTrajniPrijenosPrava.Checked)
            {
                dtpTrajanjePrijenosa.Enabled = false;
            }
            else if (!chkTrajniPrijenosPrava.Checked)
            {
                dtpTrajanjePrijenosa.Enabled = true;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lboxPrenesenaPrava.SelectedItem != null && lboxPrenesenaPrava.SelectedValue.ToString() != "")
            {
                iUser odabraniKorisnik = frmMain.loginAuthenticate.GetUser(lboxPrenesenaPrava.SelectedValue.ToString(), true).First();
                iRole ulogaLogiranog = frmMain.loginAuthenticate.GetRoles(frmMain.loggedUser.UserName.ToString(), true).First();
                if (MessageBox.Show(
                "Jeste li sigurni da zelite oduzeti ovlasti korisniku: " + lboxPrenesenaPrava.SelectedValue.ToString() + "?", "Oduzimanje ovlasti",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                {
                    //ako korisnik odustane vrati ga na prethodni ekran
                    return;
                }
                else //ako nastavi s izmjenom prava
                {
                    frmMain.loginAuthenticate.Grant(odabraniKorisnik, ulogaLogiranog, eGrant.Remove);
                    odabraniKorisnik = frmMain.loginAuthenticate.GetUser(odabraniKorisnik.UserName, true).First();
                    try
                    {
                       iRole ulogaPostoji= odabraniKorisnik.AssignedRoles.First();
                    }
                    catch (Exception)
                    {
                        
                        iRole uljezUloga = frmMain.loginAuthenticate.GetRoles("None",true).First();
                        frmMain.loginAuthenticate.Grant(odabraniKorisnik, uljezUloga, eGrant.Add);
                    }

                    this.prijenosPravaTableAdapter1.brisiUlogu(odabraniKorisnik.UserName, ulogaLogiranog.RoleName, frmMain.loggedUser.UserName);
                    //obavijesti korisnika o promjeni prava
                    frmMain.zapisiStatusnuTraku("Uspješna oduzimanja prava korisnika: " + odabraniKorisnik.UserName.ToString(), 1, 1);
                    //refreshaj stanja korisnika
                    puniKorisnikePrenesenihPrava();
                    puniKorisnikeZaPrijenosPrava();
                }
            }
            else
            {
                frmMain.zapisiStatusnuTraku("Morate odabrati korisnika da mu možete maknuti prava", 1, 1);
            }
           

        }


    }
}
