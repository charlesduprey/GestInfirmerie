﻿namespace UtilisateursGUI.GestionMdc
{
    partial class FrmModifMdc
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
            this.modifLbl = new System.Windows.Forms.Label();
            this.LibelleLbl = new System.Windows.Forms.Label();
            this.MdcLbl = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifLbl
            // 
            this.modifLbl.AutoSize = true;
            this.modifLbl.Location = new System.Drawing.Point(73, 26);
            this.modifLbl.Name = "modifLbl";
            this.modifLbl.Size = new System.Drawing.Size(147, 13);
            this.modifLbl.TabIndex = 0;
            this.modifLbl.Text = "Modification d\'un médicament";
            // 
            // LibelleLbl
            // 
            this.LibelleLbl.AutoSize = true;
            this.LibelleLbl.Location = new System.Drawing.Point(37, 67);
            this.LibelleLbl.Name = "LibelleLbl";
            this.LibelleLbl.Size = new System.Drawing.Size(37, 13);
            this.LibelleLbl.TabIndex = 1;
            this.LibelleLbl.Text = "Libellé";
            // 
            // MdcLbl
            // 
            this.MdcLbl.FormattingEnabled = true;
            this.MdcLbl.Location = new System.Drawing.Point(109, 64);
            this.MdcLbl.Name = "MdcLbl";
            this.MdcLbl.Size = new System.Drawing.Size(176, 21);
            this.MdcLbl.TabIndex = 3;
            // this.MdcLbl.SelectionChangeCommitted += new System.EventHandler(this.MdcLbl_SelectionChangeCommitted);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(76, 111);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(181, 111);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FrmModifMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 162);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.MdcLbl);
            this.Controls.Add(this.LibelleLbl);
            this.Controls.Add(this.modifLbl);
            this.Name = "FrmModifMdc";
            this.Text = "FrmModifMdc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifLbl;
        private System.Windows.Forms.Label LibelleLbl;
        private System.Windows.Forms.ComboBox MdcLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}