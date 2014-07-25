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
 
    
    public partial class frmPregledNalogaTaj : Form
    {
        public frmPregledNalogaTaj()
        {

                InitializeComponent();

        }

        private void frmPregledNaloga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.NalogVozilo' table. You can move, or remove it, as needed.
            this.nalogVoziloTableAdapter.FillByNalogVozilo(this.piDB1DataSet_tim17.NalogVozilo);
                       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            

            string red = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[0].Value.ToString(); //dohvat id naloga

            this.nalogVoziloBindingSource.RemoveCurrent();
  
            int ired = Convert.ToInt32(red);

            this.nalogVoziloTableAdapter.DeleteQueryVozilaIzTroskovi(ired); //mora bit prije ovog poslje da prvo obrise vanjski kljuc gdje je referenciran
            this.nalogVoziloTableAdapter.DeleteQuery(ired); //mora bit poslje ovog prije

            frmMain.zapisiStatusnuTraku("Nalog je izbrisan", 3, 1);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.nalogVoziloBindingSource.EndEdit();

            string red = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[0].Value.ToString(); //dohvat id naloga
            int ired = Convert.ToInt32(red);

            string svrha = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[2].Value.ToString();
            string polaziste = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[5].Value.ToString();
            string odrediste = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[6].Value.ToString();
            string ako = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[7].Value.ToString();
            string id_nos = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[8].Value.ToString();
            string id_voz = dgwPregledNaloga.Rows[dgwPregledNaloga.CurrentRow.Index].Cells[14].Value.ToString();

            if (String.IsNullOrEmpty(ako)) ako = "0";
            
            decimal akontacija = Convert.ToDecimal(ako);
            int id_nositelj = Convert.ToInt32(id_nos);
            int id_vozila = Convert.ToInt32(id_voz);

            this.nalogVoziloTableAdapter.UpdateQueryPutniNalog(svrha, polaziste, odrediste, akontacija, id_nositelj, ired);
            this.nalogVoziloTableAdapter.UpdateQueryVoziloUTroskovi(id_vozila, ired);


            frmMain.zapisiStatusnuTraku("Promjene na nalogu su spremljene", 3, 1);
            dgwPregledNaloga.Refresh();

        }

        private void chbSviNalozi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSviNalozi.Checked)
            {
                this.nalogVoziloTableAdapter.FillBySviNalozi(this.piDB1DataSet_tim17.NalogVozilo);
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                this.nalogVoziloTableAdapter.FillByNalogVozilo(this.piDB1DataSet_tim17.NalogVozilo);
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void dgwPregledNaloga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
