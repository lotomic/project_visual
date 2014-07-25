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
    public partial class frmPregledKreiranogNaloga : Form
    {
        public frmPregledKreiranogNaloga()
        {
            InitializeComponent();
        }

        private void frmPregledKreiranogNaloga_Load(object sender, EventArgs e)
        {
            this.putniNalogTableAdapter.FillByKreiranNalog(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
