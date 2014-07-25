namespace TIM18_racunovodstvo
{
    partial class formaknjizenje
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
            this.dgvknjizenje = new System.Windows.Forms.DataGridView();
            this.nalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_knjizenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis_knjizenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duguje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrazuje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_konta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piDB1DataSet = new Uprava.NET.piDB1DataSet();
            this.troskovikontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troskovi_kontoTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.troskovi_kontoTableAdapter();
            this.putniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTableAdapter = new Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvknjizenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskovikontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvknjizenje
            // 
            this.dgvknjizenje.AllowUserToAddRows = false;
            this.dgvknjizenje.AllowUserToDeleteRows = false;
            this.dgvknjizenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvknjizenje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nalog,
            this.datum_knjizenja,
            this.opis_knjizenja,
            this.duguje,
            this.potrazuje,
            this.broj_konta});
            this.dgvknjizenje.Location = new System.Drawing.Point(25, 32);
            this.dgvknjizenje.Name = "dgvknjizenje";
            this.dgvknjizenje.ReadOnly = true;
            this.dgvknjizenje.Size = new System.Drawing.Size(844, 448);
            this.dgvknjizenje.TabIndex = 0;
            // 
            // nalog
            // 
            this.nalog.HeaderText = "Broj naloga";
            this.nalog.Name = "nalog";
            this.nalog.ReadOnly = true;
            // 
            // datum_knjizenja
            // 
            this.datum_knjizenja.HeaderText = "Datum";
            this.datum_knjizenja.Name = "datum_knjizenja";
            this.datum_knjizenja.ReadOnly = true;
            // 
            // opis_knjizenja
            // 
            this.opis_knjizenja.HeaderText = "Opis";
            this.opis_knjizenja.Name = "opis_knjizenja";
            this.opis_knjizenja.ReadOnly = true;
            this.opis_knjizenja.Width = 300;
            // 
            // duguje
            // 
            this.duguje.HeaderText = "Duguje";
            this.duguje.Name = "duguje";
            this.duguje.ReadOnly = true;
            // 
            // potrazuje
            // 
            this.potrazuje.HeaderText = "Potražuje";
            this.potrazuje.Name = "potrazuje";
            this.potrazuje.ReadOnly = true;
            // 
            // broj_konta
            // 
            this.broj_konta.HeaderText = "Broj konta";
            this.broj_konta.Name = "broj_konta";
            this.broj_konta.ReadOnly = true;
            // 
            // piDB1DataSet
            // 
            this.piDB1DataSet.DataSetName = "piDB1DataSet";
            this.piDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // troskovikontoBindingSource
            // 
            this.troskovikontoBindingSource.DataMember = "troskovi_konto";
            this.troskovikontoBindingSource.DataSource = this.piDB1DataSet;
            // 
            // troskovi_kontoTableAdapter
            // 
            this.troskovi_kontoTableAdapter.ClearBeforeFill = true;
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
            // formaknjizenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 492);
            this.Controls.Add(this.dgvknjizenje);
            this.Name = "formaknjizenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proknjiženo";
            this.Load += new System.EventHandler(this.formaknjizenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvknjizenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskovikontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvknjizenje;
        //private piDB1DataSet piDB1DataSet;
        //private piDB1DataSetTableAdapters.troskovi_kontoTableAdapter troskovi_kontoTableAdapter;
        //private piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_knjizenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis_knjizenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn duguje;
        private System.Windows.Forms.DataGridViewTextBoxColumn potrazuje;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_konta;
        private Uprava.NET.piDB1DataSet piDB1DataSet;
        private System.Windows.Forms.BindingSource troskovikontoBindingSource;
        private Uprava.NET.piDB1DataSetTableAdapters.troskovi_kontoTableAdapter troskovi_kontoTableAdapter;
        private System.Windows.Forms.BindingSource putniNalogBindingSource;
        private Uprava.NET.piDB1DataSetTableAdapters.putniNalogTableAdapter putniNalogTableAdapter;

    }
}