﻿namespace UtilisateursGUI
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.appelMdlLectue = new System.Windows.Forms.Button();
            this.fmrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appelMdlLectue
            // 
            this.appelMdlLectue.Location = new System.Drawing.Point(73, 43);
            this.appelMdlLectue.Name = "appelMdlLectue";
            this.appelMdlLectue.Size = new System.Drawing.Size(90, 27);
            this.appelMdlLectue.TabIndex = 2;
            this.appelMdlLectue.Text = "Module Lecture";
            this.appelMdlLectue.UseVisualStyleBackColor = true;
            this.appelMdlLectue.Click += new System.EventHandler(this.appelMdlLectue_Click);
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(73, 76);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(90, 23);
            this.fmrButton.TabIndex = 3;
            this.fmrButton.Text = "Fermer";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 148);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.appelMdlLectue);
            this.Name = "Menu";
            this.Text = "Gestion de l\'infirmerie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button appelMdlLectue;
        private System.Windows.Forms.Button fmrButton;
    }
}

