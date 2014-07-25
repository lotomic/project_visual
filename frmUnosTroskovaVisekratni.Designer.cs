namespace Uprava.NET
{
    partial class frmUnosTroskovaVisekratni
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
            this.vrstaTrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.btnGotovo = new System.Windows.Forms.Button();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.lblUkupniIznos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNazivTroska = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtIznosTroska = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbVrstaTroska = new System.Windows.Forms.ComboBox();
            this.txtOpisTroska = new System.Windows.Forms.TextBox();
            this.vrstaTrosakTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaTrosakTableAdapter();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vrstaTrosakBindingSource
            // 
            this.vrstaTrosakBindingSource.DataMember = "vrstaTrosak";
            this.vrstaTrosakBindingSource.DataSource = this.piDB1DataSet;
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGotovo
            // 
            this.btnGotovo.Location = new System.Drawing.Point(473, 237);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(75, 23);
            this.btnGotovo.TabIndex = 1;
            this.btnGotovo.Text = "Gotovo";
            this.btnGotovo.UseVisualStyleBackColor = true;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Enabled = false;
            this.txtUkupniIznos.Location = new System.Drawing.Point(258, 209);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.Size = new System.Drawing.Size(121, 20);
            this.txtUkupniIznos.TabIndex = 16;
            // 
            // lblUkupniIznos
            // 
            this.lblUkupniIznos.AutoSize = true;
            this.lblUkupniIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupniIznos.Location = new System.Drawing.Point(155, 212);
            this.lblUkupniIznos.Name = "lblUkupniIznos";
            this.lblUkupniIznos.Size = new System.Drawing.Size(84, 13);
            this.lblUkupniIznos.TabIndex = 12;
            this.lblUkupniIznos.Text = "Ukupni iznos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNazivTroska);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIznos);
            this.groupBox1.Controls.Add(this.txtIznosTroska);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cmbVrstaTroska);
            this.groupBox1.Controls.Add(this.txtOpisTroska);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos troškova nastalih na putovanju";
            // 
            // lblNazivTroska
            // 
            this.lblNazivTroska.AutoSize = true;
            this.lblNazivTroska.Location = new System.Drawing.Point(156, 83);
            this.lblNazivTroska.Name = "lblNazivTroska";
            this.lblNazivTroska.Size = new System.Drawing.Size(63, 13);
            this.lblNazivTroska.TabIndex = 20;
            this.lblNazivTroska.Text = "Opis troška:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Odaberite vrstu troška:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(152, 126);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(67, 13);
            this.lblIznos.TabIndex = 23;
            this.lblIznos.Text = "Iznos troška:";
            // 
            // txtIznosTroska
            // 
            this.txtIznosTroska.Location = new System.Drawing.Point(246, 123);
            this.txtIznosTroska.Name = "txtIznosTroska";
            this.txtIznosTroska.Size = new System.Drawing.Size(121, 20);
            this.txtIznosTroska.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(455, 139);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbVrstaTroska
            // 
            this.cmbVrstaTroska.DataSource = this.vrstaTrosakBindingSource;
            this.cmbVrstaTroska.DisplayMember = "naziv";
            this.cmbVrstaTroska.FormattingEnabled = true;
            this.cmbVrstaTroska.Location = new System.Drawing.Point(246, 34);
            this.cmbVrstaTroska.Name = "cmbVrstaTroska";
            this.cmbVrstaTroska.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaTroska.TabIndex = 0;
            this.cmbVrstaTroska.ValueMember = "id_vrsta";
            // 
            // txtOpisTroska
            // 
            this.txtOpisTroska.Location = new System.Drawing.Point(246, 80);
            this.txtOpisTroska.Name = "txtOpisTroska";
            this.txtOpisTroska.Size = new System.Drawing.Size(188, 20);
            this.txtOpisTroska.TabIndex = 1;
            // 
            // vrstaTrosakTableAdapter
            // 
            this.vrstaTrosakTableAdapter.ClearBeforeFill = true;
            // 
            // frmUnosTroskovaVisekratni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 272);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.lblUkupniIznos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUnosTroskovaVisekratni";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUnosTroskovaVisekratni";
            this.Load += new System.EventHandler(this.frmUnosTroskovaVisekratni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGotovo;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Label lblUkupniIznos;
        private System.Windows.Forms.GroupBox groupBox1;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource vrstaTrosakBindingSource;
        private piDB1DataSetTableAdapters.vrstaTrosakTableAdapter vrstaTrosakTableAdapter;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label lblNazivTroska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtIznosTroska;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbVrstaTroska;
        private System.Windows.Forms.TextBox txtOpisTroska;

    }
}