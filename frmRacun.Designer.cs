namespace Uprava.NET
{
    partial class frmRacun
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
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.piDB1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatumKreiranja = new System.Windows.Forms.ComboBox();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblPolaziste = new System.Windows.Forms.Label();
            this.lblOdaberi = new System.Windows.Forms.Label();
            this.cmbOdaberi = new System.Windows.Forms.ComboBox();
            this.btnPosaljiRacun = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVrijemePovratka = new System.Windows.Forms.Label();
            this.btnUnosIzvjesca = new System.Windows.Forms.Button();
            this.dtpDatumPovratka = new System.Windows.Forms.DateTimePicker();
            this.btnUnosTroskova = new System.Windows.Forms.Button();
            this.dtpDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.lblVrijemePolaska = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPosaljiRacunVisekratni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnosTroskovaVisekratni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPovratak = new System.Windows.Forms.DateTimePicker();
            this.dtpOdlazak = new System.Windows.Forms.DateTimePicker();
            this.btnOdustaniVisekratni = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDatumDo = new System.Windows.Forms.ComboBox();
            this.cmbDatumOd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOdaberiVisekratni = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1BindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // putniNalogBindingSource
            // 
            this.putniNalogBindingSource.DataMember = "putniNalog";
            this.putniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 403);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lblOdaberi);
            this.tabPage1.Controls.Add(this.cmbOdaberi);
            this.tabPage1.Controls.Add(this.btnPosaljiRacun);
            this.tabPage1.Controls.Add(this.btnOdustani);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jednokratni putni nalog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbDatumKreiranja);
            this.groupBox2.Controls.Add(this.cmbOdrediste);
            this.groupBox2.Controls.Add(this.cmbPolaziste);
            this.groupBox2.Controls.Add(this.lblOdrediste);
            this.groupBox2.Controls.Add(this.lblPolaziste);
            this.groupBox2.Location = new System.Drawing.Point(6, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o nalogu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Datum kreiranja naloga:";
            // 
            // cmbDatumKreiranja
            // 
            this.cmbDatumKreiranja.DataSource = this.putniNalogBindingSource;
            this.cmbDatumKreiranja.DisplayMember = "datumKreiranja";
            this.cmbDatumKreiranja.Enabled = false;
            this.cmbDatumKreiranja.FormattingEnabled = true;
            this.cmbDatumKreiranja.Location = new System.Drawing.Point(153, 32);
            this.cmbDatumKreiranja.Name = "cmbDatumKreiranja";
            this.cmbDatumKreiranja.Size = new System.Drawing.Size(121, 21);
            this.cmbDatumKreiranja.TabIndex = 0;
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.DataSource = this.putniNalogBindingSource;
            this.cmbOdrediste.DisplayMember = "odrediste";
            this.cmbOdrediste.Enabled = false;
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(443, 74);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(121, 21);
            this.cmbOdrediste.TabIndex = 2;
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.DataSource = this.putniNalogBindingSource;
            this.cmbPolaziste.DisplayMember = "polaziste";
            this.cmbPolaziste.Enabled = false;
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(153, 74);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(121, 21);
            this.cmbPolaziste.TabIndex = 1;
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Location = new System.Drawing.Point(347, 77);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(55, 13);
            this.lblOdrediste.TabIndex = 26;
            this.lblOdrediste.Text = "Odredište:";
            // 
            // lblPolaziste
            // 
            this.lblPolaziste.AutoSize = true;
            this.lblPolaziste.Location = new System.Drawing.Point(18, 77);
            this.lblPolaziste.Name = "lblPolaziste";
            this.lblPolaziste.Size = new System.Drawing.Size(52, 13);
            this.lblPolaziste.TabIndex = 24;
            this.lblPolaziste.Text = "Polazište:";
            // 
            // lblOdaberi
            // 
            this.lblOdaberi.AutoSize = true;
            this.lblOdaberi.Location = new System.Drawing.Point(138, 13);
            this.lblOdaberi.Name = "lblOdaberi";
            this.lblOdaberi.Size = new System.Drawing.Size(235, 13);
            this.lblOdaberi.TabIndex = 46;
            this.lblOdaberi.Text = "Odaberite nalog za koji želite kreirati putni račun:";
            // 
            // cmbOdaberi
            // 
            this.cmbOdaberi.DataSource = this.putniNalogBindingSource;
            this.cmbOdaberi.DisplayMember = "id_naloga";
            this.cmbOdaberi.FormattingEnabled = true;
            this.cmbOdaberi.Location = new System.Drawing.Point(379, 10);
            this.cmbOdaberi.Name = "cmbOdaberi";
            this.cmbOdaberi.Size = new System.Drawing.Size(40, 21);
            this.cmbOdaberi.TabIndex = 0;
            this.cmbOdaberi.ValueMember = "id_naloga";
            this.cmbOdaberi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberi_SelectedIndexChanged);
            // 
            // btnPosaljiRacun
            // 
            this.btnPosaljiRacun.Location = new System.Drawing.Point(418, 348);
            this.btnPosaljiRacun.Name = "btnPosaljiRacun";
            this.btnPosaljiRacun.Size = new System.Drawing.Size(80, 23);
            this.btnPosaljiRacun.TabIndex = 3;
            this.btnPosaljiRacun.Text = "Pošalji račun";
            this.btnPosaljiRacun.UseVisualStyleBackColor = true;
            this.btnPosaljiRacun.Click += new System.EventHandler(this.btnPosaljiRacun_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(522, 348);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVrijemePovratka);
            this.groupBox1.Controls.Add(this.btnUnosIzvjesca);
            this.groupBox1.Controls.Add(this.dtpDatumPovratka);
            this.groupBox1.Controls.Add(this.btnUnosTroskova);
            this.groupBox1.Controls.Add(this.dtpDatumPolaska);
            this.groupBox1.Controls.Add(this.lblVrijemePolaska);
            this.groupBox1.Location = new System.Drawing.Point(6, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos podataka";
            // 
            // lblVrijemePovratka
            // 
            this.lblVrijemePovratka.AutoSize = true;
            this.lblVrijemePovratka.Location = new System.Drawing.Point(298, 53);
            this.lblVrijemePovratka.Name = "lblVrijemePovratka";
            this.lblVrijemePovratka.Size = new System.Drawing.Size(89, 13);
            this.lblVrijemePovratka.TabIndex = 13;
            this.lblVrijemePovratka.Text = "Vrijeme povratka:";
            // 
            // btnUnosIzvjesca
            // 
            this.btnUnosIzvjesca.Location = new System.Drawing.Point(362, 102);
            this.btnUnosIzvjesca.Name = "btnUnosIzvjesca";
            this.btnUnosIzvjesca.Size = new System.Drawing.Size(91, 23);
            this.btnUnosIzvjesca.TabIndex = 3;
            this.btnUnosIzvjesca.Text = "Unos izvješća";
            this.btnUnosIzvjesca.UseVisualStyleBackColor = true;
            this.btnUnosIzvjesca.Click += new System.EventHandler(this.btnUnosIzvjesca_Click);
            // 
            // dtpDatumPovratka
            // 
            this.dtpDatumPovratka.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtpDatumPovratka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPovratka.Location = new System.Drawing.Point(393, 49);
            this.dtpDatumPovratka.MinDate = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            this.dtpDatumPovratka.Name = "dtpDatumPovratka";
            this.dtpDatumPovratka.Size = new System.Drawing.Size(144, 20);
            this.dtpDatumPovratka.TabIndex = 1;
            // 
            // btnUnosTroskova
            // 
            this.btnUnosTroskova.Location = new System.Drawing.Point(189, 102);
            this.btnUnosTroskova.Name = "btnUnosTroskova";
            this.btnUnosTroskova.Size = new System.Drawing.Size(85, 23);
            this.btnUnosTroskova.TabIndex = 2;
            this.btnUnosTroskova.Text = "Unos troškova";
            this.btnUnosTroskova.UseVisualStyleBackColor = true;
            this.btnUnosTroskova.Click += new System.EventHandler(this.btnUnosTroskova_Click);
            // 
            // dtpDatumPolaska
            // 
            this.dtpDatumPolaska.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtpDatumPolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaska.Location = new System.Drawing.Point(108, 49);
            this.dtpDatumPolaska.MinDate = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            this.dtpDatumPolaska.Name = "dtpDatumPolaska";
            this.dtpDatumPolaska.Size = new System.Drawing.Size(144, 20);
            this.dtpDatumPolaska.TabIndex = 0;
            this.dtpDatumPolaska.Value = new System.DateTime(2012, 6, 16, 11, 32, 38, 0);
            // 
            // lblVrijemePolaska
            // 
            this.lblVrijemePolaska.AutoSize = true;
            this.lblVrijemePolaska.Location = new System.Drawing.Point(18, 53);
            this.lblVrijemePolaska.Name = "lblVrijemePolaska";
            this.lblVrijemePolaska.Size = new System.Drawing.Size(84, 13);
            this.lblVrijemePolaska.TabIndex = 7;
            this.lblVrijemePolaska.Text = "Vrijeme polaska:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPosaljiRacunVisekratni);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnOdustaniVisekratni);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmbOdaberiVisekratni);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Višekratni putni nalog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPosaljiRacunVisekratni
            // 
            this.btnPosaljiRacunVisekratni.Location = new System.Drawing.Point(418, 348);
            this.btnPosaljiRacunVisekratni.Name = "btnPosaljiRacunVisekratni";
            this.btnPosaljiRacunVisekratni.Size = new System.Drawing.Size(80, 23);
            this.btnPosaljiRacunVisekratni.TabIndex = 3;
            this.btnPosaljiRacunVisekratni.Text = "Pošalji račun";
            this.btnPosaljiRacunVisekratni.UseVisualStyleBackColor = true;
            this.btnPosaljiRacunVisekratni.Click += new System.EventHandler(this.btnPosaljiRacunVisekratni_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnosTroskovaVisekratni);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpPovratak);
            this.groupBox3.Controls.Add(this.dtpOdlazak);
            this.groupBox3.Location = new System.Drawing.Point(6, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unos novih podataka";
            // 
            // btnUnosTroskovaVisekratni
            // 
            this.btnUnosTroskovaVisekratni.Location = new System.Drawing.Point(357, 66);
            this.btnUnosTroskovaVisekratni.Name = "btnUnosTroskovaVisekratni";
            this.btnUnosTroskovaVisekratni.Size = new System.Drawing.Size(93, 23);
            this.btnUnosTroskovaVisekratni.TabIndex = 2;
            this.btnUnosTroskovaVisekratni.Text = "Unos troškova";
            this.btnUnosTroskovaVisekratni.UseVisualStyleBackColor = true;
            this.btnUnosTroskovaVisekratni.Click += new System.EventHandler(this.btnUnosTroskovaVisekratni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Povratak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Odlazak:";
            // 
            // dtpPovratak
            // 
            this.dtpPovratak.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dtpPovratak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPovratak.Location = new System.Drawing.Point(133, 88);
            this.dtpPovratak.Name = "dtpPovratak";
            this.dtpPovratak.Size = new System.Drawing.Size(141, 20);
            this.dtpPovratak.TabIndex = 1;
            // 
            // dtpOdlazak
            // 
            this.dtpOdlazak.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dtpOdlazak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOdlazak.Location = new System.Drawing.Point(133, 37);
            this.dtpOdlazak.Name = "dtpOdlazak";
            this.dtpOdlazak.Size = new System.Drawing.Size(141, 20);
            this.dtpOdlazak.TabIndex = 0;
            // 
            // btnOdustaniVisekratni
            // 
            this.btnOdustaniVisekratni.Location = new System.Drawing.Point(522, 348);
            this.btnOdustaniVisekratni.Name = "btnOdustaniVisekratni";
            this.btnOdustaniVisekratni.Size = new System.Drawing.Size(75, 23);
            this.btnOdustaniVisekratni.TabIndex = 4;
            this.btnOdustaniVisekratni.Text = "Odustani";
            this.btnOdustaniVisekratni.UseVisualStyleBackColor = true;
            this.btnOdustaniVisekratni.Click += new System.EventHandler(this.btnOdustaniVisekratni_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbDatumDo);
            this.groupBox4.Controls.Add(this.cmbDatumOd);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 114);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podaci o nalogu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Trajanje naloga do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Trajanje naloga od:";
            // 
            // cmbDatumDo
            // 
            this.cmbDatumDo.DataSource = this.putniNalogBindingSource;
            this.cmbDatumDo.DisplayMember = "visekratniKraj";
            this.cmbDatumDo.Enabled = false;
            this.cmbDatumDo.FormattingEnabled = true;
            this.cmbDatumDo.Location = new System.Drawing.Point(443, 74);
            this.cmbDatumDo.Name = "cmbDatumDo";
            this.cmbDatumDo.Size = new System.Drawing.Size(121, 21);
            this.cmbDatumDo.TabIndex = 3;
            // 
            // cmbDatumOd
            // 
            this.cmbDatumOd.DataSource = this.putniNalogBindingSource;
            this.cmbDatumOd.DisplayMember = "visekratniPocetak";
            this.cmbDatumOd.Enabled = false;
            this.cmbDatumOd.FormattingEnabled = true;
            this.cmbDatumOd.Location = new System.Drawing.Point(443, 32);
            this.cmbDatumOd.Name = "cmbDatumOd";
            this.cmbDatumOd.Size = new System.Drawing.Size(121, 21);
            this.cmbDatumOd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Datum kreiranja naloga:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.putniNalogBindingSource;
            this.comboBox1.DisplayMember = "datumKreiranja";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.putniNalogBindingSource;
            this.comboBox2.DisplayMember = "odrediste";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "U mjesto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Odaberite nalog za koji želite kreirati putni račun:";
            // 
            // cmbOdaberiVisekratni
            // 
            this.cmbOdaberiVisekratni.DataSource = this.putniNalogBindingSource;
            this.cmbOdaberiVisekratni.DisplayMember = "id_naloga";
            this.cmbOdaberiVisekratni.FormattingEnabled = true;
            this.cmbOdaberiVisekratni.Location = new System.Drawing.Point(379, 10);
            this.cmbOdaberiVisekratni.Name = "cmbOdaberiVisekratni";
            this.cmbOdaberiVisekratni.Size = new System.Drawing.Size(40, 21);
            this.cmbOdaberiVisekratni.TabIndex = 0;
            this.cmbOdaberiVisekratni.ValueMember = "id_naloga";
            this.cmbOdaberiVisekratni.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberi_SelectedIndexChanged);
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRacun";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos putnih računa";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1BindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource piDB1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDatumKreiranja;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.ComboBox cmbPolaziste;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.Label lblPolaziste;
        private System.Windows.Forms.Label lblOdaberi;
        private System.Windows.Forms.ComboBox cmbOdaberi;
        private System.Windows.Forms.Button btnPosaljiRacun;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVrijemePovratka;
        private System.Windows.Forms.Button btnUnosIzvjesca;
        private System.Windows.Forms.DateTimePicker dtpDatumPovratka;
        private System.Windows.Forms.Button btnUnosTroskova;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaska;
        private System.Windows.Forms.Label lblVrijemePolaska;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPosaljiRacunVisekratni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnosTroskovaVisekratni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPovratak;
        private System.Windows.Forms.DateTimePicker dtpOdlazak;
        private System.Windows.Forms.Button btnOdustaniVisekratni;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDatumDo;
        private System.Windows.Forms.ComboBox cmbDatumOd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOdaberiVisekratni;
    }
}