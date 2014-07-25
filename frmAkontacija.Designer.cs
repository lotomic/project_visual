namespace Uprava.NET
{
    partial class frmAkontacija
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblOdaberi = new System.Windows.Forms.Label();
            this.cmbOdaberi = new System.Windows.Forms.ComboBox();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAkontacija = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbDatumKreiranja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pošalji zahtjev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOdaberi
            // 
            this.lblOdaberi.AutoSize = true;
            this.lblOdaberi.Location = new System.Drawing.Point(90, 21);
            this.lblOdaberi.Name = "lblOdaberi";
            this.lblOdaberi.Size = new System.Drawing.Size(85, 13);
            this.lblOdaberi.TabIndex = 21;
            this.lblOdaberi.Text = "Odaberite nalog:";
            // 
            // cmbOdaberi
            // 
            this.cmbOdaberi.DataSource = this.putniNalogBindingSource;
            this.cmbOdaberi.DisplayMember = "id_naloga";
            this.cmbOdaberi.FormattingEnabled = true;
            this.cmbOdaberi.Location = new System.Drawing.Point(181, 18);
            this.cmbOdaberi.Name = "cmbOdaberi";
            this.cmbOdaberi.Size = new System.Drawing.Size(40, 21);
            this.cmbOdaberi.TabIndex = 0;
            this.cmbOdaberi.ValueMember = "id_naloga";
            this.cmbOdaberi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberi_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unesite iznos akontacije:";
            // 
            // txtAkontacija
            // 
            this.txtAkontacija.Location = new System.Drawing.Point(143, 241);
            this.txtAkontacija.Name = "txtAkontacija";
            this.txtAkontacija.Size = new System.Drawing.Size(121, 20);
            this.txtAkontacija.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbDatumKreiranja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOdrediste);
            this.groupBox1.Controls.Add(this.cmbPolaziste);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o nalogu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum polaska:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.putniNalogBindingSource;
            this.comboBox1.DisplayMember = "vrijemePolaska";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id_naloga";
            // 
            // cmbDatumKreiranja
            // 
            this.cmbDatumKreiranja.DataSource = this.putniNalogBindingSource;
            this.cmbDatumKreiranja.DisplayMember = "datumKreiranja";
            this.cmbDatumKreiranja.Enabled = false;
            this.cmbDatumKreiranja.FormattingEnabled = true;
            this.cmbDatumKreiranja.Location = new System.Drawing.Point(131, 95);
            this.cmbDatumKreiranja.Name = "cmbDatumKreiranja";
            this.cmbDatumKreiranja.Size = new System.Drawing.Size(121, 21);
            this.cmbDatumKreiranja.TabIndex = 7;
            this.cmbDatumKreiranja.ValueMember = "id_naloga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum kreiranja:";
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.DataSource = this.putniNalogBindingSource;
            this.cmbOdrediste.DisplayMember = "odrediste";
            this.cmbOdrediste.Enabled = false;
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(131, 65);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(121, 21);
            this.cmbOdrediste.TabIndex = 5;
            this.cmbOdrediste.ValueMember = "id_naloga";
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.DataSource = this.putniNalogBindingSource;
            this.cmbPolaziste.DisplayMember = "polaziste";
            this.cmbPolaziste.Enabled = false;
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(131, 34);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(121, 21);
            this.cmbPolaziste.TabIndex = 4;
            this.cmbPolaziste.ValueMember = "id_naloga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Odredište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Polazište:";
            // 
            // frmAkontacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 318);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAkontacija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOdaberi);
            this.Controls.Add(this.cmbOdaberi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAkontacija";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos zahtjeva za akontacijom";
            this.Load += new System.EventHandler(this.frmAkontacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOdaberi;
        private System.Windows.Forms.ComboBox cmbOdaberi;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAkontacija;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbDatumKreiranja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.ComboBox cmbPolaziste;
    }
}