﻿namespace GestionMatosApplication
{
    partial class FormAddSite
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomSiteTextBox = new System.Windows.Forms.TextBox();
            this.AdresseSiteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AjouterSiteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de site:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomSiteTextBox
            // 
            this.NomSiteTextBox.Location = new System.Drawing.Point(125, 32);
            this.NomSiteTextBox.Name = "NomSiteTextBox";
            this.NomSiteTextBox.Size = new System.Drawing.Size(164, 20);
            this.NomSiteTextBox.TabIndex = 1;
            // 
            // AdresseSiteTextBox
            // 
            this.AdresseSiteTextBox.Location = new System.Drawing.Point(125, 58);
            this.AdresseSiteTextBox.Name = "AdresseSiteTextBox";
            this.AdresseSiteTextBox.Size = new System.Drawing.Size(164, 20);
            this.AdresseSiteTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse:";
            // 
            // AjouterSiteButton
            // 
            this.AjouterSiteButton.Location = new System.Drawing.Point(149, 98);
            this.AjouterSiteButton.Name = "AjouterSiteButton";
            this.AjouterSiteButton.Size = new System.Drawing.Size(75, 23);
            this.AjouterSiteButton.TabIndex = 4;
            this.AjouterSiteButton.Text = "Ajouter";
            this.AjouterSiteButton.UseVisualStyleBackColor = true;
            this.AjouterSiteButton.Click += new System.EventHandler(this.AjouterSiteButton_Click);
            // 
            // FormAddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 141);
            this.Controls.Add(this.AjouterSiteButton);
            this.Controls.Add(this.AdresseSiteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomSiteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSite";
            this.Text = "Ajouter un site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomSiteTextBox;
        private System.Windows.Forms.TextBox AdresseSiteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AjouterSiteButton;
    }
}