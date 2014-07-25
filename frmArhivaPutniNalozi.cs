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
    public partial class frmArhivaPutniNalozi : Form
    {
        public frmArhivaPutniNalozi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// učitavanjem forme, puni se table adapter potpisanim nalozima prijavljenog korisnika, te ostali podaci potrebni za prikaz vanjskih ključeva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmArhivaPutniNalozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaPutniNalog' table. You can move, or remove it, as needed.
            this.vrstaPutniNalogTableAdapter.Fill(this.piDB1DataSet.vrstaPutniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.vozila' table. You can move, or remove it, as needed.
            this.vozilaTableAdapter.Fill(this.piDB1DataSet.vozila);
            // TODO: This line of code loads data into the 'piDB1DataSet.nositeljTroskova' table. You can move, or remove it, as needed.
            this.nositeljTroskovaTableAdapter.Fill(this.piDB1DataSet.nositeljTroskova);
            //popunjava se podacima o nalozima trenutno logiranog korisnika
            this.putniNalogTableAdapter.FillByVlasnikPotpisan(this.piDB1DataSet.putniNalog, frmMain.loggedUser.UserName);
        }

        /// <summary>
        /// gumb odustani - zatvaranje forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// izbjegavanje greške kod zatvaranja prikaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmArhivaPutniNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvArhivaPutniNalozi.DataSource = null;
        }
    }
}
