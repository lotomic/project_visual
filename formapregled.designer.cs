namespace TIM18_racunovodstvo
{
    partial class formapregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formapregled));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brnaloga = new System.Windows.Forms.TextBox();
            this.dkdatuma = new System.Windows.Forms.TextBox();
            this.dpdatuma = new System.Windows.Forms.TextBox();
            this.dpovratka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.polaziste = new System.Windows.Forms.TextBox();
            this.odrediste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nastavnik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnispisi = new System.Windows.Forms.Button();
            this.btnisplati = new System.Windows.Forms.Button();
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum kreiranja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum polaska";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum povratka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nalog br:";
            // 
            // brnaloga
            // 
            this.brnaloga.Location = new System.Drawing.Point(68, 21);
            this.brnaloga.Name = "brnaloga";
            this.brnaloga.ReadOnly = true;
            this.brnaloga.Size = new System.Drawing.Size(63, 20);
            this.brnaloga.TabIndex = 4;
            // 
            // dkdatuma
            // 
            this.dkdatuma.Location = new System.Drawing.Point(118, 42);
            this.dkdatuma.Name = "dkdatuma";
            this.dkdatuma.ReadOnly = true;
            this.dkdatuma.Size = new System.Drawing.Size(115, 20);
            this.dkdatuma.TabIndex = 5;
            // 
            // dpdatuma
            // 
            this.dpdatuma.Location = new System.Drawing.Point(118, 80);
            this.dpdatuma.Name = "dpdatuma";
            this.dpdatuma.ReadOnly = true;
            this.dpdatuma.Size = new System.Drawing.Size(115, 20);
            this.dpdatuma.TabIndex = 6;
            // 
            // dpovratka
            // 
            this.dpovratka.Location = new System.Drawing.Point(118, 123);
            this.dpovratka.Name = "dpovratka";
            this.dpovratka.ReadOnly = true;
            this.dpovratka.Size = new System.Drawing.Size(115, 20);
            this.dpovratka.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Polazište";
            // 
            // polaziste
            // 
            this.polaziste.Location = new System.Drawing.Point(118, 162);
            this.polaziste.Name = "polaziste";
            this.polaziste.ReadOnly = true;
            this.polaziste.Size = new System.Drawing.Size(115, 20);
            this.polaziste.TabIndex = 9;
            // 
            // odrediste
            // 
            this.odrediste.Location = new System.Drawing.Point(118, 205);
            this.odrediste.Name = "odrediste";
            this.odrediste.ReadOnly = true;
            this.odrediste.Size = new System.Drawing.Size(115, 20);
            this.odrediste.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Odredište:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nastavnik";
            // 
            // nastavnik
            // 
            this.nastavnik.Location = new System.Drawing.Point(491, 358);
            this.nastavnik.Name = "nastavnik";
            this.nastavnik.ReadOnly = true;
            this.nastavnik.Size = new System.Drawing.Size(100, 20);
            this.nastavnik.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.dkdatuma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dpdatuma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.odrediste);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dpovratka);
            this.groupBox1.Controls.Add(this.polaziste);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 248);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled osnovnih informacija o nalogu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnispisi
            // 
            this.btnispisi.Location = new System.Drawing.Point(130, 350);
            this.btnispisi.Name = "btnispisi";
            this.btnispisi.Size = new System.Drawing.Size(97, 39);
            this.btnispisi.TabIndex = 16;
            this.btnispisi.Text = "Ispiši nalog";
            this.btnispisi.UseVisualStyleBackColor = true;
            this.btnispisi.Visible = false;
            this.btnispisi.Click += new System.EventHandler(this.btnispisi_Click);
            // 
            // btnisplati
            // 
            this.btnisplati.Location = new System.Drawing.Point(127, 351);
            this.btnisplati.Name = "btnisplati";
            this.btnisplati.Size = new System.Drawing.Size(99, 37);
            this.btnisplati.TabIndex = 17;
            this.btnisplati.Text = "Isplati akontaciju";
            this.btnisplati.UseVisualStyleBackColor = true;
            this.btnisplati.Visible = false;
            this.btnisplati.Click += new System.EventHandler(this.btnisplati_Click);
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // putniNalogBindingSource
            // 
            this.putniNalogBindingSource.DataMember = "putniNalog";
            this.putniNalogBindingSource.DataSource = this.piDB1DataSet;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // formapregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.btnisplati);
            this.Controls.Add(this.btnispisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nastavnik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brnaloga);
            this.Controls.Add(this.label4);
            this.Name = "formapregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled naloga";
            this.Load += new System.EventHandler(this.formapregled_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brnaloga;
        private System.Windows.Forms.TextBox dkdatuma;
        private System.Windows.Forms.TextBox dpdatuma;
        private System.Windows.Forms.TextBox dpovratka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox polaziste;
        private System.Windows.Forms.TextBox odrediste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nastavnik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnispisi;
        private System.Windows.Forms.Button btnisplati;
        private Uprava.NET.piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        //private piDB1DataSet piDB1DataSet;
        //private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
    }
}