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
    

    public partial class formapretrazivanje : Form
    {
        public formapretrazivanje()
        {
            InitializeComponent();
        }

        tim18_racunovodstvo upiti = new tim18_racunovodstvo();
        private void formapretrazivanje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            //this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            //this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);
            //this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
           
            odabir.SelectedValueChanged += odabir_SelectedValueChanged;
            odabir.SelectedValue = 3;
        }

        /// <summary>
        /// Otvaranje pojedinog putnog naloga
        /// </summary>
        private void putninalog(DataGridViewCellEventArgs e) {

            if (dgvpretrazivanje.Rows[e.RowIndex].Cells["btnopcije"].Value.ToString() == "Pregledaj")
            {
                formapregled formapregled = new formapregled();
                formapregled.popuni(dgvpretrazivanje.Rows[e.RowIndex].Cells[0].Value.ToString());
                formapregled.MdiParent = this.MdiParent;
                formapregled.Show();
            }
            else {
                formaobracun formaobracun = new formaobracun(this);
                formaobracun.obracunaj(dgvpretrazivanje.Rows[e.RowIndex].Cells[0].Value.ToString());
                formaobracun.MdiParent = this.MdiParent;
                formaobracun.Show();

            }
           //this.Close(); 
        }

        /// <summary>
        /// Popunjavanje datagridview-a podacima iz baze
        /// </summary>
        private void puninalog()
        {
            SqlDataReader citac;
            dgvpretrazivanje.Rows.Clear();

            int status;
            try
            {
                citac = upiti.dohvatinaloge(int.Parse(odabir.SelectedValue.ToString()));
            

            while (citac.Read())
            {
                int br = dgvpretrazivanje.Rows.Add();
                
                status=(int)(citac.GetValue(citac.GetOrdinal("id_statusa")));
                dgvpretrazivanje.Rows[br].Cells[0].Value = citac.GetValue(citac.GetOrdinal("id_naloga"));
                dgvpretrazivanje.Rows[br].Cells[1].Value = citac.GetDateTime(citac.GetOrdinal("datumKreiranja"));

                if (status == 3)
                {
                    dgvpretrazivanje.Rows[br].Cells[13].Value = "Obračunaj";
                }
                else {
                    dgvpretrazivanje.Rows[br].Cells[13].Value = "Pregledaj";
                }

                if (citac.IsDBNull(citac.GetOrdinal("vrijemePolaska")))
                {
                    dgvpretrazivanje.Rows[br].Cells[2].Value = "-";
                }
                else{
                    dgvpretrazivanje.Rows[br].Cells[2].Value = citac.GetDateTime(citac.GetOrdinal("vrijemePolaska"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("vrijemePovratka")))
                {
                    dgvpretrazivanje.Rows[br].Cells[3].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[3].Value = citac.GetDateTime(citac.GetOrdinal("vrijemePovratka"));
                }
                if (citac.IsDBNull(citac.GetOrdinal("polaziste")))
                {
                    dgvpretrazivanje.Rows[br].Cells[4].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[4].Value = citac.GetValue(citac.GetOrdinal("polaziste"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("odrediste")))
                {
                    dgvpretrazivanje.Rows[br].Cells[5].Value = "-";
                }

                else
                {
                    dgvpretrazivanje.Rows[br].Cells[5].Value = citac.GetValue(citac.GetOrdinal("odrediste"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("akontacija")))
                {
                    dgvpretrazivanje.Rows[br].Cells[6].Value = "-";
                }

                else
                {
                    string akont = citac.GetValue(citac.GetOrdinal("akontacija")).ToString();

                    //akontacija.Text = akontacija.Text.Remove(akontacija.TextLength - 2);
                    dgvpretrazivanje.Rows[br].Cells[6].Value = akont.Remove(akont.Length - 2); 

                }

                if (citac.IsDBNull(citac.GetOrdinal("odgovornaOsoba")))
                {
                    dgvpretrazivanje.Rows[br].Cells[7].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[7].Value = citac.GetValue(citac.GetOrdinal("odgovornaOsoba"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("nastavnik")))
                {
                    dgvpretrazivanje.Rows[br].Cells[8].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[8].Value = citac.GetValue(citac.GetOrdinal("nastavnik"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("datumLikvidacije")))
                {
                    dgvpretrazivanje.Rows[br].Cells[9].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[9].Value = citac.GetDateTime(citac.GetOrdinal("datumLikvidacije"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("likvidirao")))
                {
                    dgvpretrazivanje.Rows[br].Cells[10].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[10].Value = citac.GetValue(citac.GetOrdinal("likvidirao"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("odobrio")))
                {
                    dgvpretrazivanje.Rows[br].Cells[11].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[11].Value = citac.GetValue(citac.GetOrdinal("odobrio"));
                }

                if (citac.IsDBNull(citac.GetOrdinal("potpisao")))
                {
                    dgvpretrazivanje.Rows[br].Cells[12].Value = "-";
                }
                else
                {
                    dgvpretrazivanje.Rows[br].Cells[12].Value = citac.GetValue(citac.GetOrdinal("potpisao"));
                }
            }}
         catch{
                MessageBox.Show("Nema naloga!");
            }
        }
        /// <summary>
        /// na promijenjene željene naloge, ponovno puni naloge
        /// </summary>
        private void odabir_SelectedValueChanged(object sender, EventArgs e)
        {
            puninalog();
        }
        private void formapretrazivanje_FormClosing(object sender, FormClosingEventArgs e)
        {
            odabir.SelectedValueChanged -= odabir_SelectedValueChanged;
        }
        /// <summary>
        /// ako smo kliknuli na btnopcije, pozivamo metodu da vidimo jesmo li stisnuli pregledaj ili obračunaj
        /// </summary>
        private void dgvpretrazivanje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpretrazivanje.Columns[e.ColumnIndex].Name == "btnopcije") {
                putninalog(e);
            }
        }
    }
}
