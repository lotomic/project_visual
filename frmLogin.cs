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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                 
                //autentificiraj korisnika
                iUser tmpUser = frmMain.loginAuthenticate.Authenticate(txtUsername.Text, txtPassword.Text);
                //ako nije pronađen korisnik (neuspješna prijava)
                if ((tmpUser == null))
                {
                    
                    frmMain.loggedUser = null;
                    frmMain.zapisiStatusnuTraku("Prijava neuspješna, nepostojeći korisnik/ nema prava", 1, 1);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                else //uspješna prijava
                {
                    
                    tmpUser = provjeriStanjePrava(tmpUser);
                    frmMain.loggedUser = tmpUser;
                    string uloge = " uloge: ";
                    string vrstaKorisnika = " Status korisnika:";
                    //"logiraj" prijavljenog korisnika u glavnoj aplikaciji
                    foreach (iRole item in tmpUser.AssignedRoles)
                    {
                        uloge += " |" + item.RoleName + "|";
                    }
                    //dohvati vrstu logiranog korisnika
                    if (tmpUser.AssignedRoles.Find(iRole => iRole.RoleName == "Dekan") != null)
                    {
                        vrstaKorisnika += " Dekan";
                       
                    }
                    else if (tmpUser.AssignedRoles.Find(iRole => iRole.RoleName == "Prodekan") != null)
                    {

                        vrstaKorisnika += " Prodekan";
                    }
                    string obavijesti=provjeriObavijesti(tmpUser);
                    frmMain.zapisiStatusnuTraku("Prijava uspješna, dobrodošli: " + tmpUser.Name + " " + tmpUser.Surname + vrstaKorisnika+uloge+" Obavijesti: "+ obavijesti, 0, 0);
                    frmMain.omoguciIzbornike();
                    this.Close();
                }
            }
            catch (Exception greska)
            {
                //ispisi gresku e
                MessageBox.Show("Greška: " + greska.ToString(), "Greška!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnLostPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string provjeriObavijesti(iUser korisnik){
            if (korisnik.isAbleTo(eActions.Approve))
	        {
                this.putniNalogTableAdapter1.puniPoDekanu(piDB1DataSet11.putniNalog);
            }
            else if(korisnik.isAbleTo(eActions.Sign))
            {
                this.putniNalogTableAdapter1.puniPoProdekanu(piDB1DataSet11.putniNalog);
            }
            if (piDB1DataSet11.putniNalog.Any())
            {
                return " imate " + piDB1DataSet11.putniNalog.Count.ToString() + " nalog/a za obradu.";
            }
            
            return " - ";
        }
       
        /// <summary>
        /// Provjerava stanje prenesenih prava korisnika
        /// </summary>
        /// <param name="korisnik">iUser korisnik koji se provjerava</param>
        /// <returns>vraca nazad "obrađenog" iUser korisnika</returns>
        private iUser provjeriStanjePrava(iUser korisnik)
        {
            //dohvati trenutno vrijeme
            DateTime datum = DateTime.Now;
            //dohvati sva prenešena prava koja korisnik ima
            this.prijenosPravaTableAdapter1.dohvatiPravaKorisnika(this.piDB1DataSet11.prijenosPrava,korisnik.UserName);
            //ako postoje prenošena prava obradi ih
            if (this.piDB1DataSet11.prijenosPrava.Any())
	        {
                //za svako prenošeno pravo
		        foreach (piDB1DataSet.prijenosPravaRow redak in this.piDB1DataSet11.prijenosPrava)
	            {
                    //provjeri da li je isteklo
		            if (DateTime.Compare(datum,Convert.ToDateTime(redak["trajanje"].ToString()))>0)
	                {
                        //dohvati vrijednosti istečenog retka
		                string brojRetka =redak["id_unos"].ToString();
                        string userName = redak["username"].ToString();
                        string uloga = redak["role"].ToString();
                        //ukloni prava
                        iRole ulogaBrisanja = frmMain.loginAuthenticate.GetRoles(uloga,true).First();
                        this.prijenosPravaTableAdapter1.brisiUnos(Convert.ToInt32(brojRetka));
                        frmMain.loginAuthenticate.Grant(korisnik,ulogaBrisanja,eGrant.Remove);    
                    }  
	            }
                //vrati korisnika sa uklonjenim pravima
                return frmMain.loginAuthenticate.GetUser(korisnik.UserName, true).First();
	        }
                //ako nisu mijenjana prava vrati istog korisnika
                return korisnik;
            
        }
        }
    }
