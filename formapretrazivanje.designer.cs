namespace TIM18_racunovodstvo
{
    partial class formapretrazivanje
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
            this.dgvpretrazivanje = new System.Windows.Forms.DataGridView();
            this.id_naloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePovratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akontacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odgovornaOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumLikvidacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likvidirao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odobrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potpisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnopcije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.odabir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.statusNalogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusNalogaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.statusNalogaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpretrazivanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpretrazivanje
            // 
            this.dgvpretrazivanje.AllowUserToAddRows = false;
            this.dgvpretrazivanje.AllowUserToDeleteRows = false;
            this.dgvpretrazivanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpretrazivanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_naloga,
            this.datumKreiranja,
            this.vrijemePolaska,
            this.vrijemePovratka,
            this.polaziste,
            this.odrediste,
            this.akontacija,
            this.odgovornaOsoba,
            this.nastavnik,
            this.datumLikvidacije,
            this.likvidirao,
            this.odobrio,
            this.potpisao,
            this.btnopcije});
            this.dgvpretrazivanje.Location = new System.Drawing.Point(15, 49);
            this.dgvpretrazivanje.Name = "dgvpretrazivanje";
            this.dgvpretrazivanje.ReadOnly = true;
            this.dgvpretrazivanje.Size = new System.Drawing.Size(1444, 344);
            this.dgvpretrazivanje.TabIndex = 0;
            this.dgvpretrazivanje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpretrazivanje_CellContentClick);
            // 
            // id_naloga
            // 
            this.id_naloga.HeaderText = "ID naloga";
            this.id_naloga.Name = "id_naloga";
            this.id_naloga.ReadOnly = true;
            // 
            // datumKreiranja
            // 
            this.datumKreiranja.HeaderText = "Datum Kreiranja";
            this.datumKreiranja.Name = "datumKreiranja";
            this.datumKreiranja.ReadOnly = true;
            // 
            // vrijemePolaska
            // 
            this.vrijemePolaska.HeaderText = "Vrijeme Polaska";
            this.vrijemePolaska.Name = "vrijemePolaska";
            this.vrijemePolaska.ReadOnly = true;
            // 
            // vrijemePovratka
            // 
            this.vrijemePovratka.HeaderText = "Vrijeme Povratka";
            this.vrijemePovratka.Name = "vrijemePovratka";
            this.vrijemePovratka.ReadOnly = true;
            // 
            // polaziste
            // 
            this.polaziste.HeaderText = "Polaziste";
            this.polaziste.Name = "polaziste";
            this.polaziste.ReadOnly = true;
            // 
            // odrediste
            // 
            this.odrediste.HeaderText = "Odrediste";
            this.odrediste.Name = "odrediste";
            this.odrediste.ReadOnly = true;
            // 
            // akontacija
            // 
            this.akontacija.HeaderText = "Akontacija";
            this.akontacija.Name = "akontacija";
            this.akontacija.ReadOnly = true;
            // 
            // odgovornaOsoba
            // 
            this.odgovornaOsoba.HeaderText = "Odgovorna Osoba";
            this.odgovornaOsoba.Name = "odgovornaOsoba";
            this.odgovornaOsoba.ReadOnly = true;
            // 
            // nastavnik
            // 
            this.nastavnik.HeaderText = "Nastavnik";
            this.nastavnik.Name = "nastavnik";
            this.nastavnik.ReadOnly = true;
            // 
            // datumLikvidacije
            // 
            this.datumLikvidacije.HeaderText = "Datum Likvidacije";
            this.datumLikvidacije.Name = "datumLikvidacije";
            this.datumLikvidacije.ReadOnly = true;
            // 
            // likvidirao
            // 
            this.likvidirao.HeaderText = "Likvidirao";
            this.likvidirao.Name = "likvidirao";
            this.likvidirao.ReadOnly = true;
            // 
            // odobrio
            // 
            this.odobrio.HeaderText = "Odobrio";
            this.odobrio.Name = "odobrio";
            this.odobrio.ReadOnly = true;
            // 
            // potpisao
            // 
            this.potpisao.HeaderText = "Potpisao";
            this.potpisao.Name = "potpisao";
            this.potpisao.ReadOnly = true;
            // 
            // btnopcije
            // 
            this.btnopcije.HeaderText = "Opcije";
            this.btnopcije.Name = "btnopcije";
            this.btnopcije.ReadOnly = true;
            this.btnopcije.Text = "Pregled";
            // 
            // odabir
            // 
            this.odabir.DataSource = this.statusNalogaBindingSource;
            this.odabir.DisplayMember = "naziv";
            this.odabir.FormattingEnabled = true;
            this.odabir.Location = new System.Drawing.Point(138, 22);
            this.odabir.Name = "odabir";
            this.odabir.Size = new System.Drawing.Size(121, 21);
            this.odabir.TabIndex = 1;
            this.odabir.ValueMember = "id_statusa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status putnog naloga:";
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
            // statusNalogaTableAdapter
            // 
            this.statusNalogaTableAdapter.ClearBeforeFill = true;
            // 
            // formapretrazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odabir);
            this.Controls.Add(this.dgvpretrazivanje);
            this.Name = "formapretrazivanje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pretraživanje naloga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formapretrazivanje_FormClosing);
            this.Load += new System.EventHandler(this.formapretrazivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpretrazivanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpretrazivanje;
        private System.Windows.Forms.ComboBox odabir;
        private System.Windows.Forms.Label label1;
        //private piDB1DataSet piDB1DataSet;
        //private piDB1DataSetTableAdapters.statusNalogaTableAdapter statusNalogaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_naloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePovratka;
        private System.Windows.Forms.DataGridViewTextBoxColumn polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn akontacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn odgovornaOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumLikvidacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn likvidirao;
        private System.Windows.Forms.DataGridViewTextBoxColumn odobrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn potpisao;
        private System.Windows.Forms.DataGridViewButtonColumn btnopcije;
        private Uprava.NET.piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource statusNalogaBindingSource;
        private Uprava.NET.piDB1DataSetTableAdapters.statusNalogaTableAdapter statusNalogaTableAdapter;
    }
}