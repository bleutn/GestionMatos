namespace GestionMatosApplication
{
    partial class FormAddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomClientTextBox = new System.Windows.Forms.TextBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionMatosDataSet = new GestionMatosApplication.GestionMatosDataSet();
            this.siteTableAdapter = new GestionMatosApplication.GestionMatosDataSetTableAdapters.SiteTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ClientAddButton = new System.Windows.Forms.Button();
            this.batimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batimentTableAdapter = new GestionMatosApplication.GestionMatosDataSetTableAdapters.BatimentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batimentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un nouveau client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de client:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomClientTextBox
            // 
            this.NomClientTextBox.Location = new System.Drawing.Point(102, 76);
            this.NomClientTextBox.Name = "NomClientTextBox";
            this.NomClientTextBox.Size = new System.Drawing.Size(190, 20);
            this.NomClientTextBox.TabIndex = 5;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.gestionMatosDataSet;
            // 
            // gestionMatosDataSet
            // 
            this.gestionMatosDataSet.DataSetName = "GestionMatosDataSet";
            this.gestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // ClientAddButton
            // 
            this.ClientAddButton.Location = new System.Drawing.Point(131, 138);
            this.ClientAddButton.Name = "ClientAddButton";
            this.ClientAddButton.Size = new System.Drawing.Size(75, 23);
            this.ClientAddButton.TabIndex = 9;
            this.ClientAddButton.Text = "Ajouter";
            this.ClientAddButton.UseVisualStyleBackColor = true;
            this.ClientAddButton.Click += new System.EventHandler(this.ClientAddButton_Click);
            // 
            // batimentBindingSource
            // 
            this.batimentBindingSource.DataMember = "Batiment";
            this.batimentBindingSource.DataSource = this.gestionMatosDataSet;
            // 
            // batimentTableAdapter
            // 
            this.batimentTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 184);
            this.Controls.Add(this.ClientAddButton);
            this.Controls.Add(this.NomClientTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddClient";
            this.Text = "Ajout de client";
            this.Load += new System.EventHandler(this.FormAddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batimentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomClientTextBox;
        private GestionMatosDataSet gestionMatosDataSet;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private GestionMatosDataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ClientAddButton;
        private System.Windows.Forms.BindingSource batimentBindingSource;
        private GestionMatosDataSetTableAdapters.BatimentTableAdapter batimentTableAdapter;
    }
}