namespace TIM18_racunovodstvo
{
    partial class formaobracun
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
            this.label2 = new System.Windows.Forms.Label();
            this.labela3 = new System.Windows.Forms.Label();
            this.labela4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nalogbr = new System.Windows.Forms.TextBox();
            this.uktroskovi = new System.Windows.Forms.TextBox();
            this.akontacija = new System.Windows.Forms.TextBox();
            this.razlika = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obracunajtroskove = new System.Windows.Forms.Button();
            this.radiogotovina = new System.Windows.Forms.RadioButton();
            this.radioracun = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ukupni troškovi";
            // 
            // labela3
            // 
            this.labela3.AutoSize = true;
            this.labela3.Location = new System.Drawing.Point(24, 83);
            this.labela3.Name = "labela3";
            this.labela3.Size = new System.Drawing.Size(57, 13);
            this.labela3.TabIndex = 1;
            this.labela3.Text = "Akontacija";
            // 
            // labela4
            // 
            this.labela4.AutoSize = true;
            this.labela4.Location = new System.Drawing.Point(24, 129);
            this.labela4.Name = "labela4";
            this.labela4.Size = new System.Drawing.Size(42, 13);
            this.labela4.TabIndex = 2;
            this.labela4.Text = "Razlika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nalog br:";
            // 
            // nalogbr
            // 
            this.nalogbr.Location = new System.Drawing.Point(64, 25);
            this.nalogbr.Name = "nalogbr";
            this.nalogbr.ReadOnly = true;
            this.nalogbr.Size = new System.Drawing.Size(47, 20);
            this.nalogbr.TabIndex = 4;
            // 
            // uktroskovi
            // 
            this.uktroskovi.Location = new System.Drawing.Point(120, 39);
            this.uktroskovi.Name = "uktroskovi";
            this.uktroskovi.ReadOnly = true;
            this.uktroskovi.Size = new System.Drawing.Size(100, 20);
            this.uktroskovi.TabIndex = 5;
            // 
            // akontacija
            // 
            this.akontacija.Location = new System.Drawing.Point(120, 80);
            this.akontacija.Name = "akontacija";
            this.akontacija.ReadOnly = true;
            this.akontacija.Size = new System.Drawing.Size(100, 20);
            this.akontacija.TabIndex = 6;
            // 
            // razlika
            // 
            this.razlika.Location = new System.Drawing.Point(120, 126);
            this.razlika.Name = "razlika";
            this.razlika.ReadOnly = true;
            this.razlika.Size = new System.Drawing.Size(100, 20);
            this.razlika.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.uktroskovi);
            this.groupBox1.Controls.Add(this.razlika);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.akontacija);
            this.groupBox1.Controls.Add(this.labela3);
            this.groupBox1.Controls.Add(this.labela4);
            this.groupBox1.Location = new System.Drawing.Point(21, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o troškovima";
            // 
            // obracunajtroskove
            // 
            this.obracunajtroskove.Location = new System.Drawing.Point(313, 296);
            this.obracunajtroskove.Name = "obracunajtroskove";
            this.obracunajtroskove.Size = new System.Drawing.Size(75, 23);
            this.obracunajtroskove.TabIndex = 9;
            this.obracunajtroskove.Text = "Obračunaj";
            this.obracunajtroskove.UseVisualStyleBackColor = true;
            this.obracunajtroskove.Click += new System.EventHandler(this.obracunajtroskove_Click);
            // 
            // radiogotovina
            // 
            this.radiogotovina.AutoSize = true;
            this.radiogotovina.Checked = true;
            this.radiogotovina.Location = new System.Drawing.Point(346, 203);
            this.radiogotovina.Name = "radiogotovina";
            this.radiogotovina.Size = new System.Drawing.Size(68, 17);
            this.radiogotovina.TabIndex = 10;
            this.radiogotovina.TabStop = true;
            this.radiogotovina.Text = "Gotovina";
            this.radiogotovina.UseVisualStyleBackColor = true;
            // 
            // radioracun
            // 
            this.radioracun.AutoSize = true;
            this.radioracun.Location = new System.Drawing.Point(346, 242);
            this.radioracun.Name = "radioracun";
            this.radioracun.Size = new System.Drawing.Size(88, 17);
            this.radioracun.TabIndex = 11;
            this.radioracun.TabStop = true;
            this.radioracun.Text = "Tekući račun";
            this.radioracun.UseVisualStyleBackColor = true;
            // 
            // formaobracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 341);
            this.Controls.Add(this.radioracun);
            this.Controls.Add(this.radiogotovina);
            this.Controls.Add(this.obracunajtroskove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nalogbr);
            this.Controls.Add(this.label1);
            this.Name = "formaobracun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obračun troškova";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labela3;
        private System.Windows.Forms.Label labela4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nalogbr;
        private System.Windows.Forms.TextBox uktroskovi;
        private System.Windows.Forms.TextBox akontacija;
        private System.Windows.Forms.TextBox razlika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obracunajtroskove;
        private System.Windows.Forms.RadioButton radiogotovina;
        private System.Windows.Forms.RadioButton radioracun;
    }
}