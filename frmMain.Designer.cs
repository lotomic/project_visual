namespace Uprava.NET
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijenosPravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generiranjeNalogaPoRasporeduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putniNaloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPristiglizZahtjevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPutnihNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnik = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikPutniNalozi = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikKreirajZahtjev = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikKreirani = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikAkontacija = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikPutniRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikObavijesti = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikArhiva = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikIzvjestaji = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikSviPutniNalozi = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikPutniNaloziPoDatumu = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNastavnikRadSBazom = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusnaTraka = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.racunovodstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretrazivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledGlavneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusnaTraka.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.upravaToolStripMenuItem,
            this.tajnicaToolStripMenuItem,
            this.lstNastavnik,
            this.racunovodstvoToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.loginToolStripMenuItem.Text = "Prijava";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logoutToolStripMenuItem.Text = "Odjava";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // upravaToolStripMenuItem
            // 
            this.upravaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijenosPravaToolStripMenuItem,
            this.pregledNalogaToolStripMenuItem,
            this.generiranjeNalogaPoRasporeduToolStripMenuItem});
            this.upravaToolStripMenuItem.Name = "upravaToolStripMenuItem";
            this.upravaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.upravaToolStripMenuItem.Text = "Uprava";
            // 
            // prijenosPravaToolStripMenuItem
            // 
            this.prijenosPravaToolStripMenuItem.Name = "prijenosPravaToolStripMenuItem";
            this.prijenosPravaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.prijenosPravaToolStripMenuItem.Text = "Prijenos prava";
            this.prijenosPravaToolStripMenuItem.Click += new System.EventHandler(this.prijenosPravaToolStripMenuItem_Click);
            // 
            // pregledNalogaToolStripMenuItem
            // 
            this.pregledNalogaToolStripMenuItem.Name = "pregledNalogaToolStripMenuItem";
            this.pregledNalogaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.pregledNalogaToolStripMenuItem.Text = "Pregled naloga";
            this.pregledNalogaToolStripMenuItem.Click += new System.EventHandler(this.pregledNalogaToolStripMenuItem_Click);
            // 
            // generiranjeNalogaPoRasporeduToolStripMenuItem
            // 
            this.generiranjeNalogaPoRasporeduToolStripMenuItem.Name = "generiranjeNalogaPoRasporeduToolStripMenuItem";
            this.generiranjeNalogaPoRasporeduToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.generiranjeNalogaPoRasporeduToolStripMenuItem.Text = "Generiranje naloga po rasporedu";
            this.generiranjeNalogaPoRasporeduToolStripMenuItem.Click += new System.EventHandler(this.generiranjeNalogaPoRasporeduToolStripMenuItem_Click);
            // 
            // tajnicaToolStripMenuItem
            // 
            this.tajnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.putniNaloziToolStripMenuItem,
            this.evidencijaToolStripMenuItem});
            this.tajnicaToolStripMenuItem.Name = "tajnicaToolStripMenuItem";
            this.tajnicaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tajnicaToolStripMenuItem.Text = "Tajnica";
            // 
            // putniNaloziToolStripMenuItem
            // 
            this.putniNaloziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNalogaToolStripMenuItem,
            this.pregledPristiglizZahtjevaToolStripMenuItem,
            this.pregledPutnihNalogaToolStripMenuItem});
            this.putniNaloziToolStripMenuItem.Name = "putniNaloziToolStripMenuItem";
            this.putniNaloziToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.putniNaloziToolStripMenuItem.Text = "Putni nalozi";
            // 
            // unosNalogaToolStripMenuItem
            // 
            this.unosNalogaToolStripMenuItem.Name = "unosNalogaToolStripMenuItem";
            this.unosNalogaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.unosNalogaToolStripMenuItem.Text = "Unos naloga";
            // 
            // pregledPristiglizZahtjevaToolStripMenuItem
            // 
            this.pregledPristiglizZahtjevaToolStripMenuItem.Name = "pregledPristiglizZahtjevaToolStripMenuItem";
            this.pregledPristiglizZahtjevaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pregledPristiglizZahtjevaToolStripMenuItem.Text = "Pregled pristiglih zahtjeva";
            // 
            // pregledPutnihNalogaToolStripMenuItem
            // 
            this.pregledPutnihNalogaToolStripMenuItem.Name = "pregledPutnihNalogaToolStripMenuItem";
            this.pregledPutnihNalogaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pregledPutnihNalogaToolStripMenuItem.Text = "Pregled putnih naloga";
            // 
            // evidencijaToolStripMenuItem
            // 
            this.evidencijaToolStripMenuItem.Name = "evidencijaToolStripMenuItem";
            this.evidencijaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.evidencijaToolStripMenuItem.Text = "evidencija";
            // 
            // lstNastavnik
            // 
            this.lstNastavnik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstNastavnikPutniNalozi,
            this.lstNastavnikObavijesti,
            this.lstNastavnikArhiva,
            this.lstNastavnikIzvjestaji,
            this.lstNastavnikRadSBazom});
            this.lstNastavnik.Name = "lstNastavnik";
            this.lstNastavnik.Size = new System.Drawing.Size(71, 20);
            this.lstNastavnik.Text = "Nastavnik";
            // 
            // lstNastavnikPutniNalozi
            // 
            this.lstNastavnikPutniNalozi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstNastavnikKreirajZahtjev,
            this.lstNastavnikKreirani,
            this.lstNastavnikAkontacija,
            this.lstNastavnikPutniRacun});
            this.lstNastavnikPutniNalozi.Name = "lstNastavnikPutniNalozi";
            this.lstNastavnikPutniNalozi.Size = new System.Drawing.Size(168, 22);
            this.lstNastavnikPutniNalozi.Text = "Putni nalozi";
            // 
            // lstNastavnikKreirajZahtjev
            // 
            this.lstNastavnikKreirajZahtjev.Name = "lstNastavnikKreirajZahtjev";
            this.lstNastavnikKreirajZahtjev.Size = new System.Drawing.Size(223, 22);
            this.lstNastavnikKreirajZahtjev.Text = "Zahtjev za putnim nalogom";
            this.lstNastavnikKreirajZahtjev.Click += new System.EventHandler(this.lstNastavnikKreirajZahtjev_Click);
            // 
            // lstNastavnikKreirani
            // 
            this.lstNastavnikKreirani.Name = "lstNastavnikKreirani";
            this.lstNastavnikKreirani.Size = new System.Drawing.Size(223, 22);
            this.lstNastavnikKreirani.Text = "Kreirani nalozi";
            this.lstNastavnikKreirani.Click += new System.EventHandler(this.lstNastavnikKreirani_Click);
            // 
            // lstNastavnikAkontacija
            // 
            this.lstNastavnikAkontacija.Name = "lstNastavnikAkontacija";
            this.lstNastavnikAkontacija.Size = new System.Drawing.Size(223, 22);
            this.lstNastavnikAkontacija.Text = "Zahtjev za akontacijom";
            this.lstNastavnikAkontacija.Click += new System.EventHandler(this.lstNastavnikAkontacija_Click);
            // 
            // lstNastavnikPutniRacun
            // 
            this.lstNastavnikPutniRacun.Name = "lstNastavnikPutniRacun";
            this.lstNastavnikPutniRacun.Size = new System.Drawing.Size(223, 22);
            this.lstNastavnikPutniRacun.Text = "Popunjavanje putnih računa";
            this.lstNastavnikPutniRacun.Click += new System.EventHandler(this.lstNastavnikPutniRacun_Click);
            // 
            // lstNastavnikObavijesti
            // 
            this.lstNastavnikObavijesti.Name = "lstNastavnikObavijesti";
            this.lstNastavnikObavijesti.Size = new System.Drawing.Size(168, 22);
            this.lstNastavnikObavijesti.Text = "Obavijesti sustava";
            this.lstNastavnikObavijesti.Click += new System.EventHandler(this.lstNastavnikObavijesti_Click);
            // 
            // lstNastavnikArhiva
            // 
            this.lstNastavnikArhiva.Name = "lstNastavnikArhiva";
            this.lstNastavnikArhiva.Size = new System.Drawing.Size(168, 22);
            this.lstNastavnikArhiva.Text = "Pregled arhive";
            this.lstNastavnikArhiva.Click += new System.EventHandler(this.lstNastavnikArhiva_Click);
            // 
            // lstNastavnikIzvjestaji
            // 
            this.lstNastavnikIzvjestaji.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstNastavnikSviPutniNalozi,
            this.lstNastavnikPutniNaloziPoDatumu});
            this.lstNastavnikIzvjestaji.Name = "lstNastavnikIzvjestaji";
            this.lstNastavnikIzvjestaji.Size = new System.Drawing.Size(168, 22);
            this.lstNastavnikIzvjestaji.Text = "Izvještaji";
            // 
            // lstNastavnikSviPutniNalozi
            // 
            this.lstNastavnikSviPutniNalozi.Name = "lstNastavnikSviPutniNalozi";
            this.lstNastavnikSviPutniNalozi.Size = new System.Drawing.Size(198, 22);
            this.lstNastavnikSviPutniNalozi.Text = "Svi putni nalozi";
            this.lstNastavnikSviPutniNalozi.Click += new System.EventHandler(this.lstNastavnikSviPutniNalozi_Click);
            // 
            // lstNastavnikPutniNaloziPoDatumu
            // 
            this.lstNastavnikPutniNaloziPoDatumu.Name = "lstNastavnikPutniNaloziPoDatumu";
            this.lstNastavnikPutniNaloziPoDatumu.Size = new System.Drawing.Size(198, 22);
            this.lstNastavnikPutniNaloziPoDatumu.Text = "Putni nalozi po datumu";
            this.lstNastavnikPutniNaloziPoDatumu.Click += new System.EventHandler(this.lstNastavnikPutniNaloziPoDatumu_Click);
            // 
            // lstNastavnikRadSBazom
            // 
            this.lstNastavnikRadSBazom.Name = "lstNastavnikRadSBazom";
            this.lstNastavnikRadSBazom.Size = new System.Drawing.Size(168, 22);
            this.lstNastavnikRadSBazom.Text = "Rad s bazom";
            this.lstNastavnikRadSBazom.Click += new System.EventHandler(this.lstNastavnikRadSBazom_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            this.oAplikacijiToolStripMenuItem.Click += new System.EventHandler(this.oAplikacijiToolStripMenuItem_Click);
            // 
            // statusnaTraka
            // 
            this.statusnaTraka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.ssLabel});
            this.statusnaTraka.Location = new System.Drawing.Point(0, 420);
            this.statusnaTraka.Name = "statusnaTraka";
            this.statusnaTraka.Size = new System.Drawing.Size(828, 22);
            this.statusnaTraka.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // ssLabel
            // 
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // racunovodstvoToolStripMenuItem
            // 
            this.racunovodstvoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretrazivanjeToolStripMenuItem,
            this.pregledGlavneKnjigeToolStripMenuItem});
            this.racunovodstvoToolStripMenuItem.Name = "racunovodstvoToolStripMenuItem";
            this.racunovodstvoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.racunovodstvoToolStripMenuItem.Text = "Računovodstvo";
            // 
            // pretrazivanjeToolStripMenuItem
            // 
            this.pretrazivanjeToolStripMenuItem.Name = "pretrazivanjeToolStripMenuItem";
            this.pretrazivanjeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pretrazivanjeToolStripMenuItem.Text = "Pretraživanje";
            this.pretrazivanjeToolStripMenuItem.Click += new System.EventHandler(this.pretrazivanjeToolStripMenuItem_Click);
            // 
            // pregledGlavneKnjigeToolStripMenuItem
            // 
            this.pregledGlavneKnjigeToolStripMenuItem.Name = "pregledGlavneKnjigeToolStripMenuItem";
            this.pregledGlavneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pregledGlavneKnjigeToolStripMenuItem.Text = "Pregled glavne knjige";
            this.pregledGlavneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.pregledGlavneKnjigeToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Uprava.NET.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(828, 442);
            this.Controls.Add(this.statusnaTraka);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni prozor - Putni Nalozi.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusnaTraka.ResumeLayout(false);
            this.statusnaTraka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusnaTraka;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel;
        private System.Windows.Forms.ToolStripMenuItem prijenosPravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generiranjeNalogaPoRasporeduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnik;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikPutniNalozi;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikObavijesti;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikArhiva;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikIzvjestaji;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikKreirajZahtjev;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikKreirani;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikAkontacija;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikPutniRacun;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikSviPutniNalozi;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikPutniNaloziPoDatumu;
        private System.Windows.Forms.ToolStripMenuItem lstNastavnikRadSBazom;
        private System.Windows.Forms.ToolStripMenuItem tajnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putniNaloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPristiglizZahtjevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPutnihNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racunovodstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretrazivanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledGlavneKnjigeToolStripMenuItem;
    }
}

