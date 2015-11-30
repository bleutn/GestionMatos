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
            this.txbMTBF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSalle = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMaterialName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateIntervention = new System.Windows.Forms.DateTimePicker();
            this.btnAddEtage = new System.Windows.Forms.Button();
            this.cmbEtage = new System.Windows.Forms.ComboBox();
            this.btnMaterialType = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txbMTBF);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvSalle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbMaterialName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbDesc);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateIntervention);
            this.panel1.Controls.Add(this.btnAddEtage);
            this.panel1.Controls.Add(this.cmbEtage);
            this.panel1.Controls.Add(this.btnMaterialType);
            this.panel1.Controls.Add(this.btnAddClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMaterialType);
            this.panel1.Controls.Add(this.cmbClientName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 545);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbMTBF
            // 
            this.txbMTBF.Location = new System.Drawing.Point(121, 176);
            this.txbMTBF.Name = "txbMTBF";
            this.txbMTBF.ReadOnly = true;
            this.txbMTBF.Size = new System.Drawing.Size(291, 20);
            this.txbMTBF.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "MTBF:";
            // 
            // dgvSalle
            // 
            this.dgvSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalle.Location = new System.Drawing.Point(123, 208);
            this.dgvSalle.Name = "dgvSalle";
            this.dgvSalle.Size = new System.Drawing.Size(308, 108);
            this.dgvSalle.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salle:";
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
            this.label6.Location = new System.Drawing.Point(6, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Description:";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(121, 384);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(310, 117);
            this.txbDesc.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(499, 519);
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
            this.label5.Location = new System.Drawing.Point(6, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date d\'intervention:";
            // 
            // dateIntervention
            // 
            this.dateIntervention.Location = new System.Drawing.Point(121, 322);
            this.dateIntervention.Name = "dateIntervention";
            this.dateIntervention.Size = new System.Drawing.Size(206, 20);
            this.dateIntervention.TabIndex = 10;
            // 
            // btnAddEtage
            // 
            this.btnAddEtage.Enabled = false;
            this.btnAddEtage.Location = new System.Drawing.Point(437, 135);
            this.btnAddEtage.Name = "btnAddEtage";
            this.btnAddEtage.Size = new System.Drawing.Size(137, 23);
            this.btnAddEtage.TabIndex = 9;
            this.btnAddEtage.Text = "Ajout d\'étage";
            this.btnAddEtage.UseVisualStyleBackColor = true;
            this.btnAddEtage.Click += new System.EventHandler(this.btnAddEtage_Click);
            // 
            // cmbEtage
            // 
            this.cmbEtage.Enabled = false;
            this.cmbEtage.FormattingEnabled = true;
            this.cmbEtage.Location = new System.Drawing.Point(121, 137);
            this.cmbEtage.Name = "cmbEtage";
            this.cmbEtage.Size = new System.Drawing.Size(310, 21);
            this.cmbEtage.TabIndex = 8;
            this.cmbEtage.SelectedIndexChanged += new System.EventHandler(this.cmbEtage_SelectedIndexChanged);
            // 
            // btnMaterialType
            // 
            this.btnMaterialType.Location = new System.Drawing.Point(437, 107);
            this.btnMaterialType.Name = "btnMaterialType";
            this.btnMaterialType.Size = new System.Drawing.Size(137, 23);
            this.btnMaterialType.TabIndex = 7;
            this.btnMaterialType.Text = "Ajout de Type de matériel";
            this.btnMaterialType.UseVisualStyleBackColor = true;
            this.btnMaterialType.Click += new System.EventHandler(this.btnMaterialType_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(437, 77);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(137, 23);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Ajout de client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Etage:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du Client:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMaterialType
            // 
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
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(121, 79);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(310, 21);
            this.cmbClientName.TabIndex = 0;
            this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(437, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ajout de Salle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Date de fin de validité:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FormAddMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 566);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddMateriel";
            this.Text = "Ajout de Matériel";
            this.Load += new System.EventHandler(this.FormAddMateriel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbEtage;
        private System.Windows.Forms.Button btnMaterialType;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEtage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateIntervention;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSalle;
		private System.Windows.Forms.TextBox txbMTBF;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
    }
}