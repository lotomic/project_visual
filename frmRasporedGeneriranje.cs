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
    public partial class frmRasporedGeneriranje : Form
    {
        public frmRasporedGeneriranje()
        {
            InitializeComponent();
           
        }

        

        private void btnOdabirRasporeda_Click(object sender, EventArgs e)
        {
           DialogResult rezultat= ofdRaspored.ShowDialog();
           if (rezultat==DialogResult.OK)
           {
               txtOdabraniRaspored.Text = ofdRaspored.FileName;
           }
        }

        private void btnGenerirajNaloge_Click(object sender, EventArgs e)
        {
            //dodaj provjeru valjanosti rasporeda?
            if (txtOdabraniRaspored.Text.Contains(".xml"))
            {
                bool dodano = false;
                rasporedParse rasporedi = new rasporedParse(txtOdabraniRaspored.Text);
                List<putniNalog> putniNalozi = rasporedi.generirajNaloge();
                if (putniNalozi.Count != 0)
                {
                    List<putniNalog> generiraniNalozi= new List<putniNalog>();
                    //prodji kroz sve naloge
                    foreach (putniNalog item in putniNalozi)
                    {
                        //potrazi nalog u bazi
                        this.putniNalogTableAdapter1.FillByGeneriranjeRasporedom(this.piDB1DataSet11.putniNalog,
                            item.svrha.ToString(),item.vrijemePolaska,item.vrijemePovratka,item.polaziste,
                            item.odrediste,item.nastavnik
                            );
                        //ako ne postoji takav nalog u bazi
                        if (piDB1DataSet11.putniNalog.Count==0)
                        {
                            dodano = true;
                            
                            this.putniNalogTableAdapter1.insertPoRasporedu(item.datumKreiranja, item.svrha, item.vrijemePolaska,
                                                                           item.vrijemePovratka, item.polaziste, item.odrediste,6, item.nastavnik,
                                                                            2, item.visekratniPocetak.ToShortDateString(), item.visekratniKraj.ToShortDateString());
                                 
                            generiraniNalozi.Add(item);

                        }

                    }
                    if (!dodano)
                    {
                        frmMain.zapisiStatusnuTraku("Nema novih naloga iz rasporeda.", 2, 2);
                    }
                    dataGridView1.DataSource = generiraniNalozi;
                }
                else
                {
                    frmMain.zapisiStatusnuTraku("Ne postoji valjan raspored/nastavnik", 2, 2);
                }
            }
            else
            {
                frmMain.zapisiStatusnuTraku("Molimo odaberite raspored", 2, 2);
            }
            
        }

        
    }
}
