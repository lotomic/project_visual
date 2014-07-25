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
    public partial class kataloskiPodaci : Form
    {
        public kataloskiPodaci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// učitavanjem forme se tableAdapter puni vozilima iz baze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kataloskiPodaci_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaTrosak' table. You can move, or remove it, as needed.
            this.vrstaTrosakTableAdapter.Fill(this.piDB1DataSet.vrstaTrosak);
            // TODO: This line of code loads data into the 'piDB1DataSet.vozila' table. You can move, or remove it, as needed.
            this.vozilaTableAdapter.Fill(this.piDB1DataSet.vozila);
            // TODO: This line of code loads data into the 'piDB1DataSet.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet.vrstaPutniNalog' table. You can move, or remove it, as needed.
            this.vrstaPutniNalogTableAdapter.Fill(this.piDB1DataSet.vrstaPutniNalog);            
        }


        /// <summary>
        /// klik na gumb odustani zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            dgvStatusNaloga.DataSource = null;
            dgvVozila.DataSource = null;
            dgvVrstaPutniNalog.DataSource = null;
            dgvVrstaTroska.DataSource = null;
            this.Close();
        }

        private void vrstaPutniNalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (tabKataloskiPodaci.SelectedIndex == 0)
            {
                this.Validate();
                this.vozilaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.piDB1DataSet);
            }
            if (tabKataloskiPodaci.SelectedIndex == 1)
            {
                this.Validate();
                this.statusNalogaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.piDB1DataSet);
            }
            if (tabKataloskiPodaci.SelectedIndex == 2)
            {
                this.Validate();
                this.vrstaPutniNalogBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.piDB1DataSet);
            }
            if (tabKataloskiPodaci.SelectedIndex == 3)
            {
                this.Validate();
                this.vrstaTrosakBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.piDB1DataSet);
            }

        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            this.vozilaBindingSource.RemoveCurrent();
            this.vozilaTableAdapter.Update(piDB1DataSet.vozila);
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            this.vozilaBindingSource.AddNew();
        }

        private void btnSpremiVozila_Click(object sender, EventArgs e)
        {
            vozilaBindingSource.EndEdit();
            this.vozilaTableAdapter.Update(piDB1DataSet);
            dgvVozila.Refresh();
        }

        private void btnObrisiVrstuNaloga_Click(object sender, EventArgs e)
        {
            this.vrstaPutniNalogBindingSource.RemoveCurrent();
            this.vrstaPutniNalogTableAdapter.Update(piDB1DataSet.vrstaPutniNalog);
        }

        private void btnDodajVrstuNaloga_Click(object sender, EventArgs e)
        {
            this.vrstaPutniNalogBindingSource.AddNew();
        }

        private void btnSpremiVrstuNaloga_Click(object sender, EventArgs e)
        {
            vrstaPutniNalogBindingSource.EndEdit();
            this.vrstaPutniNalogTableAdapter.Update(piDB1DataSet);
            dgvVrstaPutniNalog.Refresh();
        }

        private void btnObrisiVrstuTroska_Click(object sender, EventArgs e)
        {
            this.vrstaTrosakBindingSource.RemoveCurrent();
            this.vrstaTrosakTableAdapter.Update(piDB1DataSet.vrstaTrosak);
        }

        private void btnDodajVrstuTroska_Click(object sender, EventArgs e)
        {
            this.vrstaTrosakBindingSource.AddNew();
        }

        private void btnSpremiVrstuTroska_Click(object sender, EventArgs e)
        {
            vrstaTrosakBindingSource.EndEdit();
            this.vrstaTrosakTableAdapter.Update(piDB1DataSet);
            dgvVrstaTroska.Refresh();
        }

        private void btnObrisiStatusNaloga_Click(object sender, EventArgs e)
        {
            this.statusNalogaBindingSource.RemoveCurrent();
            this.statusNalogaTableAdapter.Update(piDB1DataSet.statusNaloga);
        }

        private void btnDodajStatusNaloga_Click(object sender, EventArgs e)
        {
            this.statusNalogaBindingSource.AddNew();
        }

        private void btnSpremiStatusNaloga_Click(object sender, EventArgs e)
        {
            statusNalogaBindingSource.EndEdit();
            this.statusNalogaTableAdapter.Update(piDB1DataSet);
            dgvStatusNaloga.Refresh();
        }

        

    }
}
