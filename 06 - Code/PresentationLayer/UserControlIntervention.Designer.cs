namespace GestionMatosApplication
{
	partial class UserControlIntervention
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
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gestionMatosIntervention = new GestionMatosApplication.GestionMatosIntervention();
			this.interventionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.interventionTableAdapter = new GestionMatosApplication.GestionMatosInterventionTableAdapters.InterventionTableAdapter();
			this.idInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateInterventionPlanifieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateInterventionRealiseeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentaireInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusInterventionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestionMatosIntervention)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(258, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Liste des Interventions:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInterventionDataGridViewTextBoxColumn,
            this.idMaterielDataGridViewTextBoxColumn,
            this.dateInterventionPlanifieDataGridViewTextBoxColumn,
            this.dateInterventionRealiseeDataGridViewTextBoxColumn,
            this.commentaireInterventionDataGridViewTextBoxColumn,
            this.statusInterventionDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.interventionBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(8, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(801, 551);
			this.dataGridView1.TabIndex = 7;
			// 
			// gestionMatosIntervention
			// 
			this.gestionMatosIntervention.DataSetName = "GestionMatosIntervention";
			this.gestionMatosIntervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// interventionBindingSource
			// 
			this.interventionBindingSource.DataMember = "Intervention";
			this.interventionBindingSource.DataSource = this.gestionMatosIntervention;
			// 
			// interventionTableAdapter
			// 
			this.interventionTableAdapter.ClearBeforeFill = true;
			// 
			// idInterventionDataGridViewTextBoxColumn
			// 
			this.idInterventionDataGridViewTextBoxColumn.DataPropertyName = "id_Intervention";
			this.idInterventionDataGridViewTextBoxColumn.HeaderText = "id_Intervention";
			this.idInterventionDataGridViewTextBoxColumn.Name = "idInterventionDataGridViewTextBoxColumn";
			this.idInterventionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idMaterielDataGridViewTextBoxColumn
			// 
			this.idMaterielDataGridViewTextBoxColumn.DataPropertyName = "id_Materiel";
			this.idMaterielDataGridViewTextBoxColumn.HeaderText = "id_Materiel";
			this.idMaterielDataGridViewTextBoxColumn.Name = "idMaterielDataGridViewTextBoxColumn";
			// 
			// dateInterventionPlanifieDataGridViewTextBoxColumn
			// 
			this.dateInterventionPlanifieDataGridViewTextBoxColumn.DataPropertyName = "date_InterventionPlanifie";
			this.dateInterventionPlanifieDataGridViewTextBoxColumn.HeaderText = "date_InterventionPlanifie";
			this.dateInterventionPlanifieDataGridViewTextBoxColumn.Name = "dateInterventionPlanifieDataGridViewTextBoxColumn";
			// 
			// dateInterventionRealiseeDataGridViewTextBoxColumn
			// 
			this.dateInterventionRealiseeDataGridViewTextBoxColumn.DataPropertyName = "date_InterventionRealisee";
			this.dateInterventionRealiseeDataGridViewTextBoxColumn.HeaderText = "date_InterventionRealisee";
			this.dateInterventionRealiseeDataGridViewTextBoxColumn.Name = "dateInterventionRealiseeDataGridViewTextBoxColumn";
			// 
			// commentaireInterventionDataGridViewTextBoxColumn
			// 
			this.commentaireInterventionDataGridViewTextBoxColumn.DataPropertyName = "commentaire_Intervention";
			this.commentaireInterventionDataGridViewTextBoxColumn.HeaderText = "commentaire_Intervention";
			this.commentaireInterventionDataGridViewTextBoxColumn.Name = "commentaireInterventionDataGridViewTextBoxColumn";
			// 
			// statusInterventionDataGridViewCheckBoxColumn
			// 
			this.statusInterventionDataGridViewCheckBoxColumn.DataPropertyName = "status_Intervention";
			this.statusInterventionDataGridViewCheckBoxColumn.HeaderText = "status_Intervention";
			this.statusInterventionDataGridViewCheckBoxColumn.Name = "statusInterventionDataGridViewCheckBoxColumn";
			// 
			// UserControlIntervention
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Name = "UserControlIntervention";
			this.Size = new System.Drawing.Size(812, 582);
			this.Load += new System.EventHandler(this.UserControlIntervention_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gestionMatosIntervention)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idInterventionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idMaterielDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateInterventionPlanifieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateInterventionRealiseeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentaireInterventionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn statusInterventionDataGridViewCheckBoxColumn;
		private System.Windows.Forms.BindingSource interventionBindingSource;
		private GestionMatosIntervention gestionMatosIntervention;
		private GestionMatosInterventionTableAdapters.InterventionTableAdapter interventionTableAdapter;
	}
}
