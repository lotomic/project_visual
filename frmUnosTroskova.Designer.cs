namespace Uprava.NET
{
    partial class frmUnosTroskova
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
            this.lblUkupniIznos = new System.Windows.Forms.Label();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.btnGotovo = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            this.vrstaTrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.vrstaTrosakTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.vrstaTrosakTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrstaTroska = new System.Windows.Forms.ComboBox();
            this.txtIznosTroska = new System.Windows.Forms.TextBox();
            this.lblNazivTroska = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtOpisTroska = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblkm2 = new System.Windows.Forms.Label();
            this.lblkm1 = new System.Windows.Forms.Label();
            this.txtZavrsnoBrojilo = new System.Windows.Forms.TextBox();
            this.txtPocetnoBrojilo = new System.Windows.Forms.TextBox();
            this.lblZavrsnoBrojilo = new System.Windows.Forms.Label();
            this.lblPocetnoBrojilo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUkupniIznos
            // 
            this.lblUkupniIznos.AutoSize = true;
            this.lblUkupniIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupniIznos.Location = new System.Drawing.Point(49, 351);
            this.lblUkupniIznos.Name = "lblUkupniIznos";
            this.lblUkupniIznos.Size = new System.Drawing.Size(84, 13);
            this.lblUkupniIznos.TabIndex = 2;
            this.lblUkupniIznos.Text = "Ukupni iznos:";
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Enabled = false;
            this.txtUkupniIznos.Location = new System.Drawing.Point(139, 348);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznos.TabIndex = 6;
            // 
            // btnGotovo
            // 
            this.btnGotovo.Location = new System.Drawing.Point(384, 344);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(75, 23);
            this.btnGotovo.TabIndex = 2;
            this.btnGotovo.Text = "Gotovo";
            this.btnGotovo.UseVisualStyleBackColor = true;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
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
            // vrstaTrosakTableAdapter
            // 
            this.vrstaTrosakTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIznos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbVrstaTroska);
            this.groupBox1.Controls.Add(this.txtIznosTroska);
            this.groupBox1.Controls.Add(this.lblNazivTroska);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtOpisTroska);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos troškova nastalih na putovanju";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(113, 106);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(67, 13);
            this.lblIznos.TabIndex = 12;
            this.lblIznos.Text = "Iznos troška:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Odaberite vrstu troška:";
            // 
            // cmbVrstaTroska
            // 
            this.cmbVrstaTroska.DataSource = this.vrstaTrosakBindingSource;
            this.cmbVrstaTroska.DisplayMember = "naziv";
            this.cmbVrstaTroska.FormattingEnabled = true;
            this.cmbVrstaTroska.Location = new System.Drawing.Point(212, 32);
            this.cmbVrstaTroska.Name = "cmbVrstaTroska";
            this.cmbVrstaTroska.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaTroska.TabIndex = 0;
            this.cmbVrstaTroska.ValueMember = "id_vrsta";
            // 
            // txtIznosTroska
            // 
            this.txtIznosTroska.Location = new System.Drawing.Point(212, 106);
            this.txtIznosTroska.Name = "txtIznosTroska";
            this.txtIznosTroska.Size = new System.Drawing.Size(121, 20);
            this.txtIznosTroska.TabIndex = 2;
            // 
            // lblNazivTroska
            // 
            this.lblNazivTroska.AutoSize = true;
            this.lblNazivTroska.Location = new System.Drawing.Point(113, 69);
            this.lblNazivTroska.Name = "lblNazivTroska";
            this.lblNazivTroska.Size = new System.Drawing.Size(63, 13);
            this.lblNazivTroska.TabIndex = 10;
            this.lblNazivTroska.Text = "Opis troška:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(454, 139);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtOpisTroska
            // 
            this.txtOpisTroska.Location = new System.Drawing.Point(212, 69);
            this.txtOpisTroska.Name = "txtOpisTroska";
            this.txtOpisTroska.Size = new System.Drawing.Size(188, 20);
            this.txtOpisTroska.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblkm2);
            this.groupBox2.Controls.Add(this.lblkm1);
            this.groupBox2.Controls.Add(this.txtZavrsnoBrojilo);
            this.groupBox2.Controls.Add(this.txtPocetnoBrojilo);
            this.groupBox2.Controls.Add(this.lblZavrsnoBrojilo);
            this.groupBox2.Controls.Add(this.lblPocetnoBrojilo);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Početno i završno brojilo automobila";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi brojila";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblkm2
            // 
            this.lblkm2.AutoSize = true;
            this.lblkm2.Location = new System.Drawing.Point(495, 46);
            this.lblkm2.Name = "lblkm2";
            this.lblkm2.Size = new System.Drawing.Size(21, 13);
            this.lblkm2.TabIndex = 22;
            this.lblkm2.Text = "km";
            // 
            // lblkm1
            // 
            this.lblkm1.AutoSize = true;
            this.lblkm1.Location = new System.Drawing.Point(222, 46);
            this.lblkm1.Name = "lblkm1";
            this.lblkm1.Size = new System.Drawing.Size(21, 13);
            this.lblkm1.TabIndex = 21;
            this.lblkm1.Text = "km";
            // 
            // txtZavrsnoBrojilo
            // 
            this.txtZavrsnoBrojilo.Location = new System.Drawing.Point(372, 43);
            this.txtZavrsnoBrojilo.Name = "txtZavrsnoBrojilo";
            this.txtZavrsnoBrojilo.Size = new System.Drawing.Size(117, 20);
            this.txtZavrsnoBrojilo.TabIndex = 1;
            // 
            // txtPocetnoBrojilo
            // 
            this.txtPocetnoBrojilo.Location = new System.Drawing.Point(99, 43);
            this.txtPocetnoBrojilo.Name = "txtPocetnoBrojilo";
            this.txtPocetnoBrojilo.Size = new System.Drawing.Size(117, 20);
            this.txtPocetnoBrojilo.TabIndex = 0;
            // 
            // lblZavrsnoBrojilo
            // 
            this.lblZavrsnoBrojilo.AutoSize = true;
            this.lblZavrsnoBrojilo.Location = new System.Drawing.Point(287, 46);
            this.lblZavrsnoBrojilo.Name = "lblZavrsnoBrojilo";
            this.lblZavrsnoBrojilo.Size = new System.Drawing.Size(79, 13);
            this.lblZavrsnoBrojilo.TabIndex = 19;
            this.lblZavrsnoBrojilo.Text = "Završno brojilo:";
            // 
            // lblPocetnoBrojilo
            // 
            this.lblPocetnoBrojilo.AutoSize = true;
            this.lblPocetnoBrojilo.Location = new System.Drawing.Point(13, 46);
            this.lblPocetnoBrojilo.Name = "lblPocetnoBrojilo";
            this.lblPocetnoBrojilo.Size = new System.Drawing.Size(80, 13);
            this.lblPocetnoBrojilo.TabIndex = 17;
            this.lblPocetnoBrojilo.Text = "Početno brojilo:";
            // 
            // frmUnosTroskova
            // 
            this.AcceptButton = this.btnGotovo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.lblUkupniIznos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUnosTroskova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos troškova";
            this.Load += new System.EventHandler(this.frmUnosTroskova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaTrosakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUkupniIznos;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Button btnGotovo;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource vrstaTrosakBindingSource;
        private piDB1DataSetTableAdapters.vrstaTrosakTableAdapter vrstaTrosakTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblkm2;
        private System.Windows.Forms.Label lblkm1;
        private System.Windows.Forms.TextBox txtZavrsnoBrojilo;
        private System.Windows.Forms.TextBox txtPocetnoBrojilo;
        private System.Windows.Forms.Label lblZavrsnoBrojilo;
        private System.Windows.Forms.Label lblPocetnoBrojilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrstaTroska;
        private System.Windows.Forms.TextBox txtIznosTroska;
        private System.Windows.Forms.Label lblNazivTroska;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOpisTroska;
    }
}