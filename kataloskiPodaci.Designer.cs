namespace Uprava.NET
{
    partial class kataloskiPodaci
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
            this.tabKataloskiPodaci = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVrstaPutniNalog = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvStatusNaloga = new System.Windows.Forms.DataGridView();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.dgvVrstaTroska = new System.Windows.Forms.DataGridView();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnSpremiVozila = new System.Windows.Forms.Button();
            this.btnSpremiVrstuNaloga = new System.Windows.Forms.Button();
            this.btnDodajVrstuNaloga = new System.Windows.Forms.Button();
            this.btnObrisiVrstuNaloga = new System.Windows.Forms.Button();
            this.btnSpremiVrstuTroska = new System.Windows.Forms.Button();
            this.btnDodajVrstuTroska = new System.Windows.Forms.Button();
            this.btnObrisiVrstuTroska = new System.Windows.Forms.Button();
            this.btnSpremiStatusNaloga = new System.Windows.Forms.Button();
            this.btnDodajStatusNaloga = new System.Windows.Forms.Button();
            this.btnObrisiStatusNaloga = new System.Windows.Forms.Button();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.statusNalogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaPutniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaTrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaPutniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter();
            this.tableAdapterManager = new Uprava.NET.piDB1DataSetTableAdapters.TableAdapterManager();
            this.statusNalogaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.statusNalogaTableAdapter();
            this.vozilaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vozilaTableAdapter();
            this.vrstaTrosakTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaTrosakTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKataloskiPodaci.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaPutniNalog)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusNaloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaTroska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKataloskiPodaci
            // 
            this.tabKataloskiPodaci.Controls.Add(this.tabPage1);
            this.tabKataloskiPodaci.Controls.Add(this.tabPage2);
            this.tabKataloskiPodaci.Controls.Add(this.tabPage3);
            this.tabKataloskiPodaci.Controls.Add(this.tabPage4);
            this.tabKataloskiPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabKataloskiPodaci.Location = new System.Drawing.Point(12, 12);
            this.tabKataloskiPodaci.Name = "tabKataloskiPodaci";
            this.tabKataloskiPodaci.SelectedIndex = 0;
            this.tabKataloskiPodaci.Size = new System.Drawing.Size(459, 280);
            this.tabKataloskiPodaci.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnSpremiVozila);
            this.tabPage1.Controls.Add(this.btnDodajVozilo);
            this.tabPage1.Controls.Add(this.btnObrisiVozilo);
            this.tabPage1.Controls.Add(this.dgvVozila);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automobili";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnSpremiStatusNaloga);
            this.tabPage2.Controls.Add(this.btnDodajStatusNaloga);
            this.tabPage2.Controls.Add(this.btnObrisiStatusNaloga);
            this.tabPage2.Controls.Add(this.dgvStatusNaloga);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status naloga";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btnSpremiVrstuNaloga);
            this.tabPage3.Controls.Add(this.btnDodajVrstuNaloga);
            this.tabPage3.Controls.Add(this.btnObrisiVrstuNaloga);
            this.tabPage3.Controls.Add(this.dgvVrstaPutniNalog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(451, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vrsta putnog naloga";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVrstaPutniNalog
            // 
            this.dgvVrstaPutniNalog.AutoGenerateColumns = false;
            this.dgvVrstaPutniNalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaPutniNalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvVrstaPutniNalog.DataSource = this.vrstaPutniNalogBindingSource;
            this.dgvVrstaPutniNalog.Location = new System.Drawing.Point(0, 0);
            this.dgvVrstaPutniNalog.Name = "dgvVrstaPutniNalog";
            this.dgvVrstaPutniNalog.Size = new System.Drawing.Size(451, 203);
            this.dgvVrstaPutniNalog.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.btnSpremiVrstuTroska);
            this.tabPage4.Controls.Add(this.btnDodajVrstuTroska);
            this.tabPage4.Controls.Add(this.btnObrisiVrstuTroska);
            this.tabPage4.Controls.Add(this.dgvVrstaTroska);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(451, 254);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vrsta troškova";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOdustani.Location = new System.Drawing.Point(396, 302);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvStatusNaloga
            // 
            this.dgvStatusNaloga.AutoGenerateColumns = false;
            this.dgvStatusNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusNaloga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvStatusNaloga.DataSource = this.statusNalogaBindingSource;
            this.dgvStatusNaloga.Location = new System.Drawing.Point(0, 0);
            this.dgvStatusNaloga.Name = "dgvStatusNaloga";
            this.dgvStatusNaloga.Size = new System.Drawing.Size(451, 203);
            this.dgvStatusNaloga.TabIndex = 0;
            // 
            // dgvVozila
            // 
            this.dgvVozila.AutoGenerateColumns = false;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vozila,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.dgvVozila.DataSource = this.vozilaBindingSource;
            this.dgvVozila.Location = new System.Drawing.Point(0, 0);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.Size = new System.Drawing.Size(451, 203);
            this.dgvVozila.TabIndex = 0;
            // 
            // dgvVrstaTroska
            // 
            this.dgvVrstaTroska.AutoGenerateColumns = false;
            this.dgvVrstaTroska.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaTroska.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvVrstaTroska.DataSource = this.vrstaTrosakBindingSource;
            this.dgvVrstaTroska.Location = new System.Drawing.Point(0, 0);
            this.dgvVrstaTroska.Name = "dgvVrstaTroska";
            this.dgvVrstaTroska.Size = new System.Drawing.Size(451, 203);
            this.dgvVrstaTroska.TabIndex = 0;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(189, 225);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVozilo.TabIndex = 1;
            this.btnObrisiVozilo.Text = "Obriši";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(270, 225);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVozilo.TabIndex = 2;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnSpremiVozila
            // 
            this.btnSpremiVozila.Location = new System.Drawing.Point(351, 225);
            this.btnSpremiVozila.Name = "btnSpremiVozila";
            this.btnSpremiVozila.Size = new System.Drawing.Size(94, 23);
            this.btnSpremiVozila.TabIndex = 3;
            this.btnSpremiVozila.Text = "Spremi promjene";
            this.btnSpremiVozila.UseVisualStyleBackColor = true;
            this.btnSpremiVozila.Click += new System.EventHandler(this.btnSpremiVozila_Click);
            // 
            // btnSpremiVrstuNaloga
            // 
            this.btnSpremiVrstuNaloga.Location = new System.Drawing.Point(351, 225);
            this.btnSpremiVrstuNaloga.Name = "btnSpremiVrstuNaloga";
            this.btnSpremiVrstuNaloga.Size = new System.Drawing.Size(94, 23);
            this.btnSpremiVrstuNaloga.TabIndex = 6;
            this.btnSpremiVrstuNaloga.Text = "Spremi promjene";
            this.btnSpremiVrstuNaloga.UseVisualStyleBackColor = true;
            this.btnSpremiVrstuNaloga.Click += new System.EventHandler(this.btnSpremiVrstuNaloga_Click);
            // 
            // btnDodajVrstuNaloga
            // 
            this.btnDodajVrstuNaloga.Location = new System.Drawing.Point(232, 225);
            this.btnDodajVrstuNaloga.Name = "btnDodajVrstuNaloga";
            this.btnDodajVrstuNaloga.Size = new System.Drawing.Size(113, 23);
            this.btnDodajVrstuNaloga.TabIndex = 5;
            this.btnDodajVrstuNaloga.Text = "Dodaj vrstu naloga";
            this.btnDodajVrstuNaloga.UseVisualStyleBackColor = true;
            this.btnDodajVrstuNaloga.Click += new System.EventHandler(this.btnDodajVrstuNaloga_Click);
            // 
            // btnObrisiVrstuNaloga
            // 
            this.btnObrisiVrstuNaloga.Location = new System.Drawing.Point(151, 225);
            this.btnObrisiVrstuNaloga.Name = "btnObrisiVrstuNaloga";
            this.btnObrisiVrstuNaloga.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVrstuNaloga.TabIndex = 4;
            this.btnObrisiVrstuNaloga.Text = "Obriši";
            this.btnObrisiVrstuNaloga.UseVisualStyleBackColor = true;
            this.btnObrisiVrstuNaloga.Click += new System.EventHandler(this.btnObrisiVrstuNaloga_Click);
            // 
            // btnSpremiVrstuTroska
            // 
            this.btnSpremiVrstuTroska.Location = new System.Drawing.Point(351, 225);
            this.btnSpremiVrstuTroska.Name = "btnSpremiVrstuTroska";
            this.btnSpremiVrstuTroska.Size = new System.Drawing.Size(94, 23);
            this.btnSpremiVrstuTroska.TabIndex = 9;
            this.btnSpremiVrstuTroska.Text = "Spremi promjene";
            this.btnSpremiVrstuTroska.UseVisualStyleBackColor = true;
            this.btnSpremiVrstuTroska.Click += new System.EventHandler(this.btnSpremiVrstuTroska_Click);
            // 
            // btnDodajVrstuTroska
            // 
            this.btnDodajVrstuTroska.Location = new System.Drawing.Point(232, 225);
            this.btnDodajVrstuTroska.Name = "btnDodajVrstuTroska";
            this.btnDodajVrstuTroska.Size = new System.Drawing.Size(113, 23);
            this.btnDodajVrstuTroska.TabIndex = 8;
            this.btnDodajVrstuTroska.Text = "Dodaj vrstu troška";
            this.btnDodajVrstuTroska.UseVisualStyleBackColor = true;
            this.btnDodajVrstuTroska.Click += new System.EventHandler(this.btnDodajVrstuTroska_Click);
            // 
            // btnObrisiVrstuTroska
            // 
            this.btnObrisiVrstuTroska.Location = new System.Drawing.Point(151, 225);
            this.btnObrisiVrstuTroska.Name = "btnObrisiVrstuTroska";
            this.btnObrisiVrstuTroska.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVrstuTroska.TabIndex = 7;
            this.btnObrisiVrstuTroska.Text = "Obriši";
            this.btnObrisiVrstuTroska.UseVisualStyleBackColor = true;
            this.btnObrisiVrstuTroska.Click += new System.EventHandler(this.btnObrisiVrstuTroska_Click);
            // 
            // btnSpremiStatusNaloga
            // 
            this.btnSpremiStatusNaloga.Location = new System.Drawing.Point(351, 225);
            this.btnSpremiStatusNaloga.Name = "btnSpremiStatusNaloga";
            this.btnSpremiStatusNaloga.Size = new System.Drawing.Size(94, 23);
            this.btnSpremiStatusNaloga.TabIndex = 9;
            this.btnSpremiStatusNaloga.Text = "Spremi promjene";
            this.btnSpremiStatusNaloga.UseVisualStyleBackColor = true;
            this.btnSpremiStatusNaloga.Click += new System.EventHandler(this.btnSpremiStatusNaloga_Click);
            // 
            // btnDodajStatusNaloga
            // 
            this.btnDodajStatusNaloga.Location = new System.Drawing.Point(232, 225);
            this.btnDodajStatusNaloga.Name = "btnDodajStatusNaloga";
            this.btnDodajStatusNaloga.Size = new System.Drawing.Size(113, 23);
            this.btnDodajStatusNaloga.TabIndex = 8;
            this.btnDodajStatusNaloga.Text = "Dodaj status naloga";
            this.btnDodajStatusNaloga.UseVisualStyleBackColor = true;
            this.btnDodajStatusNaloga.Click += new System.EventHandler(this.btnDodajStatusNaloga_Click);
            // 
            // btnObrisiStatusNaloga
            // 
            this.btnObrisiStatusNaloga.Location = new System.Drawing.Point(151, 225);
            this.btnObrisiStatusNaloga.Name = "btnObrisiStatusNaloga";
            this.btnObrisiStatusNaloga.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStatusNaloga.TabIndex = 7;
            this.btnObrisiStatusNaloga.Text = "Obriši";
            this.btnObrisiStatusNaloga.UseVisualStyleBackColor = true;
            this.btnObrisiStatusNaloga.Click += new System.EventHandler(this.btnObrisiStatusNaloga_Click);
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataMember = "vozila";
            this.vozilaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusNalogaBindingSource
            // 
            this.statusNalogaBindingSource.DataMember = "statusNaloga";
            this.statusNalogaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // vrstaPutniNalogBindingSource
            // 
            this.vrstaPutniNalogBindingSource.DataMember = "vrstaPutniNalog";
            this.vrstaPutniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // vrstaTrosakBindingSource
            // 
            this.vrstaTrosakBindingSource.DataMember = "vrstaTrosak";
            this.vrstaTrosakBindingSource.DataSource = this.piDB1DataSet;
            // 
            // vrstaPutniNalogTableAdapter
            // 
            this.vrstaPutniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nositeljTroskovaTableAdapter = null;
            this.tableAdapterManager.putniNalogTableAdapter = null;
            this.tableAdapterManager.statusNalogaTableAdapter = null;
            this.tableAdapterManager.troskoviTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Uprava.NET.piDB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozilaTableAdapter = null;
            this.tableAdapterManager.vrstaPutniNalogTableAdapter = this.vrstaPutniNalogTableAdapter;
            this.tableAdapterManager.vrstaTrosakTableAdapter = null;
            // 
            // statusNalogaTableAdapter
            // 
            this.statusNalogaTableAdapter.ClearBeforeFill = true;
            // 
            // vozilaTableAdapter
            // 
            this.vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaTrosakTableAdapter
            // 
            this.vrstaTrosakTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_vrsta";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn9.HeaderText = "Naziv vrste troška";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VrstaPutniNalog_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv vrste putnog naloga";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // id_vozila
            // 
            this.id_vozila.DataPropertyName = "id_vozila";
            this.id_vozila.HeaderText = "ID";
            this.id_vozila.Name = "id_vozila";
            this.id_vozila.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "regOznaka";
            this.dataGridViewTextBoxColumn6.HeaderText = "RegOznaka";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "marka";
            this.dataGridViewTextBoxColumn7.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "rasploziv";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Raspoloživ";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_statusa";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn4.HeaderText = "Naziv statusa putnog naloga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // kataloskiPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 337);
            this.Controls.Add(this.tabKataloskiPodaci);
            this.Controls.Add(this.btnOdustani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kataloskiPodaci";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD akcije kataloških podataka";
            this.Load += new System.EventHandler(this.kataloskiPodaci_Load_1);
            this.tabKataloskiPodaci.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaPutniNalog)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusNaloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaTroska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKataloskiPodaci;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource vrstaPutniNalogBindingSource;
        private piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter vrstaPutniNalogTableAdapter;
        private piDB1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvVrstaPutniNalog;
        private System.Windows.Forms.BindingSource statusNalogaBindingSource;
        private piDB1DataSetTableAdapters.statusNalogaTableAdapter statusNalogaTableAdapter;
        private System.Windows.Forms.DataGridView dgvStatusNaloga;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private piDB1DataSetTableAdapters.vozilaTableAdapter vozilaTableAdapter;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.BindingSource vrstaTrosakBindingSource;
        private piDB1DataSetTableAdapters.vrstaTrosakTableAdapter vrstaTrosakTableAdapter;
        private System.Windows.Forms.DataGridView dgvVrstaTroska;
        private System.Windows.Forms.Button btnSpremiVozila;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnSpremiVrstuNaloga;
        private System.Windows.Forms.Button btnDodajVrstuNaloga;
        private System.Windows.Forms.Button btnObrisiVrstuNaloga;
        private System.Windows.Forms.Button btnSpremiVrstuTroska;
        private System.Windows.Forms.Button btnDodajVrstuTroska;
        private System.Windows.Forms.Button btnObrisiVrstuTroska;
        private System.Windows.Forms.Button btnSpremiStatusNaloga;
        private System.Windows.Forms.Button btnDodajStatusNaloga;
        private System.Windows.Forms.Button btnObrisiStatusNaloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}