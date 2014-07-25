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
    public partial class frmSviPutniNalozi : Form
    {
        public frmSviPutniNalozi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// učitavanjem forme tableAdapter se puni svim nalozima prijavljenog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSviPutniNalozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByVlasnikNaloga(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            
            ReportParameter rptParam;
            rptParam = new ReportParameter("ParamUserName", frmMain.loggedUser.Name + " " + frmMain.loggedUser.Surname);
            rpvSviNalozi.LocalReport.SetParameters(rptParam);
            this.rpvSviNalozi.RefreshReport();
        }
    }
}
