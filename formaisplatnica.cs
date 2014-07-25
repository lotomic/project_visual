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
    public partial class formaisplatnica : Form
    {
        public formaisplatnica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda isplati poziva se ako odaberemo obračunavanje gotovinom
        /// </summary>
        /// <param name="nastavnik">SqlDataReader varijabla koja nam daje nastavnika koji je dužan ili potražuje od faksa</param>
        /// <param name="razlika">Provjerava se tko je kome dužan, ako je veća od 0 onda je nastavnik primatelj, u suprotnom platitelj</param>
        /// <param name="nalogbr">temeljem naloga broj</param>
        public void isplati(SqlDataReader nastavnik, string razlika, string nalogbr) {

            float razlika2 = float.Parse(razlika);
            if (razlika2 > 0)
            {
                labelispl.Visible = true;

                nastavnik.Read();

                txtnastavnik.Text = nastavnik.GetValue(nastavnik.GetOrdinal("nastavnik")).ToString();

                txtiznos.Text = string.Format("{0:C}", Math.Abs(razlika2));

                txtnalog.Text = nalogbr;

                txtmjesto.Text = "Varaždinu";

                txtdan.Text = DateTime.Now.ToLongTimeString();
            }

            else {
                labelupl.Visible = true;

                txtnastavnik.Text = "Fakultet organizacije i informatike Varaždin";

                txtiznos.Text = string.Format("{0:C}", Math.Abs(razlika2));

                txtnalog.Text = nalogbr;

                txtmjesto.Text = "Varaždinu";

                txtdan.Text = DateTime.Now.ToLongTimeString();
            }
        }


    }
}
