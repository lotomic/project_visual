namespace Uprava.NET
{
    partial class frmIzvjestajPutniNaloziDatum
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikaziNaloge = new System.Windows.Forms.Button();
            this.rpvNaloziDatum = new Microsoft.Reporting.WinForms.ReportViewer();
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            this.SuspendLayout();
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
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(108, 22);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(141, 20);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(346, 22);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(140, 20);
            this.dtpDateTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum do:";
            // 
            // btnPrikaziNaloge
            // 
            this.btnPrikaziNaloge.Location = new System.Drawing.Point(541, 19);
            this.btnPrikaziNaloge.Name = "btnPrikaziNaloge";
            this.btnPrikaziNaloge.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziNaloge.TabIndex = 4;
            this.btnPrikaziNaloge.Text = "Prikaži";
            this.btnPrikaziNaloge.UseVisualStyleBackColor = true;
            this.btnPrikaziNaloge.Click += new System.EventHandler(this.btnPrikaziNaloge_Click);
            // 
            // rpvNaloziDatum
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.putniNalogBindingSource;
            this.rpvNaloziDatum.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvNaloziDatum.LocalReport.ReportEmbeddedResource = "Uprava.NET.rptPutniNaloziPoDatumu.rdlc";
            this.rpvNaloziDatum.Location = new System.Drawing.Point(12, 59);
            this.rpvNaloziDatum.Name = "rpvNaloziDatum";
            this.rpvNaloziDatum.Size = new System.Drawing.Size(670, 455);
            this.rpvNaloziDatum.TabIndex = 5;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestajPutniNaloziDatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 526);
            this.Controls.Add(this.rpvNaloziDatum);
            this.Controls.Add(this.btnPrikaziNaloge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIzvjestajPutniNaloziDatum";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Putni nalozi \"od - do\"";
            this.Load += new System.EventHandler(this.frmIzvjestajPutniNaloziDatum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrikaziNaloge;
        private Microsoft.Reporting.WinForms.ReportViewer rpvNaloziDatum;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSet piDB1DataSet;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
    }
}