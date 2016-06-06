namespace UtilisateursGUI.GestionCls
{
    partial class FrmAjoutCls
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
            this.frmModifLbl = new System.Windows.Forms.Label();
            this.libelle_classe = new System.Windows.Forms.TextBox();
            this.nomMdc = new System.Windows.Forms.Label();
            this.enrBtn = new System.Windows.Forms.Button();
            this.niveau_classe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emploi_du_temps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmModifLbl
            // 
            this.frmModifLbl.AutoSize = true;
            this.frmModifLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModifLbl.Location = new System.Drawing.Point(12, 9);
            this.frmModifLbl.Name = "frmModifLbl";
            this.frmModifLbl.Size = new System.Drawing.Size(249, 39);
            this.frmModifLbl.TabIndex = 10;
            this.frmModifLbl.Text = "Ajouter une classe";
            // 
            // libelle_classe
            // 
            this.libelle_classe.Location = new System.Drawing.Point(167, 71);
            this.libelle_classe.Name = "libelle_classe";
            this.libelle_classe.Size = new System.Drawing.Size(125, 20);
            this.libelle_classe.TabIndex = 9;
            // 
            // nomMdc
            // 
            this.nomMdc.AutoSize = true;
            this.nomMdc.Location = new System.Drawing.Point(40, 74);
            this.nomMdc.Name = "nomMdc";
            this.nomMdc.Size = new System.Drawing.Size(89, 13);
            this.nomMdc.TabIndex = 8;
            this.nomMdc.Text = "Nom de la Classe";
            // 
            // enrBtn
            // 
            this.enrBtn.Location = new System.Drawing.Point(217, 164);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(75, 23);
            this.enrBtn.TabIndex = 7;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = true;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click_1);
            // 
            // niveau_classe
            // 
            this.niveau_classe.Location = new System.Drawing.Point(167, 97);
            this.niveau_classe.Name = "niveau_classe";
            this.niveau_classe.Size = new System.Drawing.Size(125, 20);
            this.niveau_classe.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom du niveau";
            // 
            // emploi_du_temps
            // 
            this.emploi_du_temps.Location = new System.Drawing.Point(167, 123);
            this.emploi_du_temps.Name = "emploi_du_temps";
            this.emploi_du_temps.Size = new System.Drawing.Size(125, 20);
            this.emploi_du_temps.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Emploie du temps";
            // 
            // FrmAjoutCls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.emploi_du_temps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau_classe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmModifLbl);
            this.Controls.Add(this.libelle_classe);
            this.Controls.Add(this.nomMdc);
            this.Controls.Add(this.enrBtn);
            this.Name = "FrmAjoutCls";
            this.Text = "FrmAjoutCls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmModifLbl;
        private System.Windows.Forms.TextBox libelle_classe;
        private System.Windows.Forms.Label nomMdc;
        private System.Windows.Forms.Button enrBtn;
        private System.Windows.Forms.TextBox niveau_classe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emploi_du_temps;
        private System.Windows.Forms.Label label2;
    }
}