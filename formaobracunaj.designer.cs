namespace TIM18_racunovodstvo
{
    partial class formaobracunaj
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
            this.txtplatitelj = new System.Windows.Forms.TextBox();
            this.txtprimatelj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtiznos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdatum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtopis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtplatitelj
            // 
            this.txtplatitelj.Location = new System.Drawing.Point(22, 114);
            this.txtplatitelj.Multiline = true;
            this.txtplatitelj.Name = "txtplatitelj";
            this.txtplatitelj.Size = new System.Drawing.Size(271, 83);
            this.txtplatitelj.TabIndex = 0;
            // 
            // txtprimatelj
            // 
            this.txtprimatelj.Location = new System.Drawing.Point(22, 226);
            this.txtprimatelj.Multiline = true;
            this.txtprimatelj.Name = "txtprimatelj";
            this.txtprimatelj.Size = new System.Drawing.Size(271, 83);
            this.txtprimatelj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Platitelj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primatelj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iznos";
            // 
            // txtiznos
            // 
            this.txtiznos.Location = new System.Drawing.Point(373, 114);
            this.txtiznos.Name = "txtiznos";
            this.txtiznos.Size = new System.Drawing.Size(197, 20);
            this.txtiznos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj računa primatelja";
            // 
            // txtdatum
            // 
            this.txtdatum.Location = new System.Drawing.Point(22, 362);
            this.txtdatum.Name = "txtdatum";
            this.txtdatum.Size = new System.Drawing.Size(271, 20);
            this.txtdatum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum uplate/isplate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(177, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nalog za plaćanje";
            // 
            // txtopis
            // 
            this.txtopis.Location = new System.Drawing.Point(373, 226);
            this.txtopis.Multiline = true;
            this.txtopis.Name = "txtopis";
            this.txtopis.Size = new System.Drawing.Size(197, 83);
            this.txtopis.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Opis plaćanja";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(373, 177);
            this.maskedTextBox1.Mask = "9999999-9999999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(197, 20);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // formaobracunaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 429);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtopis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtiznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprimatelj);
            this.Controls.Add(this.txtplatitelj);
            this.Name = "formaobracunaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uplata/isplata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplatitelj;
        private System.Windows.Forms.TextBox txtprimatelj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtiznos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtopis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}