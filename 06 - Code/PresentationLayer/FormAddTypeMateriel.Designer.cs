namespace GestionMatosApplication
{
    partial class FormAddTypeMateriel
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
            this.MTBFTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeMatCancelButton = new System.Windows.Forms.Button();
            this.TypeMatAddButton = new System.Windows.Forms.Button();
            this.TypeMatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MTBFTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TypeMatCancelButton);
            this.panel1.Controls.Add(this.TypeMatAddButton);
            this.panel1.Controls.Add(this.TypeMatTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 172);
            this.panel1.TabIndex = 1;
            // 
            // MTBFTextBox
            // 
            this.MTBFTextBox.Location = new System.Drawing.Point(109, 84);
            this.MTBFTextBox.Name = "MTBFTextBox";
            this.MTBFTextBox.Size = new System.Drawing.Size(170, 20);
            this.MTBFTextBox.TabIndex = 9;
            this.MTBFTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MTBF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TypeMatCancelButton
            // 
            this.TypeMatCancelButton.Location = new System.Drawing.Point(330, 146);
            this.TypeMatCancelButton.Name = "TypeMatCancelButton";
            this.TypeMatCancelButton.Size = new System.Drawing.Size(75, 23);
            this.TypeMatCancelButton.TabIndex = 7;
            this.TypeMatCancelButton.Text = "Annuler";
            this.TypeMatCancelButton.UseVisualStyleBackColor = true;
            this.TypeMatCancelButton.Click += new System.EventHandler(this.TypeMatCancelButton_Click);
            // 
            // TypeMatAddButton
            // 
            this.TypeMatAddButton.Location = new System.Drawing.Point(253, 146);
            this.TypeMatAddButton.Name = "TypeMatAddButton";
            this.TypeMatAddButton.Size = new System.Drawing.Size(75, 23);
            this.TypeMatAddButton.TabIndex = 6;
            this.TypeMatAddButton.Text = "Ajouter";
            this.TypeMatAddButton.UseVisualStyleBackColor = true;
            this.TypeMatAddButton.Click += new System.EventHandler(this.TypeMatAddButton_Click);
            // 
            // TypeMatTextBox
            // 
            this.TypeMatTextBox.Location = new System.Drawing.Point(109, 55);
            this.TypeMatTextBox.Name = "TypeMatTextBox";
            this.TypeMatTextBox.Size = new System.Drawing.Size(170, 20);
            this.TypeMatTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajout d\'un Type Matériel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du Type:";
            // 
            // FormAddTypeMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 196);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddTypeMateriel";
            this.Text = "FormAddTypeMateriel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeMatTextBox;
        private System.Windows.Forms.Button TypeMatCancelButton;
        private System.Windows.Forms.Button TypeMatAddButton;
        private System.Windows.Forms.TextBox MTBFTextBox;
        private System.Windows.Forms.Label label2;

    }
}