namespace Uprava.NET
{
    partial class frmPregledKreiranogNaloga
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
            this.lblOdaberi = new System.Windows.Forms.Label();
            this.cmbOdaberi = new System.Windows.Forms.ComboBox();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdaberi
            // 
            this.lblOdaberi.AutoSize = true;
            this.lblOdaberi.Location = new System.Drawing.Point(120, 21);
            this.lblOdaberi.Name = "lblOdaberi";
            this.lblOdaberi.Size = new System.Drawing.Size(214, 13);
            this.lblOdaberi.TabIndex = 48;
            this.lblOdaberi.Text = "Odaberite kreirani nalog koji želite pogledati:";
            // 
            // cmbOdaberi
            // 
            this.cmbOdaberi.DataSource = this.putniNalogBindingSource;
            this.cmbOdaberi.DisplayMember = "id_naloga";
            this.cmbOdaberi.FormattingEnabled = true;
            this.cmbOdaberi.Location = new System.Drawing.Point(340, 18);
            this.cmbOdaberi.Name = "cmbOdaberi";
            this.cmbOdaberi.Size = new System.Drawing.Size(40, 21);
            this.cmbOdaberi.TabIndex = 47;
            this.cmbOdaberi.ValueMember = "id_naloga";
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
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(427, 388);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 61;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.putniNalogBindingSource;
            this.comboBox1.DisplayMember = "datumKreiranja";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 62;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.putniNalogBindingSource;
            this.comboBox2.DisplayMember = "svrha";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(379, 21);
            this.comboBox2.TabIndex = 63;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.putniNalogBindingSource;
            this.comboBox3.DisplayMember = "polaziste";
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(123, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 64;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.putniNalogBindingSource;
            this.comboBox4.DisplayMember = "odrediste";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(123, 213);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 65;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.putniNalogBindingSource;
            this.comboBox5.DisplayMember = "id_vrstaNaloga";
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(123, 260);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Datum kreiranja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Svrha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Polazište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Odredište:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Vrsta naloga:";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.putniNalogBindingSource;
            this.comboBox6.DisplayMember = "nastavnik";
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(123, 306);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Nastavnik:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(265, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 57);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta naloga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "2 - Višestruka putovanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "1 - Jednokratna putovanja";
            // 
            // frmPregledKreiranogNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblOdaberi);
            this.Controls.Add(this.cmbOdaberi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPregledKreiranogNaloga";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled kreiranog naloga";
            this.Load += new System.EventHandler(this.frmPregledKreiranogNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdaberi;
        private System.Windows.Forms.ComboBox cmbOdaberi;
        private piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}