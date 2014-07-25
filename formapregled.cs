using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace TIM18_racunovodstvo
{
    public partial class formapregled : Form
    {

        int ajmee;
        public formapregled()
        {
            InitializeComponent();
        }

        tim18_racunovodstvo upiti = new tim18_racunovodstvo();




        public void popuni(string nalog) {
            bool nadjen = false;
            brnaloga.Text = nalog;
            int br_naloga = int.Parse(nalog);
            ajmee = br_naloga;
            SqlDataReader lol;

            lol = upiti.podaciOnalogu(br_naloga);

            lol.Read();
            int status = (int)(lol.GetValue(lol.GetOrdinal("id_statusa")));

            if (status == 2) {
                SqlDataReader jesuisplacene;
                jesuisplacene = upiti.provjeri();

                try
                {
                    while (jesuisplacene.Read())
                    {
                        int broj77 = int.Parse(jesuisplacene.GetValue(jesuisplacene.GetOrdinal("id")).ToString());
                        if (broj77 == ajmee)
                        {
                            nadjen = true;
                        }
                    }
                    if (nadjen == false) {
                        btnisplati.Visible = true;
                    }
                }
                catch
                {
                    btnisplati.Visible = false;
                }
            }

            if (status == 4) {

                btnispisi.Visible = true;
            }

            dkdatuma.Text = lol.GetValue(lol.GetOrdinal("datumKreiranja")).ToString(); 
            dpdatuma.Text = lol.GetValue(lol.GetOrdinal("vrijemePolaska")).ToString();
            dpovratka.Text = lol.GetValue(lol.GetOrdinal("vrijemePovratka")).ToString();
            polaziste.Text = lol.GetValue(lol.GetOrdinal("polaziste")).ToString();
            odrediste.Text = lol.GetValue(lol.GetOrdinal("odrediste")).ToString();
            nastavnik.Text = lol.GetValue(lol.GetOrdinal("nastavnik")).ToString(); 
        }

        /// <summary>
        /// event handler kod printanja, preuzeto i izmijenjeno sa "http://social.msdn.microsoft.com/Forums/en-US/csharpgeneral/thread/eb80fbbe-6b89-4c3d-9ede-88a2b105c714/"
        /// </summary>
        private void slikaforme(object o, PrintPageEventArgs e) {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int sirina = this.Width;
            int visina = this.Height;
            Rectangle granica = new Rectangle(x,y,sirina,visina);

            Bitmap slika = new Bitmap(sirina, visina);
            this.DrawToBitmap(slika, granica);
            Point p = new Point(200, 200);
            e.Graphics.DrawImage(slika, p);    
        }

        private void btnispisi_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage +=new PrintPageEventHandler(slikaforme);
            pd.Print();
        }

        private void btnisplati_Click(object sender, EventArgs e)
        {
           
            string lool = System.DateTime.Now.ToLongTimeString();
            this.putniNalogTableAdapter.akontacija(this.piDB1DataSet.putniNalog, ajmee, System.DateTime.Parse(lool));
            MessageBox.Show("Isplaćena je akontacija za putni nalog: " + ajmee + "!");
            this.Close();
        }

        private void formapregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);

        }


        


        //private void putniNalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
            //this.Validate();
           // this.putniNalogBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.piDB1DataSet);

        //}

       
    }
}
