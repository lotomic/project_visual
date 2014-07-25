namespace Uprava.NET
{
    partial class frmPregledNaloga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idnalogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePovratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polazisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akontacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odgovornaOsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnositeljaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nositeljTroskovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet1 = new Uprava.NET.piDB1DataSet();
            this.idstatusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusNalogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvjesceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumLikvidacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdobrenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opravdanZahtjevDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idvrstaNalogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaPutniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likvidiraoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odobrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potpisaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStatusNaloga = new System.Windows.Forms.ComboBox();
            this.statusNalogaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdobri = new System.Windows.Forms.Button();
            this.chkSviNalozi = new System.Windows.Forms.CheckBox();
            this.btnPotpisi = new System.Windows.Forms.Button();
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.statusNalogaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.statusNalogaTableAdapter();
            this.vrstaPutniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter();
            this.nositeljTroskovaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnalogaDataGridViewTextBoxColumn,
            this.datumKreiranjaDataGridViewTextBoxColumn,
            this.svrhaDataGridViewTextBoxColumn,
            this.vrijemePolaskaDataGridViewTextBoxColumn,
            this.vrijemePovratkaDataGridViewTextBoxColumn,
            this.polazisteDataGridViewTextBoxColumn,
            this.odredisteDataGridViewTextBoxColumn,
            this.akontacijaDataGridViewTextBoxColumn,
            this.odgovornaOsobaDataGridViewTextBoxColumn,
            this.idnositeljaDataGridViewTextBoxColumn,
            this.idstatusaDataGridViewTextBoxColumn,
            this.nastavnikDataGridViewTextBoxColumn,
            this.izvjesceDataGridViewTextBoxColumn,
            this.datumLikvidacijeDataGridViewTextBoxColumn,
            this.datumOdobrenjaDataGridViewTextBoxColumn,
            this.opravdanZahtjevDataGridViewCheckBoxColumn,
            this.idvrstaNalogaDataGridViewTextBoxColumn,
            this.likvidiraoDataGridViewTextBoxColumn,
            this.odobrioDataGridViewTextBoxColumn,
            this.potpisaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.putniNalogBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 270);
            this.dataGridView1.TabIndex = 2;
            // 
            // idnalogaDataGridViewTextBoxColumn
            // 
            this.idnalogaDataGridViewTextBoxColumn.DataPropertyName = "id_naloga";
            this.idnalogaDataGridViewTextBoxColumn.HeaderText = "id_naloga";
            this.idnalogaDataGridViewTextBoxColumn.Name = "idnalogaDataGridViewTextBoxColumn";
            this.idnalogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumKreiranjaDataGridViewTextBoxColumn
            // 
            this.datumKreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datumKreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.HeaderText = "datumKreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.Name = "datumKreiranjaDataGridViewTextBoxColumn";
            this.datumKreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svrhaDataGridViewTextBoxColumn
            // 
            this.svrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha";
            this.svrhaDataGridViewTextBoxColumn.HeaderText = "svrha";
            this.svrhaDataGridViewTextBoxColumn.Name = "svrhaDataGridViewTextBoxColumn";
            this.svrhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemePolaskaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.HeaderText = "vrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.Name = "vrijemePolaskaDataGridViewTextBoxColumn";
            this.vrijemePolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePovratkaDataGridViewTextBoxColumn
            // 
            this.vrijemePovratkaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePovratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.HeaderText = "vrijemePovratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.Name = "vrijemePovratkaDataGridViewTextBoxColumn";
            this.vrijemePovratkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polazisteDataGridViewTextBoxColumn
            // 
            this.polazisteDataGridViewTextBoxColumn.DataPropertyName = "polaziste";
            this.polazisteDataGridViewTextBoxColumn.HeaderText = "polaziste";
            this.polazisteDataGridViewTextBoxColumn.Name = "polazisteDataGridViewTextBoxColumn";
            this.polazisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // akontacijaDataGridViewTextBoxColumn
            // 
            this.akontacijaDataGridViewTextBoxColumn.DataPropertyName = "akontacija";
            this.akontacijaDataGridViewTextBoxColumn.HeaderText = "akontacija";
            this.akontacijaDataGridViewTextBoxColumn.Name = "akontacijaDataGridViewTextBoxColumn";
            this.akontacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odgovornaOsobaDataGridViewTextBoxColumn
            // 
            this.odgovornaOsobaDataGridViewTextBoxColumn.DataPropertyName = "odgovornaOsoba";
            this.odgovornaOsobaDataGridViewTextBoxColumn.HeaderText = "odgovornaOsoba";
            this.odgovornaOsobaDataGridViewTextBoxColumn.Name = "odgovornaOsobaDataGridViewTextBoxColumn";
            this.odgovornaOsobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idnositeljaDataGridViewTextBoxColumn
            // 
            this.idnositeljaDataGridViewTextBoxColumn.DataPropertyName = "id_nositelja";
            this.idnositeljaDataGridViewTextBoxColumn.DataSource = this.nositeljTroskovaBindingSource;
            this.idnositeljaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idnositeljaDataGridViewTextBoxColumn.HeaderText = "id_nositelja";
            this.idnositeljaDataGridViewTextBoxColumn.Name = "idnositeljaDataGridViewTextBoxColumn";
            this.idnositeljaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnositeljaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idnositeljaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idnositeljaDataGridViewTextBoxColumn.ValueMember = "id_nositelja";
            // 
            // nositeljTroskovaBindingSource
            // 
            this.nositeljTroskovaBindingSource.DataMember = "nositeljTroskova";
            this.nositeljTroskovaBindingSource.DataSource = this.piDB1DataSet1;
            // 
            // piDB1DataSet1
            // 
            this.piDB1DataSet1.DataSetName = "piDB1DataSet1";
            this.piDB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idstatusaDataGridViewTextBoxColumn
            // 
            this.idstatusaDataGridViewTextBoxColumn.DataPropertyName = "id_statusa";
            this.idstatusaDataGridViewTextBoxColumn.DataSource = this.statusNalogaBindingSource;
            this.idstatusaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idstatusaDataGridViewTextBoxColumn.HeaderText = "id_statusa";
            this.idstatusaDataGridViewTextBoxColumn.Name = "idstatusaDataGridViewTextBoxColumn";
            this.idstatusaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstatusaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstatusaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstatusaDataGridViewTextBoxColumn.ValueMember = "id_statusa";
            // 
            // statusNalogaBindingSource
            // 
            this.statusNalogaBindingSource.DataMember = "statusNaloga";
            this.statusNalogaBindingSource.DataSource = this.piDB1DataSet1;
            // 
            // nastavnikDataGridViewTextBoxColumn
            // 
            this.nastavnikDataGridViewTextBoxColumn.DataPropertyName = "nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.HeaderText = "nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.Name = "nastavnikDataGridViewTextBoxColumn";
            this.nastavnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvjesceDataGridViewTextBoxColumn
            // 
            this.izvjesceDataGridViewTextBoxColumn.DataPropertyName = "izvjesce";
            this.izvjesceDataGridViewTextBoxColumn.HeaderText = "izvjesce";
            this.izvjesceDataGridViewTextBoxColumn.Name = "izvjesceDataGridViewTextBoxColumn";
            this.izvjesceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumLikvidacijeDataGridViewTextBoxColumn
            // 
            this.datumLikvidacijeDataGridViewTextBoxColumn.DataPropertyName = "datumLikvidacije";
            this.datumLikvidacijeDataGridViewTextBoxColumn.HeaderText = "datumLikvidacije";
            this.datumLikvidacijeDataGridViewTextBoxColumn.Name = "datumLikvidacijeDataGridViewTextBoxColumn";
            this.datumLikvidacijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumOdobrenjaDataGridViewTextBoxColumn
            // 
            this.datumOdobrenjaDataGridViewTextBoxColumn.DataPropertyName = "datumOdobrenja";
            this.datumOdobrenjaDataGridViewTextBoxColumn.HeaderText = "datumOdobrenja";
            this.datumOdobrenjaDataGridViewTextBoxColumn.Name = "datumOdobrenjaDataGridViewTextBoxColumn";
            this.datumOdobrenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opravdanZahtjevDataGridViewCheckBoxColumn
            // 
            this.opravdanZahtjevDataGridViewCheckBoxColumn.DataPropertyName = "opravdanZahtjev";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.HeaderText = "opravdanZahtjev";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.Name = "opravdanZahtjevDataGridViewCheckBoxColumn";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idvrstaNalogaDataGridViewTextBoxColumn
            // 
            this.idvrstaNalogaDataGridViewTextBoxColumn.DataPropertyName = "id_vrstaNaloga";
            this.idvrstaNalogaDataGridViewTextBoxColumn.DataSource = this.vrstaPutniNalogBindingSource;
            this.idvrstaNalogaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idvrstaNalogaDataGridViewTextBoxColumn.HeaderText = "id_vrstaNaloga";
            this.idvrstaNalogaDataGridViewTextBoxColumn.Name = "idvrstaNalogaDataGridViewTextBoxColumn";
            this.idvrstaNalogaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvrstaNalogaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idvrstaNalogaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idvrstaNalogaDataGridViewTextBoxColumn.ValueMember = "VrstaPutniNalog_ID";
            // 
            // vrstaPutniNalogBindingSource
            // 
            this.vrstaPutniNalogBindingSource.DataMember = "vrstaPutniNalog";
            this.vrstaPutniNalogBindingSource.DataSource = this.piDB1DataSet1;
            // 
            // likvidiraoDataGridViewTextBoxColumn
            // 
            this.likvidiraoDataGridViewTextBoxColumn.DataPropertyName = "likvidirao";
            this.likvidiraoDataGridViewTextBoxColumn.HeaderText = "likvidirao";
            this.likvidiraoDataGridViewTextBoxColumn.Name = "likvidiraoDataGridViewTextBoxColumn";
            this.likvidiraoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odobrioDataGridViewTextBoxColumn
            // 
            this.odobrioDataGridViewTextBoxColumn.DataPropertyName = "odobrio";
            this.odobrioDataGridViewTextBoxColumn.HeaderText = "odobrio";
            this.odobrioDataGridViewTextBoxColumn.Name = "odobrioDataGridViewTextBoxColumn";
            this.odobrioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potpisaoDataGridViewTextBoxColumn
            // 
            this.potpisaoDataGridViewTextBoxColumn.DataPropertyName = "potpisao";
            this.potpisaoDataGridViewTextBoxColumn.HeaderText = "potpisao";
            this.potpisaoDataGridViewTextBoxColumn.Name = "potpisaoDataGridViewTextBoxColumn";
            this.potpisaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // putniNalogBindingSource
            // 
            this.putniNalogBindingSource.DataMember = "putniNalog";
            this.putniNalogBindingSource.DataSource = this.piDB1DataSet1;
            // 
            // cmbStatusNaloga
            // 
            this.cmbStatusNaloga.DataSource = this.statusNalogaBindingSource1;
            this.cmbStatusNaloga.DisplayMember = "naziv";
            this.cmbStatusNaloga.Enabled = false;
            this.cmbStatusNaloga.FormattingEnabled = true;
            this.cmbStatusNaloga.Location = new System.Drawing.Point(66, 8);
            this.cmbStatusNaloga.Name = "cmbStatusNaloga";
            this.cmbStatusNaloga.Size = new System.Drawing.Size(135, 21);
            this.cmbStatusNaloga.TabIndex = 3;
            this.cmbStatusNaloga.ValueMember = "id_statusa";
            this.cmbStatusNaloga.SelectedIndexChanged += new System.EventHandler(this.cmbStatusNaloga_SelectedIndexChanged);
            // 
            // statusNalogaBindingSource1
            // 
            this.statusNalogaBindingSource1.DataMember = "statusNaloga";
            this.statusNalogaBindingSource1.DataSource = this.piDB1DataSet1;
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(12, 43);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(75, 23);
            this.btnOdobri.TabIndex = 4;
            this.btnOdobri.Text = "Odobri Naloge";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Visible = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // chkSviNalozi
            // 
            this.chkSviNalozi.AutoSize = true;
            this.chkSviNalozi.Location = new System.Drawing.Point(12, 12);
            this.chkSviNalozi.Name = "chkSviNalozi";
            this.chkSviNalozi.Size = new System.Drawing.Size(48, 17);
            this.chkSviNalozi.TabIndex = 5;
            this.chkSviNalozi.Text = "Filter";
            this.chkSviNalozi.UseVisualStyleBackColor = true;
            this.chkSviNalozi.CheckedChanged += new System.EventHandler(this.chkSviNalozi_CheckedChanged);
            // 
            // btnPotpisi
            // 
            this.btnPotpisi.Location = new System.Drawing.Point(12, 43);
            this.btnPotpisi.Name = "btnPotpisi";
            this.btnPotpisi.Size = new System.Drawing.Size(75, 23);
            this.btnPotpisi.TabIndex = 6;
            this.btnPotpisi.Text = "Potpiši nalog";
            this.btnPotpisi.UseVisualStyleBackColor = true;
            this.btnPotpisi.Visible = false;
            this.btnPotpisi.Click += new System.EventHandler(this.btnPotpisi_Click);
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // statusNalogaTableAdapter
            // 
            this.statusNalogaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaPutniNalogTableAdapter
            // 
            this.vrstaPutniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // nositeljTroskovaTableAdapter
            // 
            this.nositeljTroskovaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 349);
            this.Controls.Add(this.btnPotpisi);
            this.Controls.Add(this.chkSviNalozi);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.cmbStatusNaloga);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPregledNaloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled Naloga";
            this.Load += new System.EventHandler(this.frmPregledNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStatusNaloga;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.CheckBox chkSviNalozi;
        private System.Windows.Forms.Button btnPotpisi;
        private piDB1DataSet piDB1DataSet1;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private System.Windows.Forms.BindingSource statusNalogaBindingSource;
        private piDB1DataSetTableAdapters.statusNalogaTableAdapter statusNalogaTableAdapter;
        private System.Windows.Forms.BindingSource vrstaPutniNalogBindingSource;
        private piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter vrstaPutniNalogTableAdapter;
        private System.Windows.Forms.BindingSource statusNalogaBindingSource1;
        private System.Windows.Forms.BindingSource nositeljTroskovaBindingSource;
        private piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter nositeljTroskovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnalogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePovratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akontacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odgovornaOsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idnositeljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstatusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvjesceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumLikvidacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdobrenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opravdanZahtjevDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idvrstaNalogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likvidiraoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odobrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potpisaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozilaDataGridViewTextBoxColumn;
    }
}