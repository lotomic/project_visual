namespace Uprava.NET
{
    partial class frmArhivaPutniNalozi
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvArhivaPutniNalozi = new System.Windows.Forms.DataGridView();
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
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idstatusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusNalogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvjesceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumLikvidacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdobrenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opravdanZahtjevDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_vrstaNaloga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vrstaPutniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.nositeljTroskovaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter();
            this.vozilaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vozilaTableAdapter();
            this.statusNalogaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.statusNalogaTableAdapter();
            this.vrstaPutniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhivaPutniNalozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(620, 388);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Izlaz";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvArhivaPutniNalozi
            // 
            this.dgvArhivaPutniNalozi.AllowUserToAddRows = false;
            this.dgvArhivaPutniNalozi.AllowUserToDeleteRows = false;
            this.dgvArhivaPutniNalozi.AutoGenerateColumns = false;
            this.dgvArhivaPutniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArhivaPutniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.id_vrstaNaloga});
            this.dgvArhivaPutniNalozi.DataSource = this.putniNalogBindingSource;
            this.dgvArhivaPutniNalozi.Location = new System.Drawing.Point(12, 12);
            this.dgvArhivaPutniNalozi.Name = "dgvArhivaPutniNalozi";
            this.dgvArhivaPutniNalozi.ReadOnly = true;
            this.dgvArhivaPutniNalozi.Size = new System.Drawing.Size(705, 349);
            this.dgvArhivaPutniNalozi.TabIndex = 4;
            // 
            // idnalogaDataGridViewTextBoxColumn
            // 
            this.idnalogaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idnalogaDataGridViewTextBoxColumn.DataPropertyName = "id_naloga";
            this.idnalogaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idnalogaDataGridViewTextBoxColumn.Name = "idnalogaDataGridViewTextBoxColumn";
            this.idnalogaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnalogaDataGridViewTextBoxColumn.Width = 43;
            // 
            // datumKreiranjaDataGridViewTextBoxColumn
            // 
            this.datumKreiranjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumKreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datumKreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.Name = "datumKreiranjaDataGridViewTextBoxColumn";
            this.datumKreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumKreiranjaDataGridViewTextBoxColumn.Width = 97;
            // 
            // svrhaDataGridViewTextBoxColumn
            // 
            this.svrhaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.svrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha";
            this.svrhaDataGridViewTextBoxColumn.HeaderText = "Svrha";
            this.svrhaDataGridViewTextBoxColumn.Name = "svrhaDataGridViewTextBoxColumn";
            this.svrhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.svrhaDataGridViewTextBoxColumn.Width = 60;
            // 
            // vrijemePolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemePolaskaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vrijemePolaskaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.HeaderText = "Vrijeme polaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.Name = "vrijemePolaskaDataGridViewTextBoxColumn";
            this.vrijemePolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemePolaskaDataGridViewTextBoxColumn.Width = 97;
            // 
            // vrijemePovratkaDataGridViewTextBoxColumn
            // 
            this.vrijemePovratkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vrijemePovratkaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePovratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.HeaderText = "Vrijeme povratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.Name = "vrijemePovratkaDataGridViewTextBoxColumn";
            this.vrijemePovratkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemePovratkaDataGridViewTextBoxColumn.Width = 102;
            // 
            // polazisteDataGridViewTextBoxColumn
            // 
            this.polazisteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.polazisteDataGridViewTextBoxColumn.DataPropertyName = "polaziste";
            this.polazisteDataGridViewTextBoxColumn.HeaderText = "Polazište";
            this.polazisteDataGridViewTextBoxColumn.Name = "polazisteDataGridViewTextBoxColumn";
            this.polazisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.polazisteDataGridViewTextBoxColumn.Width = 74;
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odredište";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.odredisteDataGridViewTextBoxColumn.Width = 77;
            // 
            // akontacijaDataGridViewTextBoxColumn
            // 
            this.akontacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.akontacijaDataGridViewTextBoxColumn.DataPropertyName = "akontacija";
            this.akontacijaDataGridViewTextBoxColumn.HeaderText = "Akontacija";
            this.akontacijaDataGridViewTextBoxColumn.Name = "akontacijaDataGridViewTextBoxColumn";
            this.akontacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.akontacijaDataGridViewTextBoxColumn.Width = 82;
            // 
            // odgovornaOsobaDataGridViewTextBoxColumn
            // 
            this.odgovornaOsobaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.odgovornaOsobaDataGridViewTextBoxColumn.DataPropertyName = "odgovornaOsoba";
            this.odgovornaOsobaDataGridViewTextBoxColumn.HeaderText = "Odgovorna osoba";
            this.odgovornaOsobaDataGridViewTextBoxColumn.Name = "odgovornaOsobaDataGridViewTextBoxColumn";
            this.odgovornaOsobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.odgovornaOsobaDataGridViewTextBoxColumn.Width = 107;
            // 
            // idnositeljaDataGridViewTextBoxColumn
            // 
            this.idnositeljaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idnositeljaDataGridViewTextBoxColumn.DataPropertyName = "id_nositelja";
            this.idnositeljaDataGridViewTextBoxColumn.DataSource = this.nositeljTroskovaBindingSource;
            this.idnositeljaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idnositeljaDataGridViewTextBoxColumn.HeaderText = "Nositelj troškova";
            this.idnositeljaDataGridViewTextBoxColumn.Name = "idnositeljaDataGridViewTextBoxColumn";
            this.idnositeljaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnositeljaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idnositeljaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idnositeljaDataGridViewTextBoxColumn.ValueMember = "id_nositelja";
            this.idnositeljaDataGridViewTextBoxColumn.Width = 101;
            // 
            // nositeljTroskovaBindingSource
            // 
            this.nositeljTroskovaBindingSource.DataMember = "nositeljTroskova";
            this.nositeljTroskovaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataMember = "vozila";
            this.vozilaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // idstatusaDataGridViewTextBoxColumn
            // 
            this.idstatusaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idstatusaDataGridViewTextBoxColumn.DataPropertyName = "id_statusa";
            this.idstatusaDataGridViewTextBoxColumn.DataSource = this.statusNalogaBindingSource;
            this.idstatusaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idstatusaDataGridViewTextBoxColumn.HeaderText = "Status naloga";
            this.idstatusaDataGridViewTextBoxColumn.Name = "idstatusaDataGridViewTextBoxColumn";
            this.idstatusaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstatusaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstatusaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstatusaDataGridViewTextBoxColumn.ValueMember = "id_statusa";
            this.idstatusaDataGridViewTextBoxColumn.Width = 89;
            // 
            // statusNalogaBindingSource
            // 
            this.statusNalogaBindingSource.DataMember = "statusNaloga";
            this.statusNalogaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // nastavnikDataGridViewTextBoxColumn
            // 
            this.nastavnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nastavnikDataGridViewTextBoxColumn.DataPropertyName = "nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.HeaderText = "Nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.Name = "nastavnikDataGridViewTextBoxColumn";
            this.nastavnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.nastavnikDataGridViewTextBoxColumn.Width = 80;
            // 
            // izvjesceDataGridViewTextBoxColumn
            // 
            this.izvjesceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.izvjesceDataGridViewTextBoxColumn.DataPropertyName = "izvjesce";
            this.izvjesceDataGridViewTextBoxColumn.HeaderText = "Izvješće";
            this.izvjesceDataGridViewTextBoxColumn.Name = "izvjesceDataGridViewTextBoxColumn";
            this.izvjesceDataGridViewTextBoxColumn.ReadOnly = true;
            this.izvjesceDataGridViewTextBoxColumn.Width = 71;
            // 
            // datumLikvidacijeDataGridViewTextBoxColumn
            // 
            this.datumLikvidacijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumLikvidacijeDataGridViewTextBoxColumn.DataPropertyName = "datumLikvidacije";
            this.datumLikvidacijeDataGridViewTextBoxColumn.HeaderText = "Datum likvidacije";
            this.datumLikvidacijeDataGridViewTextBoxColumn.Name = "datumLikvidacijeDataGridViewTextBoxColumn";
            this.datumLikvidacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumLikvidacijeDataGridViewTextBoxColumn.Width = 103;
            // 
            // datumOdobrenjaDataGridViewTextBoxColumn
            // 
            this.datumOdobrenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumOdobrenjaDataGridViewTextBoxColumn.DataPropertyName = "datumOdobrenja";
            this.datumOdobrenjaDataGridViewTextBoxColumn.HeaderText = "Datum odobrenja";
            this.datumOdobrenjaDataGridViewTextBoxColumn.Name = "datumOdobrenjaDataGridViewTextBoxColumn";
            this.datumOdobrenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumOdobrenjaDataGridViewTextBoxColumn.Width = 104;
            // 
            // opravdanZahtjevDataGridViewCheckBoxColumn
            // 
            this.opravdanZahtjevDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opravdanZahtjevDataGridViewCheckBoxColumn.DataPropertyName = "opravdanZahtjev";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.HeaderText = "Opravdan zahtjev";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.Name = "opravdanZahtjevDataGridViewCheckBoxColumn";
            this.opravdanZahtjevDataGridViewCheckBoxColumn.ReadOnly = true;
            this.opravdanZahtjevDataGridViewCheckBoxColumn.Width = 87;
            // 
            // id_vrstaNaloga
            // 
            this.id_vrstaNaloga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_vrstaNaloga.DataPropertyName = "id_vrstaNaloga";
            this.id_vrstaNaloga.DataSource = this.vrstaPutniNalogBindingSource;
            this.id_vrstaNaloga.DisplayMember = "Naziv";
            this.id_vrstaNaloga.HeaderText = "Vrsta naloga";
            this.id_vrstaNaloga.Name = "id_vrstaNaloga";
            this.id_vrstaNaloga.ReadOnly = true;
            this.id_vrstaNaloga.ValueMember = "VrstaPutniNalog_ID";
            // 
            // vrstaPutniNalogBindingSource
            // 
            this.vrstaPutniNalogBindingSource.DataMember = "vrstaPutniNalog";
            this.vrstaPutniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // putniNalogBindingSource
            // 
            this.putniNalogBindingSource.DataMember = "putniNalog";
            this.putniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // nositeljTroskovaTableAdapter
            // 
            this.nositeljTroskovaTableAdapter.ClearBeforeFill = true;
            // 
            // vozilaTableAdapter
            // 
            this.vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // statusNalogaTableAdapter
            // 
            this.statusNalogaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaPutniNalogTableAdapter
            // 
            this.vrstaPutniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // frmArhivaPutniNalozi
            // 
            this.AcceptButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 432);
            this.Controls.Add(this.dgvArhivaPutniNalozi);
            this.Controls.Add(this.btnOdustani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmArhivaPutniNalozi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhivirani putni nalozi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArhivaPutniNalozi_FormClosing);
            this.Load += new System.EventHandler(this.frmArhivaPutniNalozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhivaPutniNalozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetnoBrojiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavrsnoBrojiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvArhivaPutniNalozi;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private System.Windows.Forms.BindingSource nositeljTroskovaBindingSource;
        private piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter nositeljTroskovaTableAdapter;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private piDB1DataSetTableAdapters.vozilaTableAdapter vozilaTableAdapter;
        private System.Windows.Forms.BindingSource statusNalogaBindingSource;
        private piDB1DataSetTableAdapters.statusNalogaTableAdapter statusNalogaTableAdapter;
        private System.Windows.Forms.BindingSource vrstaPutniNalogBindingSource;
        private piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter vrstaPutniNalogTableAdapter;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn idvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstatusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvjesceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumLikvidacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdobrenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opravdanZahtjevDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_vrstaNaloga;
    }
}