namespace GestionMatosApplication
{
    partial class ClientHomepage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClientListe = new System.Windows.Forms.ComboBox();
            this.gestionMatosDataSet = new GestionMatosApplication.GestionMatosDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionMatosApplication.GestionMatosDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientListe
            // 
            this.ClientListe.DataSource = this.clientBindingSource;
            this.ClientListe.DisplayMember = "nom_Client";
            this.ClientListe.FormattingEnabled = true;
            this.ClientListe.Location = new System.Drawing.Point(85, 86);
            this.ClientListe.Name = "ClientListe";
            this.ClientListe.Size = new System.Drawing.Size(121, 21);
            this.ClientListe.TabIndex = 0;
            this.ClientListe.ValueMember = "id_Client";
            // 
            // gestionMatosDataSet
            // 
            this.gestionMatosDataSet.DataSetName = "GestionMatosDataSet";
            this.gestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gestionMatosDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ClientHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClientListe);
            this.Name = "ClientHomepage";
            this.Size = new System.Drawing.Size(287, 241);
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientListe;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GestionMatosDataSet gestionMatosDataSet;
        private GestionMatosDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}
