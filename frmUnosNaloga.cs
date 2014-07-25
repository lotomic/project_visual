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
    public partial class frmUnosNaloga : Form
    {
        public frmUnosNaloga()
        {

                    InitializeComponent();
        }

        private void btnUnosNaloga_Click(object sender, EventArgs e)
        {
            if  ( (cmbNositeljTrosk.SelectedValue != null) &
                (cmbZahtjev.SelectedValue != null) &
                (cmbVozilo.SelectedValue != null))
            {
                //ovdje convertat vrijednosti u int
                int zah = 0;
                int nos = 0;
                int voz = 0;

                zah = Convert.ToInt32(cmbZahtjev.SelectedValue);
                nos = Convert.ToInt32(cmbNositeljTrosk.SelectedValue);
                voz = Convert.ToInt32(cmbVozilo.SelectedValue);
                queriesTableAdapter1.unos_naloga(zah, nos, voz);
                frmMain.zapisiStatusnuTraku("Uspješno ste dodali nalog!", 3, 1);
                this.Close();
            }
            else
            {
                frmMain.zapisiStatusnuTraku("Molimo popunite prazna polja!", 3, 1);

            }
        }

        private void frmUnosNaloga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByZahtjev2(this.piDB1DataSet_tim17.putniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.vozila' table. You can move, or remove it, as needed.
            this.vozilaTableAdapter.Fill(this.piDB1DataSet_tim17.vozila);
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.nositeljTroskova' table. You can move, or remove it, as needed.
            this.nositeljTroskovaTableAdapter.Fill(this.piDB1DataSet_tim17.nositeljTroskova);


        }

        private void cmbZahtjev_SelectedValueChanged(object sender, EventArgs e)
        {
            int idZahtj = 0;
            idZahtj = Convert.ToInt32(cmbZahtjev.SelectedValue);
            this.putniNalogTableAdapter.FillByZahtjevPoIdZahtjev(this.piDB1DataSet_tim17, idZahtj);
            
        }

        private void cmbZahtjev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgwZahtjevKodUnosaNaloga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    }
}
