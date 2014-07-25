namespace Uprava.NET
{
    partial class frmZahtjev
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
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.nositeljTroskovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet1 = new Uprava.NET.piDB1DataSet();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            this.vozilaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vozilaTableAdapter();
            this.nositeljTroskovaTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter();
            this.vrstaPutniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaPutniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPosaljiZahtjev = new System.Windows.Forms.Button();
            this.dtpDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.txtPolaziste = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblPolaziste = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpDoVisekratni = new System.Windows.Forms.DateTimePicker();
            this.btnOdustaniVisekratni = new System.Windows.Forms.Button();
            this.btnPosaljiVisekratni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOdVisekratni = new System.Windows.Forms.DateTimePicker();
            this.txtOdredisteVisekratni = new System.Windows.Forms.TextBox();
            this.txtPolazisteVisekratni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpisVisekratni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // nositeljTroskovaBindingSource
            // 
            this.nositeljTroskovaBindingSource.DataMember = "nositeljTroskova";
            this.nositeljTroskovaBindingSource.DataSource = this.piDB1DataSet;
            // 
            // piDB1DataSet1
            // 
            this.piDB1DataSet1.DataSetName = "piDB1DataSet";
            this.piDB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozilaTableAdapter
            // 
            this.vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // nositeljTroskovaTableAdapter
            // 
            this.nositeljTroskovaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaPutniNalogBindingSource
            // 
            this.vrstaPutniNalogBindingSource.DataMember = "vrstaPutniNalog";
            this.vrstaPutniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // vrstaPutniNalogTableAdapter
            // 
            this.vrstaPutniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOdustani);
            this.tabPage1.Controls.Add(this.btnPosaljiZahtjev);
            this.tabPage1.Controls.Add(this.dtpDatumPolaska);
            this.tabPage1.Controls.Add(this.txtOdrediste);
            this.tabPage1.Controls.Add(this.txtPolaziste);
            this.tabPage1.Controls.Add(this.lblDatum);
            this.tabPage1.Controls.Add(this.lblOdrediste);
            this.tabPage1.Controls.Add(this.lblPolaziste);
            this.tabPage1.Controls.Add(this.lblOpis);
            this.tabPage1.Controls.Add(this.txtOpis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jednokratni putni nalog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(396, 308);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(86, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPosaljiZahtjev
            // 
            this.btnPosaljiZahtjev.Location = new System.Drawing.Point(280, 308);
            this.btnPosaljiZahtjev.Name = "btnPosaljiZahtjev";
            this.btnPosaljiZahtjev.Size = new System.Drawing.Size(92, 23);
            this.btnPosaljiZahtjev.TabIndex = 4;
            this.btnPosaljiZahtjev.Text = "Pošalji zahtjev";
            this.btnPosaljiZahtjev.UseVisualStyleBackColor = true;
            this.btnPosaljiZahtjev.Click += new System.EventHandler(this.btnPosaljiZahtjev_Click);
            // 
            // dtpDatumPolaska
            // 
            this.dtpDatumPolaska.Location = new System.Drawing.Point(328, 186);
            this.dtpDatumPolaska.MinDate = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            this.dtpDatumPolaska.Name = "dtpDatumPolaska";
            this.dtpDatumPolaska.Size = new System.Drawing.Size(154, 20);
            this.dtpDatumPolaska.TabIndex = 3;
            this.dtpDatumPolaska.Value = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(87, 223);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(100, 20);
            this.txtOdrediste.TabIndex = 2;
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(87, 186);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(100, 20);
            this.txtPolaziste.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(231, 189);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(81, 13);
            this.lblDatum.TabIndex = 20;
            this.lblDatum.Text = "Datum polaska:";
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Location = new System.Drawing.Point(19, 226);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(55, 13);
            this.lblOdrediste.TabIndex = 19;
            this.lblOdrediste.Text = "Odredište:";
            // 
            // lblPolaziste
            // 
            this.lblPolaziste.AutoSize = true;
            this.lblPolaziste.Location = new System.Drawing.Point(19, 189);
            this.lblPolaziste.Name = "lblPolaziste";
            this.lblPolaziste.Size = new System.Drawing.Size(52, 13);
            this.lblPolaziste.TabIndex = 18;
            this.lblPolaziste.Text = "Polazište:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(13, 19);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(74, 13);
            this.lblOpis.TabIndex = 17;
            this.lblOpis.Text = "Opis zahtjeva:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(16, 35);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(466, 127);
            this.txtOpis.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpDoVisekratni);
            this.tabPage2.Controls.Add(this.btnOdustaniVisekratni);
            this.tabPage2.Controls.Add(this.btnPosaljiVisekratni);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpOdVisekratni);
            this.tabPage2.Controls.Add(this.txtOdredisteVisekratni);
            this.tabPage2.Controls.Add(this.txtPolazisteVisekratni);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtOpisVisekratni);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Višekratni putni nalog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpDoVisekratni
            // 
            this.dtpDoVisekratni.Location = new System.Drawing.Point(328, 223);
            this.dtpDoVisekratni.MinDate = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            this.dtpDoVisekratni.Name = "dtpDoVisekratni";
            this.dtpDoVisekratni.Size = new System.Drawing.Size(154, 20);
            this.dtpDoVisekratni.TabIndex = 4;
            // 
            // btnOdustaniVisekratni
            // 
            this.btnOdustaniVisekratni.Location = new System.Drawing.Point(396, 308);
            this.btnOdustaniVisekratni.Name = "btnOdustaniVisekratni";
            this.btnOdustaniVisekratni.Size = new System.Drawing.Size(86, 23);
            this.btnOdustaniVisekratni.TabIndex = 6;
            this.btnOdustaniVisekratni.Text = "Odustani";
            this.btnOdustaniVisekratni.UseVisualStyleBackColor = true;
            this.btnOdustaniVisekratni.Click += new System.EventHandler(this.btnOdustaniVisekratni_Click);
            // 
            // btnPosaljiVisekratni
            // 
            this.btnPosaljiVisekratni.Location = new System.Drawing.Point(280, 308);
            this.btnPosaljiVisekratni.Name = "btnPosaljiVisekratni";
            this.btnPosaljiVisekratni.Size = new System.Drawing.Size(92, 23);
            this.btnPosaljiVisekratni.TabIndex = 5;
            this.btnPosaljiVisekratni.Text = "Pošalji zahtjev";
            this.btnPosaljiVisekratni.UseVisualStyleBackColor = true;
            this.btnPosaljiVisekratni.Click += new System.EventHandler(this.btnPosaljiVisekratni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Trajanje naloga do:";
            // 
            // dtpOdVisekratni
            // 
            this.dtpOdVisekratni.Location = new System.Drawing.Point(328, 186);
            this.dtpOdVisekratni.MinDate = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            this.dtpOdVisekratni.Name = "dtpOdVisekratni";
            this.dtpOdVisekratni.Size = new System.Drawing.Size(154, 20);
            this.dtpOdVisekratni.TabIndex = 3;
            this.dtpOdVisekratni.Value = new System.DateTime(2012, 6, 16, 0, 0, 0, 0);
            // 
            // txtOdredisteVisekratni
            // 
            this.txtOdredisteVisekratni.Location = new System.Drawing.Point(87, 223);
            this.txtOdredisteVisekratni.Name = "txtOdredisteVisekratni";
            this.txtOdredisteVisekratni.Size = new System.Drawing.Size(100, 20);
            this.txtOdredisteVisekratni.TabIndex = 2;
            // 
            // txtPolazisteVisekratni
            // 
            this.txtPolazisteVisekratni.Location = new System.Drawing.Point(87, 186);
            this.txtPolazisteVisekratni.Name = "txtPolazisteVisekratni";
            this.txtPolazisteVisekratni.Size = new System.Drawing.Size(100, 20);
            this.txtPolazisteVisekratni.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Trajanje naloga od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Odredište:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Polazište:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Opis zahtjeva:";
            // 
            // txtOpisVisekratni
            // 
            this.txtOpisVisekratni.Location = new System.Drawing.Point(16, 35);
            this.txtOpisVisekratni.Multiline = true;
            this.txtOpisVisekratni.Name = "txtOpisVisekratni";
            this.txtOpisVisekratni.Size = new System.Drawing.Size(466, 127);
            this.txtOpisVisekratni.TabIndex = 0;
            // 
            // frmZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje zahtjeva za putnim nalogom";
            this.Load += new System.EventHandler(this.frmZahtjev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nositeljTroskovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPutniNalogBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private piDB1DataSet piDB1DataSet;
        private piDB1DataSet piDB1DataSet1;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private piDB1DataSetTableAdapters.vozilaTableAdapter vozilaTableAdapter;
        private System.Windows.Forms.BindingSource nositeljTroskovaBindingSource;
        private piDB1DataSetTableAdapters.nositeljTroskovaTableAdapter nositeljTroskovaTableAdapter;
        private System.Windows.Forms.BindingSource vrstaPutniNalogBindingSource;
        private piDB1DataSetTableAdapters.vrstaPutniNalogTableAdapter vrstaPutniNalogTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPosaljiZahtjev;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaska;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.TextBox txtPolaziste;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.Label lblPolaziste;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOdustaniVisekratni;
        private System.Windows.Forms.Button btnPosaljiVisekratni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOdVisekratni;
        private System.Windows.Forms.TextBox txtOdredisteVisekratni;
        private System.Windows.Forms.TextBox txtPolazisteVisekratni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpisVisekratni;
        private System.Windows.Forms.DateTimePicker dtpDoVisekratni;
    }
}