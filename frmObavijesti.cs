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
    public partial class frmObavijesti : Form
    {
        public frmObavijesti()
        {
            InitializeComponent();
        }

        /// <summary>
        /// učitavanjem forme, puni se tableAdapter nalozima logiranog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.FillByVlasnikOdobren(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);

        }

        /// <summary>
        /// klik na gumb izlaz zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.putniNalogTableAdapter.FillByVlasnikOdobren(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
            if (tabControl1.SelectedIndex == 1)
            {
                this.putniNalogTableAdapter.FillByVlasnikOdobren15(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                this.putniNalogTableAdapter.FillByVlasnikPopunjen(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                this.putniNalogTableAdapter.FillByVlasnikLikvidiran(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
            }
        }
    }
}
