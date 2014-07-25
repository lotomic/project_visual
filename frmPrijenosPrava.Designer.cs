namespace Uprava.NET
{
    partial class frmPrijenosPrava
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
            this.btnPrenesiPrava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dtpTrajanjePrijenosa = new System.Windows.Forms.DateTimePicker();
            this.chkTrajniPrijenosPrava = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxPrenesenaPrava = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.piDB1DataSet11 = new Uprava.NET.piDB1DataSet();
            this.prijenosPravaTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.prijenosPravaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrenesiPrava
            // 
            this.btnPrenesiPrava.Location = new System.Drawing.Point(45, 194);
            this.btnPrenesiPrava.Name = "btnPrenesiPrava";
            this.btnPrenesiPrava.Size = new System.Drawing.Size(121, 23);
            this.btnPrenesiPrava.TabIndex = 0;
            this.btnPrenesiPrava.Text = "Prenesi prava";
            this.btnPrenesiPrava.UseVisualStyleBackColor = true;
            this.btnPrenesiPrava.Click += new System.EventHandler(this.btnPrenesiPrava_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(46, 210);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(116, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dtpTrajanjePrijenosa
            // 
            this.dtpTrajanjePrijenosa.Location = new System.Drawing.Point(12, 112);
            this.dtpTrajanjePrijenosa.Name = "dtpTrajanjePrijenosa";
            this.dtpTrajanjePrijenosa.Size = new System.Drawing.Size(200, 20);
            this.dtpTrajanjePrijenosa.TabIndex = 4;
            // 
            // chkTrajniPrijenosPrava
            // 
            this.chkTrajniPrijenosPrava.AutoSize = true;
            this.chkTrajniPrijenosPrava.Location = new System.Drawing.Point(12, 154);
            this.chkTrajniPrijenosPrava.Name = "chkTrajniPrijenosPrava";
            this.chkTrajniPrijenosPrava.Size = new System.Drawing.Size(123, 17);
            this.chkTrajniPrijenosPrava.TabIndex = 5;
            this.chkTrajniPrijenosPrava.Text = "Trajno prenesi prava";
            this.chkTrajniPrijenosPrava.UseVisualStyleBackColor = true;
            this.chkTrajniPrijenosPrava.CheckedChanged += new System.EventHandler(this.chkTrajniPrijenosPrava_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trajanje prijenosa do:";
            // 
            // lboxPrenesenaPrava
            // 
            this.lboxPrenesenaPrava.FormattingEnabled = true;
            this.lboxPrenesenaPrava.Location = new System.Drawing.Point(26, 37);
            this.lboxPrenesenaPrava.Name = "lboxPrenesenaPrava";
            this.lboxPrenesenaPrava.Size = new System.Drawing.Size(166, 108);
            this.lboxPrenesenaPrava.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Oduzmi prava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(12, 37);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(200, 21);
            this.cmbKorisnici.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenesi prava korisniku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Korisnici sa prenešenim pravima:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbKorisnici);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTrajanjePrijenosa);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chkTrajniPrijenosPrava);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrenesiPrava);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnOdustani);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lboxPrenesenaPrava);
            this.splitContainer1.Size = new System.Drawing.Size(460, 263);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 12;
            // 
            // piDB1DataSet11
            // 
            this.piDB1DataSet11.DataSetName = "piDB1DataSet1";
            this.piDB1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prijenosPravaTableAdapter1
            // 
            this.prijenosPravaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPrijenosPrava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 263);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrijenosPrava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prijenos prava";
            this.Load += new System.EventHandler(this.frmPrijenosPrava_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrenesiPrava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DateTimePicker dtpTrajanjePrijenosa;
        private System.Windows.Forms.CheckBox chkTrajniPrijenosPrava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxPrenesenaPrava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private piDB1DataSet piDB1DataSet11;
        private piDB1DataSetTableAdapters.prijenosPravaTableAdapter prijenosPravaTableAdapter1;
    }
}