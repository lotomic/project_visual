namespace Uprava.NET
{
    partial class frmUnosNaloga
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnUnosNaloga = new System.Windows.Forms.Button();
            this.cmbZahtjev = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNositeljTrosk = new System.Windows.Forms.ComboBox();
            this.dgwZahtjevKodUnosaNaloga = new System.Windows.Forms.DataGridView();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.piDB1DataSet_tim17 = new Uprava.NET.piDB1DataSet_tim17();
            this.nositeljTroskovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nositeljTroskovaTableAdapter = new Uprava.NET.piDB1DataSet_tim17TableAdapters.nositeljTroskovaTableAdapter();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozilaTableAdapter = new Uprava.NET.piDB1DataSet_tim17TableAdapters.vozilaTableAdapter();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSet_tim17TableAdapters.putniNalogTableAdapter();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSet_tim17TableAdapters.QueriesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akontacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZahtjevKodUnosaNaloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet_tim17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nositelj troškova";
            // 
            // btnUnosNaloga
            // 
            this.btnUnosNaloga.Location = new System.Drawing.Point(244, 61);
            this.btnUnosNaloga.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnosNaloga.Name = "btnUnosNaloga";
            this.btnUnosNaloga.Size = new System.Drawing.Size(80, 30);
            this.btnUnosNaloga.TabIndex = 4;
            this.btnUnosNaloga.Text = "Unos naloga";
            this.btnUnosNaloga.UseVisualStyleBackColor = true;
            this.btnUnosNaloga.Click += new System.EventHandler(this.btnUnosNaloga_Click);
            // 
            // cmbZahtjev
            // 
            this.cmbZahtjev.DataSource = this.putniNalogBindingSource;
            this.cmbZahtjev.DisplayMember = "id_naloga";
            this.cmbZahtjev.FormattingEnabled = true;
            this.cmbZahtjev.Location = new System.Drawing.Point(12, 67);
            this.cmbZahtjev.Name = "cmbZahtjev";
            this.cmbZahtjev.Size = new System.Drawing.Size(103, 21);
            this.cmbZahtjev.TabIndex = 5;
            this.cmbZahtjev.ValueMember = "id_naloga";
            this.cmbZahtjev.SelectedIndexChanged += new System.EventHandler(this.cmbZahtjev_SelectedIndexChanged);
            this.cmbZahtjev.SelectedValueChanged += new System.EventHandler(this.cmbZahtjev_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zahtjev";
            // 
            // cmbNositeljTrosk
            // 
            this.cmbNositeljTrosk.DataSource = this.nositeljTroskovaBindingSource;
            this.cmbNositeljTrosk.DisplayMember = "naziv";
            this.cmbNositeljTrosk.FormattingEnabled = true;
            this.cmbNositeljTrosk.Location = new System.Drawing.Point(14, 24);
            this.cmbNositeljTrosk.Name = "cmbNositeljTrosk";
            this.cmbNositeljTrosk.Size = new System.Drawing.Size(310, 21);
            this.cmbNositeljTrosk.TabIndex = 7;
            this.cmbNositeljTrosk.ValueMember = "id_nositelja";
            // 
            // dgwZahtjevKodUnosaNaloga
            // 
            this.dgwZahtjevKodUnosaNaloga.AllowUserToAddRows = false;
            this.dgwZahtjevKodUnosaNaloga.AllowUserToDeleteRows = false;
            this.dgwZahtjevKodUnosaNaloga.AutoGenerateColumns = false;
            this.dgwZahtjevKodUnosaNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZahtjevKodUnosaNaloga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.akontacijaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgwZahtjevKodUnosaNaloga.DataSource = this.putniNalogBindingSource;
            this.dgwZahtjevKodUnosaNaloga.Location = new System.Drawing.Point(15, 115);
            this.dgwZahtjevKodUnosaNaloga.Name = "dgwZahtjevKodUnosaNaloga";
            this.dgwZahtjevKodUnosaNaloga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwZahtjevKodUnosaNaloga.Size = new System.Drawing.Size(546, 150);
            this.dgwZahtjevKodUnosaNaloga.TabIndex = 8;
            this.dgwZahtjevKodUnosaNaloga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwZahtjevKodUnosaNaloga_CellContentClick);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(134, 51);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(35, 13);
            this.lblVozilo.TabIndex = 9;
            this.lblVozilo.Text = "Vozilo";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.DataSource = this.vozilaBindingSource;
            this.cmbVozilo.DisplayMember = "marka";
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(137, 67);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(80, 21);
            this.cmbVozilo.TabIndex = 10;
            this.cmbVozilo.ValueMember = "id_vozila";
            // 
            // piDB1DataSet_tim17
            // 
            this.piDB1DataSet_tim17.DataSetName = "piDB1DataSet_tim17";
            this.piDB1DataSet_tim17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nositeljTroskovaBindingSource
            // 
            this.nositeljTroskovaBindingSource.DataMember = "nositeljTroskova";
            this.nositeljTroskovaBindingSource.DataSource = this.piDB1DataSet_tim17;
            // 
            // nositeljTroskovaTableAdapter
            // 
            this.nositeljTroskovaTableAdapter.ClearBeforeFill = true;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataMember = "vozila";
            this.vozilaBindingSource.DataSource = this.piDB1DataSet_tim17;
            // 
            // vozilaTableAdapter
            // 
            this.vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // putniNalogBindingSource
            // 
            this.putniNalogBindingSource.DataMember = "putniNalog";
            this.putniNalogBindingSource.DataSource = this.piDB1DataSet_tim17;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_naloga";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_naloga";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datumKreiranja";
            this.dataGridViewTextBoxColumn2.HeaderText = "datumKreiranja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "svrha";
            this.dataGridViewTextBoxColumn3.HeaderText = "svrha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 58;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vrijemePolaska";
            this.dataGridViewTextBoxColumn4.HeaderText = "vrijemePolaska";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 103;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vrijemePovratka";
            this.dataGridViewTextBoxColumn5.HeaderText = "vrijemePovratka";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "polaziste";
            this.dataGridViewTextBoxColumn6.HeaderText = "polaziste";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 73;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "odrediste";
            this.dataGridViewTextBoxColumn7.HeaderText = "odrediste";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // akontacijaDataGridViewTextBoxColumn
            // 
            this.akontacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.akontacijaDataGridViewTextBoxColumn.DataPropertyName = "akontacija";
            this.akontacijaDataGridViewTextBoxColumn.HeaderText = "akontacija";
            this.akontacijaDataGridViewTextBoxColumn.Name = "akontacijaDataGridViewTextBoxColumn";
            this.akontacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.akontacijaDataGridViewTextBoxColumn.Width = 81;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_statusa";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_statusa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nastavnik";
            this.dataGridViewTextBoxColumn9.HeaderText = "nastavnik";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 78;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_vrstaNaloga";
            this.dataGridViewTextBoxColumn10.HeaderText = "id_vrstaNaloga";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 103;
            // 
            // frmUnosNaloga
            // 
            this.AcceptButton = this.btnUnosNaloga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 348);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.dgwZahtjevKodUnosaNaloga);
            this.Controls.Add(this.cmbNositeljTrosk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZahtjev);
            this.Controls.Add(this.btnUnosNaloga);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUnosNaloga";
            this.Text = "Unos naloga";
            this.Load += new System.EventHandler(this.frmUnosNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZahtjevKodUnosaNaloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet_tim17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUnosNaloga;
        private System.Windows.Forms.ComboBox cmbZahtjev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNositeljTrosk;
        private System.Windows.Forms.DataGridView dgwZahtjevKodUnosaNaloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnalogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePovratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvrstaNalogaDataGridViewTextBoxColumn;
        private piDB1DataSet_tim17 piDB1DataSet_tim17;
        private System.Windows.Forms.BindingSource nositeljTroskovaBindingSource;
        private piDB1DataSet_tim17TableAdapters.nositeljTroskovaTableAdapter nositeljTroskovaTableAdapter;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private piDB1DataSet_tim17TableAdapters.vozilaTableAdapter vozilaTableAdapter;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSet_tim17TableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private piDB1DataSet_tim17TableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn akontacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}