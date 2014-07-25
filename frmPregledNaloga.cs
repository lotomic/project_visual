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
    public partial class frmPregledNaloga : Form
    {
        
        public frmPregledNaloga()
        {
            InitializeComponent();
           
          
        }
       
        private void frmPregledNaloga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet1.nositeljTroskova' table. You can move, or remove it, as needed.
            this.nositeljTroskovaTableAdapter.Fill(this.piDB1DataSet1.nositeljTroskova);
            // TODO: This line of code loads data into the 'piDB1DataSet1.vrstaPutniNalog' table. You can move, or remove it, as needed.
            this.vrstaPutniNalogTableAdapter.Fill(this.piDB1DataSet1.vrstaPutniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet1.statusNaloga' table. You can move, or remove it, as needed.
            this.statusNalogaTableAdapter.Fill(this.piDB1DataSet1.statusNaloga);
            // TODO: This line of code loads data into the 'piDB1DataSet1.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet1.putniNalog);

            //prikazi gumb za odobrenje naloga ako je korisnik dekan
            if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Approve))
            {
                btnOdobri.Visible = true;
                btnOdobri.Enabled = true;
            }
            else if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Sign))
            {
                btnPotpisi.Visible = true;
                btnPotpisi.Enabled = true;
            }

            ispuniTablicuNaloga();

           
        }

        /// <summary>
        /// punjenje tablice po odabranoj vrijednosti iz cmb statusi naloga
        /// </summary>
        private void ispuniNalogeStatus(){
            if (cmbStatusNaloga.SelectedValue == null && cmbStatusNaloga.SelectedIndex==-1)
            {
                ispuniTablicuNaloga();
            }
            else
            {
                this.putniNalogTableAdapter.FillByStatus(this.piDB1DataSet1.putniNalog, (int)cmbStatusNaloga.SelectedValue);
                
                if ((int)cmbStatusNaloga.SelectedValue==1)
                {
                    btnOdobri.Enabled = true;
                    btnPotpisi.Enabled = false;
                   
                }
                else if ((int)cmbStatusNaloga.SelectedValue == 4)
                {
                    btnPotpisi.Enabled = true;
                    btnOdobri.Enabled = false;
                }
                else
                {
                    btnOdobri.Enabled = false;
                    btnPotpisi.Enabled = false;
                }
            }
        }

        //ispuni tablicu naloga prema trenutnom korisniku
        private void ispuniTablicuNaloga(){
            if (frmMain.loggedUser!=null)
            {
                
            
            //ako je dekan
            if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Approve))
            {
                this.putniNalogTableAdapter.puniPoDekanu(this.piDB1DataSet1.putniNalog);

            }
                //ako je prodekan
            else if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Sign))
            {
                this.putniNalogTableAdapter.puniPoProdekanu(this.piDB1DataSet1.putniNalog);
               
            }
            }
        }

        private void cmbStatusNaloga_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            int idNaloga=0;
            //podaci iz oznacenog reda
            DataGridViewRow row;
            DateTime date = DateTime.Now;
             //ako je oznacen red 
            if (dataGridView1.SelectedRows.Count != 0)
            {
                row = this.dataGridView1.SelectedRows[0];
                idNaloga = (int)row.Cells[0].Value;
                if (MessageBox.Show(
                "Jeste li sigurni da zelite predati odobriti nalog broj: " + row.Cells[0].Value.ToString() + "?", "Odobravanje naloga",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                {
                    //ako korisnik odustane vrati ga na prethodni ekran
                    return;
                }
                else //ako nastavi s izmjenom prava
                {
                    this.putniNalogTableAdapter.odobriNalog(2, date.ToString(), frmMain.loggedUser.UserName.ToString(), idNaloga, idNaloga);
                    this.putniNalogTableAdapter.FillByStatus(piDB1DataSet1.putniNalog, 1);
                }
            }
            
        }

        private void chkSviNalozi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSviNalozi.Checked)
            {
                cmbStatusNaloga.Enabled = true;
                btnOdobri.Enabled = false;
                btnPotpisi.Enabled = false;
                ispuniNalogeStatus();
            }
            else
            {
                cmbStatusNaloga.Enabled = false;
                ispuniTablicuNaloga();
                if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Approve))
                {
                    btnOdobri.Enabled = true;

                }
                //ako je prodekan
                else if (frmMain.loggedUser.isAbleTo(foi.pi.eActions.Sign))
                {
                    btnPotpisi.Enabled = true;
                }
            }


        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            int idNaloga = 0;
            //podaci iz oznacenog reda
            DataGridViewRow row;
            DateTime date = DateTime.Now;
            //ako je oznacen red 
            if (dataGridView1.SelectedRows.Count != 0)
            {
                row = this.dataGridView1.SelectedRows[0];
                idNaloga = (int)row.Cells[0].Value;
                if (MessageBox.Show(
                "Jeste li sigurni da želite potpisati nalog broj: " + row.Cells[0].Value.ToString() + "?", "Potpisivanje naloga",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                {
                    //ako korisnik odustane vrati ga na prethodni ekran
                    return;
                }
                else //ako nastavi s izmjenom prava
                {
                    this.putniNalogTableAdapter.potpisiNalog(5, date.ToString(), frmMain.loggedUser.UserName, idNaloga, idNaloga);
                    this.putniNalogTableAdapter.FillByStatus(piDB1DataSet1.putniNalog, 4);
                }
            }
        }

        private void cmbStatusNaloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ispuniNalogeStatus();
        }

    }
}
