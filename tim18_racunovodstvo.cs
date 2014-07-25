using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TIM18_racunovodstvo
{
    class tim18_racunovodstvo
    {

        private SqlConnection konekcija = null;
        private SqlConnection povezise()
        {
            string konstring = Uprava.NET.Properties.Settings.Default.piDB1ConnectionString; 
            konekcija = new SqlConnection(konstring);
            konekcija.Open();
            return konekcija;
        }

        public SqlDataReader baza(string sql)
        {
            SqlDataReader rdr = null;

            SqlCommand naredba = new SqlCommand(sql, povezise());
            naredba.CommandType = CommandType.Text;
            naredba.CommandTimeout = 0;
            rdr = naredba.ExecuteReader();
            return rdr;
        }

        //funkcije formaknjiženje
        public SqlDataReader vrsta(int id_naloga, int broj)
        {

            return baza("select troskovi.iznos, troskovi.id_troska from troskovi where troskovi.id_naloga = " + id_naloga + "and troskovi.id_vrstaTrosak=" + broj + ";");
        }

        public SqlDataReader upisiGlavnaKnjiga(int prvi, int drugi)
        {
           
            return baza("select putniNalog.id_naloga as nalog, putniNalog.id_statusa, putniNalog.akontacija, troskovi_konto.datum_knjizenja as datum, troskovi_konto.broj_konta as konto, putniNalog.akontacija as akontacija, SUM(troskovi.iznos) as suma from putniNalog join troskovi on troskovi.id_naloga=putniNalog.id_naloga join troskovi_konto on troskovi_konto.id_troska=troskovi.id_troska where putniNalog.id_naloga=" + prvi + "and  troskovi.id_vrstaTrosak=" + drugi + "and putniNalog.id_statusa=4 group by putniNalog.id_naloga, putniNalog.id_statusa, putniNalog.akontacija, troskovi_konto.datum_knjizenja, troskovi_konto.broj_konta, putniNalog.akontacija; ");

        }

      
        /// <summary>
        /// Čita glavnu knjigu, u slučaju -1 sumira sve troškove i vraća razliku, else vraća za sve troškove pojedine vrijednosti
        /// </summary>
        /// <param name="brojac"></param>
        /// <returns></returns>
        public SqlDataReader upisiGlavnaKnjiga2(int brojac)
        {
            if (brojac == 0)
            {
                return baza("select putniNalog.id_naloga as nalog, putniNalog.datumOdobrenja as datum, putniNalog.akontacija as akontacija from putniNalog where putniNalog.isplacena_akontacja=1;");
            }
            else if (brojac == -1) {

                return baza("select putniNalog.id_naloga as nalog, putniNalog.id_statusa, putniNalog.datumOdobrenja as datum,putniNalog.akontacija as akontacija, SUM(troskovi.iznos) as suma, (SUM(troskovi.iznos) - putniNalog.akontacija) as razlika, troskovi_konto.datum_knjizenja as datum1 from putniNalog join troskovi on troskovi.id_naloga=putniNalog.id_naloga join troskovi_konto on troskovi_konto.id_troska=troskovi.id_troska where putniNalog.id_statusa=4 and putniNalog.isplacena_akontacja=1 group by putniNalog.id_naloga, putniNalog.id_statusa, putniNalog.datumOdobrenja ,putniNalog.akontacija, putniNalog.akontacija, troskovi_konto.datum_knjizenja;");
            }
            else
            {
                return baza("select putniNalog.id_naloga as nalog, troskovi_konto.datum_knjizenja as datum, putniNalog.id_statusa, troskovi_konto.broj_konta as konto, putniNalog.akontacija as akontacija, SUM(troskovi.iznos) as suma, (SUM(troskovi.iznos) - putniNalog.akontacija) as razlika from putniNalog join troskovi on troskovi.id_naloga=putniNalog.id_naloga join troskovi_konto on troskovi_konto.id_troska=troskovi.id_troska where putniNalog.id_statusa=4 and putniNalog.isplacena_akontacja=1 and troskovi.id_vrstaTrosak=" + brojac + "group by putniNalog.id_naloga, putniNalog.id_statusa, putniNalog.akontacija, troskovi_konto.broj_konta, putniNalog.akontacija, troskovi_konto.datum_knjizenja");

            }
        }

         public SqlDataReader upisiGlavnaKnjiga4()
        {

            return baza("select putniNalog.id_naloga as nalog, putniNalog.id_statusa, putniNalog.akontacija as akontacija, SUM(troskovi.iznos) as suma, (SUM(troskovi.iznos) - putniNalog.akontacija) as razlika from putniNalog join troskovi on troskovi.id_naloga=putniNalog.id_naloga where putniNalog.id_statusa=4 and putniNalog.isplacena_akontacja=1 group by putniNalog.id_naloga, putniNalog.id_statusa, putniNalog.akontacija, putniNalog.akontacija;");
        }
        
        
        //funkcije formaknjizenje

        //funkcije formaobracun
        /// <summary>
        /// čitanje podataka o troškovima
        /// </summary>
        /// <param name="br_nalog">id naloga</param>
        /// <returns></returns>
        public SqlDataReader troskovi(int br_nalog)
        {

            return baza("SELECT putniNalog.akontacija as akontacija, SUM(troskovi.iznos) as iznos from putniNalog join troskovi on troskovi.id_naloga=putniNalog.id_naloga where putniNalog.id_naloga=" + br_nalog + "group by putniNalog.akontacija;");
        }

        public SqlDataReader pojedinitroskovi(int br_nalog)
        {

            return baza("SELECT distinct vrstaTrosak.id_vrsta as opis from vrstaTrosak, troskovi, putniNalog where troskovi.id_vrstaTrosak=vrstaTrosak.id_vrsta and troskovi.id_naloga=putniNalog.id_naloga and putniNalog.id_naloga=" + br_nalog + ";");
        }
        public SqlDataReader dajnastavnika(string nalog)
        {

            int broj_naloga = int.Parse(nalog);

            return baza("select nastavnik as nastavnik from putniNalog where id_naloga=" + broj_naloga + ";");

        }//funkcije formaobracun


        //formapregled


        public SqlDataReader podaciOnalogu(int br_nalog)
        {
            string upit = "SELECT *from putniNalog WHERE id_naloga=" + br_nalog + ";";
            return baza(upit);
        }
        //formapregled

        //formapretrazivanje

        public SqlDataReader dohvatinaloge(int status)
        {
            string upit = "SELECT *from putniNalog WHERE id_statusa=" + status + ";";
            return baza(upit);
        }
        //formapretrazivanje

        public SqlDataReader provjeri() {

            return baza("SELECT putniNalog.id_naloga as id from putniNalog where isplacena_akontacja=1;");
        }

    }
}
