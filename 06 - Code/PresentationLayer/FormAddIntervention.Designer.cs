namespace GestionMatosApplication
{
	partial class FormAddIntervention
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbMaterial = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dateLimitIntervention = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.txbMTBF = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbDesc = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dateIntervention = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMaterialType = new System.Windows.Forms.ComboBox();
			this.cmbClientName = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.cmbMaterial);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dateLimitIntervention);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txbMTBF);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txbDesc);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dateIntervention);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmbMaterialType);
			this.panel1.Controls.Add(this.cmbClientName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(443, 384);
			this.panel1.TabIndex = 1;
			// 
			// cmbMaterial
			// 
			this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMaterial.FormattingEnabled = true;
			this.cmbMaterial.Location = new System.Drawing.Point(121, 108);
			this.cmbMaterial.Name = "cmbMaterial";
			this.cmbMaterial.Size = new System.Drawing.Size(310, 21);
			this.cmbMaterial.TabIndex = 36;
			this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(4, 212);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 35;
			this.label11.Text = "limite:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 184);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "plannifiée:";
			// 
			// dateLimitIntervention
			// 
			this.dateLimitIntervention.Location = new System.Drawing.Point(121, 199);
			this.dateLimitIntervention.Name = "dateLimitIntervention";
			this.dateLimitIntervention.Size = new System.Drawing.Size(206, 20);
			this.dateLimitIntervention.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 199);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "Date d\'intervention";
			// 
			// txbMTBF
			// 
			this.txbMTBF.Location = new System.Drawing.Point(121, 135);
			this.txbMTBF.Name = "txbMTBF";
			this.txbMTBF.ReadOnly = true;
			this.txbMTBF.Size = new System.Drawing.Size(291, 20);
			this.txbMTBF.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "MTBF:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Nom du Materiel:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 225);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Description:";
			// 
			// txbDesc
			// 
			this.txbDesc.Location = new System.Drawing.Point(121, 225);
			this.txbDesc.Multiline = true;
			this.txbDesc.Name = "txbDesc";
			this.txbDesc.Size = new System.Drawing.Size(310, 117);
			this.txbDesc.TabIndex = 14;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(275, 348);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Ajouter";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(356, 348);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Date d\'intervention";
			// 
			// dateIntervention
			// 
			this.dateIntervention.Location = new System.Drawing.Point(121, 171);
			this.dateIntervention.Name = "dateIntervention";
			this.dateIntervention.Size = new System.Drawing.Size(206, 20);
			this.dateIntervention.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(2, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(238, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ajout d\'une intervention";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Type de Matériel:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nom du Client:";
			// 
			// cmbMaterialType
			// 
			this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMaterialType.FormattingEnabled = true;
			this.cmbMaterialType.Location = new System.Drawing.Point(121, 81);
			this.cmbMaterialType.Name = "cmbMaterialType";
			this.cmbMaterialType.Size = new System.Drawing.Size(310, 21);
			this.cmbMaterialType.TabIndex = 1;
			this.cmbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialType_SelectedIndexChanged);
			// 
			// cmbClientName
			// 
			this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientName.FormattingEnabled = true;
			this.cmbClientName.Location = new System.Drawing.Point(121, 51);
			this.cmbClientName.Name = "cmbClientName";
			this.cmbClientName.Size = new System.Drawing.Size(310, 21);
			this.cmbClientName.TabIndex = 0;
			this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
			// 
			// FormAddIntervention
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 400);
			this.Controls.Add(this.panel1);
			this.Name = "FormAddIntervention";
			this.Text = "FormAddIntervention";
			this.Load += new System.EventHandler(this.FormAddIntervention_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cmbMaterial;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateLimitIntervention;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txbMTBF;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbDesc;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateIntervention;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMaterialType;
		private System.Windows.Forms.ComboBox cmbClientName;
	}
}