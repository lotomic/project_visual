namespace Uprava.NET
{
    partial class frmEvidencijaAuta
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
            this.dgwEvidencijaAuta = new System.Windows.Forms.DataGridView();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regOznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odredište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piDB1DataSet_tim17 = new Uprava.NET.piDB1DataSet_tim17();
            this.raspolozivostAutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspolozivostAutaTableAdapter = new Uprava.NET.piDB1DataSet_tim17TableAdapters.RaspolozivostAutaTableAdapter();
            this.idvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnalogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePovratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvidencijaAuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet_tim17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspolozivostAutaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEvidencijaAuta
            // 
            this.dgwEvidencijaAuta.AllowUserToAddRows = false;
            this.dgwEvidencijaAuta.AllowUserToDeleteRows = false;
            this.dgwEvidencijaAuta.AutoGenerateColumns = false;
            this.dgwEvidencijaAuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEvidencijaAuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marka,
            this.regOznaka,
            this.Odredište,
            this.idvozilaDataGridViewTextBoxColumn,
            this.idnalogaDataGridViewTextBoxColumn,
            this.vrijemePolaskaDataGridViewTextBoxColumn,
            this.vrijemePovratkaDataGridViewTextBoxColumn,
            this.odredisteDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.regOznakaDataGridViewTextBoxColumn});
            this.dgwEvidencijaAuta.DataSource = this.raspolozivostAutaBindingSource;
            this.dgwEvidencijaAuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwEvidencijaAuta.Location = new System.Drawing.Point(0, 0);
            this.dgwEvidencijaAuta.Name = "dgwEvidencijaAuta";
            this.dgwEvidencijaAuta.ReadOnly = true;
            this.dgwEvidencijaAuta.RowTemplate.Height = 24;
            this.dgwEvidencijaAuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEvidencijaAuta.Size = new System.Drawing.Size(477, 248);
            this.dgwEvidencijaAuta.TabIndex = 0;
            this.dgwEvidencijaAuta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEvidencijaAuta_CellContentClick);
            // 
            // marka
            // 
            this.marka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "marka";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
            this.marka.Width = 61;
            // 
            // regOznaka
            // 
            this.regOznaka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.regOznaka.DataPropertyName = "regOznaka";
            this.regOznaka.HeaderText = "regOznaka";
            this.regOznaka.Name = "regOznaka";
            this.regOznaka.ReadOnly = true;
            this.regOznaka.Width = 84;
            // 
            // Odredište
            // 
            this.Odredište.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Odredište.DataPropertyName = "odrediste";
            this.Odredište.HeaderText = "Odredište";
            this.Odredište.Name = "Odredište";
            this.Odredište.ReadOnly = true;
            this.Odredište.Width = 77;
            // 
            // piDB1DataSet_tim17
            // 
            this.piDB1DataSet_tim17.DataSetName = "piDB1DataSet_tim17";
            this.piDB1DataSet_tim17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspolozivostAutaBindingSource
            // 
            this.raspolozivostAutaBindingSource.DataMember = "RaspolozivostAuta";
            this.raspolozivostAutaBindingSource.DataSource = this.piDB1DataSet_tim17;
            // 
            // raspolozivostAutaTableAdapter
            // 
            this.raspolozivostAutaTableAdapter.ClearBeforeFill = true;
            // 
            // idvozilaDataGridViewTextBoxColumn
            // 
            this.idvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_vozila";
            this.idvozilaDataGridViewTextBoxColumn.HeaderText = "id_vozila";
            this.idvozilaDataGridViewTextBoxColumn.Name = "idvozilaDataGridViewTextBoxColumn";
            this.idvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idnalogaDataGridViewTextBoxColumn
            // 
            this.idnalogaDataGridViewTextBoxColumn.DataPropertyName = "id_naloga";
            this.idnalogaDataGridViewTextBoxColumn.HeaderText = "id_naloga";
            this.idnalogaDataGridViewTextBoxColumn.Name = "idnalogaDataGridViewTextBoxColumn";
            this.idnalogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemePolaskaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.HeaderText = "vrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.Name = "vrijemePolaskaDataGridViewTextBoxColumn";
            this.vrijemePolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePovratkaDataGridViewTextBoxColumn
            // 
            this.vrijemePovratkaDataGridViewTextBoxColumn.DataPropertyName = "vrijemePovratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.HeaderText = "vrijemePovratka";
            this.vrijemePovratkaDataGridViewTextBoxColumn.Name = "vrijemePovratkaDataGridViewTextBoxColumn";
            this.vrijemePovratkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regOznakaDataGridViewTextBoxColumn
            // 
            this.regOznakaDataGridViewTextBoxColumn.DataPropertyName = "regOznaka";
            this.regOznakaDataGridViewTextBoxColumn.HeaderText = "regOznaka";
            this.regOznakaDataGridViewTextBoxColumn.Name = "regOznakaDataGridViewTextBoxColumn";
            this.regOznakaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmEvidencijaAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 248);
            this.Controls.Add(this.dgwEvidencijaAuta);
            this.Name = "frmEvidencijaAuta";
            this.Text = "frmEvidencijaAuta";
            this.Load += new System.EventHandler(this.frmEvidencijaAuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvidencijaAuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB1DataSet_tim17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspolozivostAutaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEvidencijaAuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn regOznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odredište;
        private Uprava.NET.piDB1DataSet_tim17 piDB1DataSet_tim17;
        private System.Windows.Forms.BindingSource raspolozivostAutaBindingSource;
        private Uprava.NET.piDB1DataSet_tim17TableAdapters.RaspolozivostAutaTableAdapter raspolozivostAutaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnalogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePovratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regOznakaDataGridViewTextBoxColumn;


    }
}