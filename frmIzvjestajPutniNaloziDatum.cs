using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Uprava.NET
{
    public partial class frmIzvjestajPutniNaloziDatum : Form
    {
        public frmIzvjestajPutniNaloziDatum()
        {
            InitializeComponent();
        }

        private void frmIzvjestajPutniNaloziDatum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);
        
        }

        /// <summary>
        /// klik na gumb prikaz naloga prikazuje naloge od određenog datuma, do određenog datuma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrikaziNaloge_Click(object sender, EventArgs e)
        {
            this.putniNalogTableAdapter.FillByDatum(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName, dtpDateFrom.Value, dtpDateTo.Value);
            ReportParameter rptParam;
            rptParam = new ReportParameter("ParamUserName", frmMain.loggedUser.Name + " " + frmMain.loggedUser.Surname);
            rpvNaloziDatum.LocalReport.SetParameters(rptParam);
            this.rpvNaloziDatum.RefreshReport();
        }
    }
}
