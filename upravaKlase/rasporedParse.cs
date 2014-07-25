using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace Uprava.NET
{

    //struktura koja sadržava podatke putnog naloga
    public struct putniNalog
    {
        public DateTime datumKreiranja {get; set;}
        public string svrha{get; set;}
        public DateTime vrijemePolaska{get; set;}
        public DateTime vrijemePovratka { get; set; }
        public string polaziste { get; set; }
        public string odrediste { get; set; }
        public string nastavnik { get; set; }
        public DateTime visekratniPocetak { get; set; }
        public DateTime visekratniKraj { get; set; }
    }

    //spremanje potrebnih podataka o nastavniku
    public struct nastavnik
    {
        public string grad;
        public string adresa;
        public string username;
        public string katedra;
    }

    class rasporedParse
    {
       //varijable
        //varijabla koja će sadržavati raspored
        private XElement raspored;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="lokacijaRasporeda">Lokacija rasporeda koji se učitava</param>
        public rasporedParse(string lokacijaRasporeda)
        {
            XElement ucitavanjeDokumenta = XElement.Load(lokacijaRasporeda);
            raspored = ucitavanjeDokumenta;
        }


        public List<putniNalog> generirajNaloge()
        {

            List<putniNalog> putniNalozi = new List<putniNalog>();
            putniNalog nalog;
            //pohvataj sve rasporede
            foreach (var item in raspored.Elements("raspored"))
            {
                 //dohvati meta podatke rasporeda
                DateTime valjanost = Convert.ToDateTime((string)item.Attribute("valjanost"));
                string grad = (string)item.Attribute("grad");
                string adresa = (string)item.Attribute("adresa");
                if (DateTime.Compare(valjanost,DateTime.Now)>=0)
                {
                    nalog = new putniNalog();
                    //dohvati sve nastavnike iz trenutnog rasporeda
                    foreach (var n in item.Descendants("nastavnik"))
                    {
                        nastavnik nas = new nastavnik();
                        nas.grad = (string)n.Attribute("grad");
                        nas.adresa = (string)n.Attribute("adresa");
                        nas.username = (string)n.Element("osobniPodaci").Element("username");
                        if (nas.grad != grad && nas.adresa != adresa)
                        {
                            nalog.datumKreiranja = DateTime.Now;
                            nalog.visekratniPocetak = DateTime.Now.Date;
                            nalog.visekratniKraj = valjanost.Date;
                            nalog.polaziste = (string)item.Attribute("grad");
                            nalog.odrediste = (string)nas.grad;
                            nalog.nastavnik = nas.username;
                            nalog.vrijemePolaska = Convert.ToDateTime((string)n.Element("pocetakOdrzavanja"));
                            nalog.vrijemePovratka = Convert.ToDateTime((string)n.Element("krajOdrzavanja"));
                            nalog.svrha = (string)n.Element("kolegij");
                            putniNalozi.Add(nalog);
                        }

                    }
                }
            }

            return putniNalozi;

        }


    }
}
