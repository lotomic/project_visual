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
    public partial class formaobracun : Form
    {
        private formapretrazivanje parent_veza;
        public formaobracun(formapretrazivanje parent)
        {
            InitializeComponent();
            parent_veza = parent;

        }

        tim18_racunovodstvo upiti = new tim18_racunovodstvo();
        /// <summary>
        /// Forma u kojoj pregledavamo nalog prije obračuna
        /// </summary>
        /// <param name="nalog">Nalog koji obračunavamo</param>
        public void obracunaj(string nalog)
        {

            nalogbr.Text = nalog;
            int br_naloga = int.Parse(nalog);

            SqlDataReader lol;

            lol = upiti.troskovi(br_naloga);

            lol.Read();
            uktroskovi.Text = lol.GetValue(lol.GetOrdinal("iznos")).ToString();
            akontacija.Text = lol.GetValue(lol.GetOrdinal("akontacija")).ToString();
            akontacija.Text = akontacija.Text.Remove(akontacija.TextLength - 2);

            float result = 0;
            float broj1 = float.Parse(uktroskovi.Text);
            if (float.TryParse(akontacija.Text, out result))
            {
                float broj2 = float.Parse(akontacija.Text);
                float broj3 = broj1 - broj2;
                razlika.Text = broj3.ToString();
            }
            else
            {
                razlika.Text = "Impossible";
            }

        }
        /// <summary>
        /// na klik pozovi forme, ovisno jeli odabran tekući li gotovina
        /// </summary>
        private void obracunajtroskove_Click(object sender, EventArgs e)
        {
            SqlDataReader knjizenje;
            knjizenje = upiti.pojedinitroskovi(int.Parse(nalogbr.Text));

            formaknjizenje knjizi = new formaknjizenje();
            knjizi.proknjizi(knjizenje, float.Parse(razlika.Text), int.Parse(nalogbr.Text));



            if (radioracun.Checked)
            {

                formaobracunaj obracunaj = new formaobracunaj();

                SqlDataReader teacher;

                teacher = upiti.dajnastavnika(nalogbr.Text);

                obracunaj.uplatnica(teacher, razlika.Text, nalogbr.Text);

                obracunaj.MdiParent = this.MdiParent;
                obracunaj.Show();



            }

            else
            {

                formaisplatnica isplatnica = new formaisplatnica();

                SqlDataReader lol1;

                lol1 = upiti.dajnastavnika(nalogbr.Text);

                isplatnica.isplati(lol1, razlika.Text, nalogbr.Text);

                isplatnica.MdiParent = this.MdiParent;
                isplatnica.Show();

            }
            parent_veza.Close(); 
            this.Close();
            knjizi.MdiParent = this.MdiParent;
            knjizi.Show();


        }
    }
}
