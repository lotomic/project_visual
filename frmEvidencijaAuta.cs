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
    public partial class frmEvidencijaAuta : Form
    {
        public frmEvidencijaAuta()
        {

                InitializeComponent();

            
        }

        private void frmEvidencijaAuta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet_tim17.RaspolozivostAuta' table. You can move, or remove it, as needed.
            this.raspolozivostAutaTableAdapter.FillByRaspolozivost(this.piDB1DataSet_tim17.RaspolozivostAuta);                    
        }

        private void dgwEvidencijaAuta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
