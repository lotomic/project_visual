namespace Uprava.NET
{
    partial class frmSviPutniNalozi
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
            this.rpvSviNalozi = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // rpvSviNalozi
            // 
            this.rpvSviNalozi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.putniNalogBindingSource;
            this.rpvSviNalozi.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvSviNalozi.LocalReport.ReportEmbeddedResource = "Uprava.NET.rptSviPutniNalozi.rdlc";
            this.rpvSviNalozi.Location = new System.Drawing.Point(0, 0);
            this.rpvSviNalozi.Name = "rpvSviNalozi";
            this.rpvSviNalozi.Size = new System.Drawing.Size(694, 526);
            this.rpvSviNalozi.TabIndex = 0;
            // 
            // putniNalogTableAdapter
            // 
            this.putniNalogTableAdapter.ClearBeforeFill = true;
            // 
            // frmSviPutniNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 526);
            this.Controls.Add(this.rpvSviNalozi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSviPutniNalozi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svi putni nalozi";
            this.Load += new System.EventHandler(this.frmSviPutniNalozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSviNalozi;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private piDB1DataSet piDB1DataSet;
        private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
    }
}