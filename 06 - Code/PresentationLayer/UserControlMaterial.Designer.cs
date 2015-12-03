namespace GestionMatosApplication
{
	partial class UserControlMaterial
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dgvMaterials = new System.Windows.Forms.DataGridView();
			this.nomDeMatérielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numéroDeSérieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientAssociéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.siteDeStockageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.batimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDeMatérielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDernièreInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.getMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gestionMatosDataSet1 = new GestionMatosApplication.GestionMatosDataSet1();
			this.label3 = new System.Windows.Forms.Label();
			this.materielTableAdapter1 = new GestionMatosApplication.GestionMatosDataSetTableAdapters.MaterielTableAdapter();
			this.getMaterialsTableAdapter = new GestionMatosApplication.GestionMatosDataSet1TableAdapters.GetMaterialsTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getMaterialsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.comboBox8);
			this.panel1.Controls.Add(this.comboBox7);
			this.panel1.Controls.Add(this.comboBox6);
			this.panel1.Controls.Add(this.comboBox5);
			this.panel1.Controls.Add(this.comboBox4);
			this.panel1.Controls.Add(this.comboBox3);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.dgvMaterials);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(786, 520);
			this.panel1.TabIndex = 0;
			// 
			// comboBox8
			// 
			this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(673, 30);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(89, 21);
			this.comboBox8.TabIndex = 16;
			// 
			// comboBox7
			// 
			this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(578, 30);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(89, 21);
			this.comboBox7.TabIndex = 15;
			// 
			// comboBox6
			// 
			this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(483, 30);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(89, 21);
			this.comboBox6.TabIndex = 14;
			// 
			// comboBox5
			// 
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(388, 30);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(89, 21);
			this.comboBox5.TabIndex = 13;
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(293, 30);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(89, 21);
			this.comboBox4.TabIndex = 12;
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(198, 30);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(89, 21);
			this.comboBox3.TabIndex = 11;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(103, 30);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(89, 21);
			this.comboBox2.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(8, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(89, 21);
			this.comboBox1.TabIndex = 9;
			// 
			// dgvMaterials
			// 
			this.dgvMaterials.AutoGenerateColumns = false;
			this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDeMatérielDataGridViewTextBoxColumn,
            this.numéroDeSérieDataGridViewTextBoxColumn,
            this.clientAssociéDataGridViewTextBoxColumn,
            this.siteDeStockageDataGridViewTextBoxColumn,
            this.batimentDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.salleDataGridViewTextBoxColumn,
            this.typeDeMatérielDataGridViewTextBoxColumn,
            this.dateDernièreInterventionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
			this.dgvMaterials.DataSource = this.getMaterialsBindingSource;
			this.dgvMaterials.Location = new System.Drawing.Point(3, 57);
			this.dgvMaterials.Name = "dgvMaterials";
			this.dgvMaterials.Size = new System.Drawing.Size(780, 460);
			this.dgvMaterials.TabIndex = 8;
			// 
			// nomDeMatérielDataGridViewTextBoxColumn
			// 
			this.nomDeMatérielDataGridViewTextBoxColumn.DataPropertyName = "Nom de Matériel";
			this.nomDeMatérielDataGridViewTextBoxColumn.HeaderText = "Nom de Matériel";
			this.nomDeMatérielDataGridViewTextBoxColumn.Name = "nomDeMatérielDataGridViewTextBoxColumn";
			// 
			// numéroDeSérieDataGridViewTextBoxColumn
			// 
			this.numéroDeSérieDataGridViewTextBoxColumn.DataPropertyName = "Numéro de Série";
			this.numéroDeSérieDataGridViewTextBoxColumn.HeaderText = "Numéro de Série";
			this.numéroDeSérieDataGridViewTextBoxColumn.Name = "numéroDeSérieDataGridViewTextBoxColumn";
			this.numéroDeSérieDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clientAssociéDataGridViewTextBoxColumn
			// 
			this.clientAssociéDataGridViewTextBoxColumn.DataPropertyName = "Client associé";
			this.clientAssociéDataGridViewTextBoxColumn.HeaderText = "Client associé";
			this.clientAssociéDataGridViewTextBoxColumn.Name = "clientAssociéDataGridViewTextBoxColumn";
			this.clientAssociéDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// siteDeStockageDataGridViewTextBoxColumn
			// 
			this.siteDeStockageDataGridViewTextBoxColumn.DataPropertyName = "Site de stockage";
			this.siteDeStockageDataGridViewTextBoxColumn.HeaderText = "Site de stockage";
			this.siteDeStockageDataGridViewTextBoxColumn.Name = "siteDeStockageDataGridViewTextBoxColumn";
			this.siteDeStockageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// batimentDataGridViewTextBoxColumn
			// 
			this.batimentDataGridViewTextBoxColumn.DataPropertyName = "Batiment";
			this.batimentDataGridViewTextBoxColumn.HeaderText = "Batiment";
			this.batimentDataGridViewTextBoxColumn.Name = "batimentDataGridViewTextBoxColumn";
			this.batimentDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// etageDataGridViewTextBoxColumn
			// 
			this.etageDataGridViewTextBoxColumn.DataPropertyName = "Etage";
			this.etageDataGridViewTextBoxColumn.HeaderText = "Etage";
			this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
			this.etageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// salleDataGridViewTextBoxColumn
			// 
			this.salleDataGridViewTextBoxColumn.DataPropertyName = "Salle";
			this.salleDataGridViewTextBoxColumn.HeaderText = "Salle";
			this.salleDataGridViewTextBoxColumn.Name = "salleDataGridViewTextBoxColumn";
			this.salleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// typeDeMatérielDataGridViewTextBoxColumn
			// 
			this.typeDeMatérielDataGridViewTextBoxColumn.DataPropertyName = "Type de matériel";
			this.typeDeMatérielDataGridViewTextBoxColumn.HeaderText = "Type de matériel";
			this.typeDeMatérielDataGridViewTextBoxColumn.Name = "typeDeMatérielDataGridViewTextBoxColumn";
			this.typeDeMatérielDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateDernièreInterventionDataGridViewTextBoxColumn
			// 
			this.dateDernièreInterventionDataGridViewTextBoxColumn.DataPropertyName = "Date dernière Intervention";
			this.dateDernièreInterventionDataGridViewTextBoxColumn.HeaderText = "Date dernière Intervention";
			this.dateDernièreInterventionDataGridViewTextBoxColumn.Name = "dateDernièreInterventionDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// getMaterialsBindingSource
			// 
			this.getMaterialsBindingSource.DataMember = "GetMaterials";
			this.getMaterialsBindingSource.DataSource = this.gestionMatosDataSet1;
			// 
			// gestionMatosDataSet1
			// 
			this.gestionMatosDataSet1.DataSetName = "GestionMatosDataSet1";
			this.gestionMatosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Liste des Matériels:";
			// 
			// materielTableAdapter1
			// 
			this.materielTableAdapter1.ClearBeforeFill = true;
			// 
			// getMaterialsTableAdapter
			// 
			this.getMaterialsTableAdapter.ClearBeforeFill = true;
			// 
			// UserControlMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "UserControlMaterial";
			this.Size = new System.Drawing.Size(792, 526);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getMaterialsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvMaterials;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDeMatérielDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numéroDeSérieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientAssociéDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn siteDeStockageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn batimentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDeMatérielDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDernièreInterventionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource getMaterialsBindingSource;
		private GestionMatosDataSet1 gestionMatosDataSet1;
		private GestionMatosDataSetTableAdapters.MaterielTableAdapter materielTableAdapter1;
		private GestionMatosDataSet1TableAdapters.GetMaterialsTableAdapter getMaterialsTableAdapter;
	}
}
