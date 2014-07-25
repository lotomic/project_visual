namespace Uprava.NET
{
    partial class frmUnosIzvjesca
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
            this.txtIzvjesce = new System.Windows.Forms.TextBox();
            this.lblUnesiteIzvjesce = new System.Windows.Forms.Label();
            this.btnUnesiIzvjesce = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new Uprava.NET.piDB1DataSetTableAdapters.QueriesTableAdapter();
            this.SuspendLayout();
            // 
            // txtIzvjesce
            // 
            this.txtIzvjesce.Location = new System.Drawing.Point(13, 52);
            this.txtIzvjesce.Multiline = true;
            this.txtIzvjesce.Name = "txtIzvjesce";
            this.txtIzvjesce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIzvjesce.Size = new System.Drawing.Size(428, 172);
            this.txtIzvjesce.TabIndex = 0;
            // 
            // lblUnesiteIzvjesce
            // 
            this.lblUnesiteIzvjesce.AutoSize = true;
            this.lblUnesiteIzvjesce.Location = new System.Drawing.Point(13, 27);
            this.lblUnesiteIzvjesce.Name = "lblUnesiteIzvjesce";
            this.lblUnesiteIzvjesce.Size = new System.Drawing.Size(145, 13);
            this.lblUnesiteIzvjesce.TabIndex = 1;
            this.lblUnesiteIzvjesce.Text = "Unesite izvješće s putovanja:";
            // 
            // btnUnesiIzvjesce
            // 
            this.btnUnesiIzvjesce.Location = new System.Drawing.Point(257, 247);
            this.btnUnesiIzvjesce.Name = "btnUnesiIzvjesce";
            this.btnUnesiIzvjesce.Size = new System.Drawing.Size(92, 23);
            this.btnUnesiIzvjesce.TabIndex = 2;
            this.btnUnesiIzvjesce.Text = "Unesi izvješće";
            this.btnUnesiIzvjesce.UseVisualStyleBackColor = true;
            this.btnUnesiIzvjesce.Click += new System.EventHandler(this.btnUnesiIzvjesce_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(366, 247);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmUnosIzvjesca
            // 
            this.AcceptButton = this.btnUnesiIzvjesce;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnesiIzvjesce);
            this.Controls.Add(this.lblUnesiteIzvjesce);
            this.Controls.Add(this.txtIzvjesce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUnosIzvjesca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos izvješća s putovanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzvjesce;
        private System.Windows.Forms.Label lblUnesiteIzvjesce;
        private System.Windows.Forms.Button btnUnesiIzvjesce;
        private System.Windows.Forms.Button btnOdustani;
        private piDB1DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}