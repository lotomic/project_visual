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
    public partial class frmPregledZahtjeva : Form
    {
        public frmPregledZahtjeva()
        {


                    InitializeComponent();

        }

        private void frmPregledZahtjeva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByZahtjev(this.piDB1DataSet_tim17.putniNalog);                          
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            putniNalogBindingSource.EndEdit();

            string red = dgwPregledZahtjeva.Rows[dgwPregledZahtjeva.CurrentRow.Index].Cells[0].Value.ToString();
            int ired = Convert.ToInt32(red);

            string opr = dgwPregledZahtjeva.Rows[dgwPregledZahtjeva.CurrentRow.Index].Cells[10].Value.ToString();

            if (String.IsNullOrEmpty(opr)) opr = "false";

            bool opravdan;

            opravdan = Convert.ToBoolean(opr);

            this.putniNalogTableAdapter.UpdateQuery(opravdan, ired);          

            putniNalogTableAdapter.FillByZahtjev(this.piDB1DataSet_tim17.putniNalog);

            dgwPregledZahtjeva.Refresh();
            
        }

        private void chbSviZahtjevi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSviZahtjevi.Checked)
            {
                this.putniNalogTableAdapter.FillByZahtjeviSvi(this.piDB1DataSet_tim17.putniNalog);
            }
            else
            {
                this.putniNalogTableAdapter.FillByZahtjev(this.piDB1DataSet_tim17.putniNalog);
            }
        }

        private void dgwPregledZahtjeva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
    }
}
