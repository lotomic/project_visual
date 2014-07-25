namespace Uprava.NET
{
    partial class frmRasporedGeneriranje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerirajNaloge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdRaspored = new System.Windows.Forms.OpenFileDialog();
            this.btnOdabirRasporeda = new System.Windows.Forms.Button();
            this.txtOdabraniRaspored = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.piDB1DataSet11 = new Uprava.NET.piDB1DataSet();
            this.putniNalogTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.datumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visekratniPocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visekratniKraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePovratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nastavnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumKreiranja,
            this.visekratniPocetak,
            this.visekratniKraj,
            this.svrha,
            this.vrijemePolaska,
            this.vrijemePovratka,
            this.polaziste,
            this.odrediste,
            this.nastavnik});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGenerirajNaloge
            // 
            this.btnGenerirajNaloge.Location = new System.Drawing.Point(13, 13);
            this.btnGenerirajNaloge.Name = "btnGenerirajNaloge";
            this.btnGenerirajNaloge.Size = new System.Drawing.Size(129, 23);
            this.btnGenerirajNaloge.TabIndex = 1;
            this.btnGenerirajNaloge.Text = "Generiraj naloge";
            this.btnGenerirajNaloge.UseVisualStyleBackColor = true;
            this.btnGenerirajNaloge.Click += new System.EventHandler(this.btnGenerirajNaloge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odabrani raspored:";
            // 
            // ofdRaspored
            // 
            this.ofdRaspored.FileName = "raspored.xml";
            this.ofdRaspored.Title = "Odaberite raspored:";
            // 
            // btnOdabirRasporeda
            // 
            this.btnOdabirRasporeda.Location = new System.Drawing.Point(170, 13);
            this.btnOdabirRasporeda.Name = "btnOdabirRasporeda";
            this.btnOdabirRasporeda.Size = new System.Drawing.Size(75, 23);
            this.btnOdabirRasporeda.TabIndex = 3;
            this.btnOdabirRasporeda.Text = "Odabir rasporeda";
            this.btnOdabirRasporeda.UseVisualStyleBackColor = true;
            this.btnOdabirRasporeda.Click += new System.EventHandler(this.btnOdabirRasporeda_Click);
            // 
            // txtOdabraniRaspored
            // 
            this.txtOdabraniRaspored.Enabled = false;
            this.txtOdabraniRaspored.Location = new System.Drawing.Point(368, 18);
            this.txtOdabraniRaspored.Name = "txtOdabraniRaspored";
            this.txtOdabraniRaspored.Size = new System.Drawing.Size(349, 20);
            this.txtOdabraniRaspored.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generirani nalozi";
            // 
            // piDB1DataSet11
            // 
            this.piDB1DataSet11.DataSetName = "piDB1DataSet1";
            this.piDB1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // putniNalogTableAdapter1
            // 
            this.putniNalogTableAdapter1.ClearBeforeFill = true;
            // 
            // datumKreiranja
            // 
            this.datumKreiranja.DataPropertyName = "datumKreiranja";
            this.datumKreiranja.HeaderText = "Datum kreiranja";
            this.datumKreiranja.Name = "datumKreiranja";
            this.datumKreiranja.ReadOnly = true;
            // 
            // visekratniPocetak
            // 
            this.visekratniPocetak.DataPropertyName = "visekratniPocetak";
            this.visekratniPocetak.HeaderText = "Pocetak trajanja zahtjeva";
            this.visekratniPocetak.Name = "visekratniPocetak";
            this.visekratniPocetak.ReadOnly = true;
            // 
            // visekratniKraj
            // 
            this.visekratniKraj.DataPropertyName = "visekratniKraj";
            this.visekratniKraj.HeaderText = "Kraj trajanja zahtjeva";
            this.visekratniKraj.Name = "visekratniKraj";
            this.visekratniKraj.ReadOnly = true;
            // 
            // svrha
            // 
            this.svrha.DataPropertyName = "svrha";
            this.svrha.HeaderText = "Svrha";
            this.svrha.Name = "svrha";
            this.svrha.ReadOnly = true;
            // 
            // vrijemePolaska
            // 
            this.vrijemePolaska.DataPropertyName = "vrijemePolaska";
            this.vrijemePolaska.HeaderText = "Vrijeme polaska";
            this.vrijemePolaska.Name = "vrijemePolaska";
            this.vrijemePolaska.ReadOnly = true;
            // 
            // vrijemePovratka
            // 
            this.vrijemePovratka.DataPropertyName = "vrijemePovratka";
            this.vrijemePovratka.HeaderText = "Vrijeme povratka";
            this.vrijemePovratka.Name = "vrijemePovratka";
            this.vrijemePovratka.ReadOnly = true;
            // 
            // polaziste
            // 
            this.polaziste.DataPropertyName = "polaziste";
            this.polaziste.HeaderText = "Polaziste";
            this.polaziste.Name = "polaziste";
            this.polaziste.ReadOnly = true;
            // 
            // odrediste
            // 
            this.odrediste.DataPropertyName = "odrediste";
            this.odrediste.HeaderText = "Odrediste";
            this.odrediste.Name = "odrediste";
            this.odrediste.ReadOnly = true;
            // 
            // nastavnik
            // 
            this.nastavnik.DataPropertyName = "nastavnik";
            this.nastavnik.HeaderText = "Nastavnik";
            this.nastavnik.Name = "nastavnik";
            this.nastavnik.ReadOnly = true;
            // 
            // frmRasporedGeneriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdabraniRaspored);
            this.Controls.Add(this.btnOdabirRasporeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerirajNaloge);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRasporedGeneriranje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generiranje naloga iz rasporeda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerirajNaloge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdRaspored;
        private System.Windows.Forms.Button btnOdabirRasporeda;
        private System.Windows.Forms.TextBox txtOdabraniRaspored;
        private piDB1DataSet piDB1DataSet11;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn visekratniPocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn visekratniKraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePovratka;
        private System.Windows.Forms.DataGridViewTextBoxColumn polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnik;


    }
}