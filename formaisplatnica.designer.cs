namespace TIM18_racunovodstvo
{
    partial class formaisplatnica
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
            this.txtiznos = new System.Windows.Forms.TextBox();
            this.txtnastavnik = new System.Windows.Forms.TextBox();
            this.txtnalog = new System.Windows.Forms.TextBox();
            this.labelispl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmjesto = new System.Windows.Forms.TextBox();
            this.txtdan = new System.Windows.Forms.TextBox();
            this.labelupl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtiznos
            // 
            this.txtiznos.Location = new System.Drawing.Point(163, 95);
            this.txtiznos.Name = "txtiznos";
            this.txtiznos.Size = new System.Drawing.Size(227, 20);
            this.txtiznos.TabIndex = 0;
            // 
            // txtnastavnik
            // 
            this.txtnastavnik.Location = new System.Drawing.Point(163, 138);
            this.txtnastavnik.Name = "txtnastavnik";
            this.txtnastavnik.Size = new System.Drawing.Size(227, 20);
            this.txtnastavnik.TabIndex = 1;
            // 
            // txtnalog
            // 
            this.txtnalog.Location = new System.Drawing.Point(163, 192);
            this.txtnalog.Name = "txtnalog";
            this.txtnalog.Size = new System.Drawing.Size(227, 20);
            this.txtnalog.TabIndex = 2;
            // 
            // labelispl
            // 
            this.labelispl.AutoSize = true;
            this.labelispl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelispl.Location = new System.Drawing.Point(135, 13);
            this.labelispl.Name = "labelispl";
            this.labelispl.Size = new System.Drawing.Size(130, 31);
            this.labelispl.TabIndex = 3;
            this.labelispl.Text = "Isplatnica";
            this.labelispl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Na iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iznos isplaćen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temeljem putnog naloga br: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "U";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = ",dana";
            // 
            // txtmjesto
            // 
            this.txtmjesto.Location = new System.Drawing.Point(42, 242);
            this.txtmjesto.Name = "txtmjesto";
            this.txtmjesto.Size = new System.Drawing.Size(100, 20);
            this.txtmjesto.TabIndex = 9;
            // 
            // txtdan
            // 
            this.txtdan.Location = new System.Drawing.Point(200, 242);
            this.txtdan.Name = "txtdan";
            this.txtdan.Size = new System.Drawing.Size(190, 20);
            this.txtdan.TabIndex = 10;
            // 
            // labelupl
            // 
            this.labelupl.AutoSize = true;
            this.labelupl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelupl.Location = new System.Drawing.Point(135, 13);
            this.labelupl.Name = "labelupl";
            this.labelupl.Size = new System.Drawing.Size(128, 31);
            this.labelupl.TabIndex = 11;
            this.labelupl.Text = "Uplatnica";
            this.labelupl.Visible = false;
            // 
            // formaisplatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 326);
            this.Controls.Add(this.labelupl);
            this.Controls.Add(this.txtdan);
            this.Controls.Add(this.txtmjesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelispl);
            this.Controls.Add(this.txtnalog);
            this.Controls.Add(this.txtnastavnik);
            this.Controls.Add(this.txtiznos);
            this.Name = "formaisplatnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uplatnica/isplatnica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtiznos;
        private System.Windows.Forms.TextBox txtnastavnik;
        private System.Windows.Forms.TextBox txtnalog;
        private System.Windows.Forms.Label labelispl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmjesto;
        private System.Windows.Forms.TextBox txtdan;
        private System.Windows.Forms.Label labelupl;
    }
}