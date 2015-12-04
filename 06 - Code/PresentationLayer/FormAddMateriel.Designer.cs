namespace GestionMatosApplication
{
    partial class FormAddMateriel
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
			this.btnAddSalle = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbSalle = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddEtage = new System.Windows.Forms.Button();
			this.cmbEtage = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnAddBatiment = new System.Windows.Forms.Button();
			this.cmbBatiment = new System.Windows.Forms.ComboBox();
			this.lblBatiment = new System.Windows.Forms.Label();
			this.dateLimitIntervention = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.txbMTBF = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txbMaterialName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbDesc = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dateIntervention = new System.Windows.Forms.DateTimePicker();
			this.btnAddSite = new System.Windows.Forms.Button();
			this.cmbSite = new System.Windows.Forms.ComboBox();
			this.btnAddMaterialType = new System.Windows.Forms.Button();
			this.btnAddClient = new System.Windows.Forms.Button();
			this.lblSite = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMaterialType = new System.Windows.Forms.ComboBox();
			this.cmbClientName = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.btnAddSalle);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.cmbSalle);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnAddEtage);
			this.panel1.Controls.Add(this.cmbEtage);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.btnAddBatiment);
			this.panel1.Controls.Add(this.cmbBatiment);
			this.panel1.Controls.Add(this.lblBatiment);
			this.panel1.Controls.Add(this.dateLimitIntervention);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txbMTBF);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txbMaterialName);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txbDesc);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dateIntervention);
			this.panel1.Controls.Add(this.btnAddSite);
			this.panel1.Controls.Add(this.cmbSite);
			this.panel1.Controls.Add(this.btnAddMaterialType);
			this.panel1.Controls.Add(this.btnAddClient);
			this.panel1.Controls.Add(this.lblSite);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmbMaterialType);
			this.panel1.Controls.Add(this.cmbClientName);
			this.panel1.Location = new System.Drawing.Point(12, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(577, 527);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnAddSalle
			// 
			this.btnAddSalle.Location = new System.Drawing.Point(437, 224);
			this.btnAddSalle.Name = "btnAddSalle";
			this.btnAddSalle.Size = new System.Drawing.Size(137, 23);
			this.btnAddSalle.TabIndex = 36;
			this.btnAddSalle.Text = "Ajout Salle";
			this.btnAddSalle.UseVisualStyleBackColor = true;
			this.btnAddSalle.Click += new System.EventHandler(this.btnAddSalle_Click_1);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(4, 318);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 35;
			this.label11.Text = "limite:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 290);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "plannifiée:";
			// 
			// cmbSalle
			// 
			this.cmbSalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSalle.FormattingEnabled = true;
			this.cmbSalle.Location = new System.Drawing.Point(121, 224);
			this.cmbSalle.Name = "cmbSalle";
			this.cmbSalle.Size = new System.Drawing.Size(310, 21);
			this.cmbSalle.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 31;
			this.label4.Text = "Salle:";
			// 
			// btnAddEtage
			// 
			this.btnAddEtage.Location = new System.Drawing.Point(437, 195);
			this.btnAddEtage.Name = "btnAddEtage";
			this.btnAddEtage.Size = new System.Drawing.Size(137, 23);
			this.btnAddEtage.TabIndex = 30;
			this.btnAddEtage.Text = "Ajout Etage";
			this.btnAddEtage.UseVisualStyleBackColor = true;
			this.btnAddEtage.Click += new System.EventHandler(this.btnAddEtage_Click_1);
			// 
			// cmbEtage
			// 
			this.cmbEtage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEtage.FormattingEnabled = true;
			this.cmbEtage.Location = new System.Drawing.Point(121, 195);
			this.cmbEtage.Name = "cmbEtage";
			this.cmbEtage.Size = new System.Drawing.Size(310, 21);
			this.cmbEtage.TabIndex = 29;
			this.cmbEtage.SelectedIndexChanged += new System.EventHandler(this.cmbEtage_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(4, 198);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Etage:";
			// 
			// btnAddBatiment
			// 
			this.btnAddBatiment.Location = new System.Drawing.Point(437, 166);
			this.btnAddBatiment.Name = "btnAddBatiment";
			this.btnAddBatiment.Size = new System.Drawing.Size(137, 23);
			this.btnAddBatiment.TabIndex = 27;
			this.btnAddBatiment.Text = "Ajout Batiment";
			this.btnAddBatiment.UseVisualStyleBackColor = true;
			this.btnAddBatiment.Click += new System.EventHandler(this.btnAddBatiment_Click);
			// 
			// cmbBatiment
			// 
			this.cmbBatiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBatiment.FormattingEnabled = true;
			this.cmbBatiment.Location = new System.Drawing.Point(121, 166);
			this.cmbBatiment.Name = "cmbBatiment";
			this.cmbBatiment.Size = new System.Drawing.Size(310, 21);
			this.cmbBatiment.TabIndex = 26;
			this.cmbBatiment.SelectedIndexChanged += new System.EventHandler(this.cmbBatiment_SelectedIndexChanged);
			// 
			// lblBatiment
			// 
			this.lblBatiment.AutoSize = true;
			this.lblBatiment.Location = new System.Drawing.Point(4, 169);
			this.lblBatiment.Name = "lblBatiment";
			this.lblBatiment.Size = new System.Drawing.Size(51, 13);
			this.lblBatiment.TabIndex = 25;
			this.lblBatiment.Text = "Batiment:";
			// 
			// dateLimitIntervention
			// 
			this.dateLimitIntervention.Location = new System.Drawing.Point(121, 305);
			this.dateLimitIntervention.Name = "dateLimitIntervention";
			this.dateLimitIntervention.Size = new System.Drawing.Size(206, 20);
			this.dateLimitIntervention.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 305);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "Date d\'intervention";
			// 
			// txbMTBF
			// 
			this.txbMTBF.Location = new System.Drawing.Point(121, 251);
			this.txbMTBF.Name = "txbMTBF";
			this.txbMTBF.ReadOnly = true;
			this.txbMTBF.Size = new System.Drawing.Size(291, 20);
			this.txbMTBF.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 254);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "MTBF:";
			// 
			// txbMaterialName
			// 
			this.txbMaterialName.Location = new System.Drawing.Point(121, 50);
			this.txbMaterialName.Name = "txbMaterialName";
			this.txbMaterialName.Size = new System.Drawing.Size(310, 20);
			this.txbMaterialName.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Nom du Materiel:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 331);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Description:";
			// 
			// txbDesc
			// 
			this.txbDesc.Location = new System.Drawing.Point(121, 331);
			this.txbDesc.Multiline = true;
			this.txbDesc.Name = "txbDesc";
			this.txbDesc.Size = new System.Drawing.Size(310, 117);
			this.txbDesc.TabIndex = 14;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(418, 501);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Ajouter";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(499, 501);
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
			this.label5.Location = new System.Drawing.Point(4, 277);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Date d\'intervention";
			// 
			// dateIntervention
			// 
			this.dateIntervention.Location = new System.Drawing.Point(121, 277);
			this.dateIntervention.Name = "dateIntervention";
			this.dateIntervention.Size = new System.Drawing.Size(206, 20);
			this.dateIntervention.TabIndex = 10;
			// 
			// btnAddSite
			// 
			this.btnAddSite.Location = new System.Drawing.Point(437, 137);
			this.btnAddSite.Name = "btnAddSite";
			this.btnAddSite.Size = new System.Drawing.Size(137, 23);
			this.btnAddSite.TabIndex = 9;
			this.btnAddSite.Text = "Ajout Site";
			this.btnAddSite.UseVisualStyleBackColor = true;
			this.btnAddSite.Click += new System.EventHandler(this.btnAddEtage_Click);
			// 
			// cmbSite
			// 
			this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSite.FormattingEnabled = true;
			this.cmbSite.Location = new System.Drawing.Point(121, 137);
			this.cmbSite.Name = "cmbSite";
			this.cmbSite.Size = new System.Drawing.Size(310, 21);
			this.cmbSite.TabIndex = 8;
			this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
			// 
			// btnAddMaterialType
			// 
			this.btnAddMaterialType.Location = new System.Drawing.Point(437, 109);
			this.btnAddMaterialType.Name = "btnAddMaterialType";
			this.btnAddMaterialType.Size = new System.Drawing.Size(137, 23);
			this.btnAddMaterialType.TabIndex = 7;
			this.btnAddMaterialType.Text = "Ajout Type Matériel";
			this.btnAddMaterialType.UseVisualStyleBackColor = true;
			this.btnAddMaterialType.Click += new System.EventHandler(this.btnMaterialType_Click);
			// 
			// btnAddClient
			// 
			this.btnAddClient.Location = new System.Drawing.Point(437, 79);
			this.btnAddClient.Name = "btnAddClient";
			this.btnAddClient.Size = new System.Drawing.Size(137, 23);
			this.btnAddClient.TabIndex = 6;
			this.btnAddClient.Text = "Ajout Client";
			this.btnAddClient.UseVisualStyleBackColor = true;
			this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
			// 
			// lblSite
			// 
			this.lblSite.AutoSize = true;
			this.lblSite.Location = new System.Drawing.Point(3, 140);
			this.lblSite.Name = "lblSite";
			this.lblSite.Size = new System.Drawing.Size(90, 13);
			this.lblSite.TabIndex = 5;
			this.lblSite.Text = "Site de stockage:";
			this.lblSite.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(2, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ajout de Matériel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Type de Matériel:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nom du Client:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// cmbMaterialType
			// 
			this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMaterialType.FormattingEnabled = true;
			this.cmbMaterialType.Location = new System.Drawing.Point(121, 109);
			this.cmbMaterialType.Name = "cmbMaterialType";
			this.cmbMaterialType.Size = new System.Drawing.Size(310, 21);
			this.cmbMaterialType.TabIndex = 1;
			this.cmbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialType_SelectedIndexChanged);
			this.cmbMaterialType.SelectedValueChanged += new System.EventHandler(this.cmbMaterialType_SelectedValueChanged);
			// 
			// cmbClientName
			// 
			this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientName.FormattingEnabled = true;
			this.cmbClientName.Location = new System.Drawing.Point(121, 79);
			this.cmbClientName.Name = "cmbClientName";
			this.cmbClientName.Size = new System.Drawing.Size(310, 21);
			this.cmbClientName.TabIndex = 0;
			this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(598, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// FormAddMateriel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormAddMateriel";
			this.Text = "Ajout de Matériel";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddMateriel_FormClosed);
			this.Load += new System.EventHandler(this.FormAddMateriel_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Button btnAddMaterialType;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateIntervention;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDesc;
		private System.Windows.Forms.TextBox txbMTBF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateLimitIntervention;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddEtage;
        private System.Windows.Forms.ComboBox cmbEtage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddBatiment;
        private System.Windows.Forms.ComboBox cmbBatiment;
		private System.Windows.Forms.Label lblBatiment;
        private System.Windows.Forms.ComboBox cmbSalle;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAddSalle;
    }
}