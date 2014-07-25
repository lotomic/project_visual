using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIM18_racunovodstvo
{
    public partial class formaobracunaj : Form
    {
    
        public formaobracunaj()
        {
            InitializeComponent();
        }


        /// <summary>
        /// metoda koja nam provjerava dugujemo li mi nastavniku ili on nama, te na taj način sastavlja uplatnicu
        /// </summary>
        /// <param name="korisnik">sqldatareader varijabla koja nam služi da pročitamo ime nastavnika</param>
        /// <param name="razlika">iznos(pozitivan ili negativan)</param>
        /// <param name="nalogbr">broj naloga temeljem kojeg izvlačimo podatke iz baze</param>
        public void uplatnica(SqlDataReader korisnik, string razlika, string nalogbr)
        {

            formaknjizenje poveznica = new formaknjizenje(); 

            float razlika1 = float.Parse(razlika);
            int nalogbr1 = int.Parse(nalogbr);
            korisnik.Read();
            if (razlika1 < 0)
            {
               
                txtplatitelj.Text = korisnik.GetValue(korisnik.GetOrdinal("nastavnik")).ToString() + ", Pavlinska 2";
          
                txtprimatelj.Text = "Fakultet organizacije i informatike, Pavlinska 2";
                txtopis.Text = "Uplata na račun FOI-a"; 

            
            }
            else {

           
          
                txtprimatelj.Text = korisnik.GetValue(korisnik.GetOrdinal("nastavnik")).ToString() + ", Pavlinska 2";
                txtplatitelj.Text = "Fakultet organizacije i informatike, Pavlinska 2";
                txtopis.Text = "Isplata primatelju";

             
            }

            txtiznos.Text = string.Format("{0:C}", Math.Abs(razlika1));

            txtdatum.Text = DateTime.Now.ToLongTimeString(); 
        
        }

    }
}
