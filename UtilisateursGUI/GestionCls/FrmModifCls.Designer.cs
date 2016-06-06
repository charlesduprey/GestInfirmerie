namespace UtilisateursGUI.GestionCls
{
    partial class FrmModifCls
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
            this.emploi_du_temps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.niveau_classe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmModifLbl = new System.Windows.Forms.Label();
            this.libelle_classe = new System.Windows.Forms.TextBox();
            this.nomMdc = new System.Windows.Forms.Label();
            this.enrBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id_classe = new System.Windows.Forms.ComboBox();
            this.suprBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emploi_du_temps
            // 
            this.emploi_du_temps.Location = new System.Drawing.Point(166, 144);
            this.emploi_du_temps.Name = "emploi_du_temps";
            this.emploi_du_temps.Size = new System.Drawing.Size(125, 20);
            this.emploi_du_temps.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Emploie du temps";
            // 
            // niveau_classe
            // 
            this.niveau_classe.Location = new System.Drawing.Point(166, 118);
            this.niveau_classe.Name = "niveau_classe";
            this.niveau_classe.Size = new System.Drawing.Size(125, 20);
            this.niveau_classe.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom du niveau";
            // 
            // frmModifLbl
            // 
            this.frmModifLbl.AutoSize = true;
            this.frmModifLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModifLbl.Location = new System.Drawing.Point(12, 9);
            this.frmModifLbl.Name = "frmModifLbl";
            this.frmModifLbl.Size = new System.Drawing.Size(262, 39);
            this.frmModifLbl.TabIndex = 18;
            this.frmModifLbl.Text = "Modifier une classe";
            // 
            // libelle_classe
            // 
            this.libelle_classe.Location = new System.Drawing.Point(166, 92);
            this.libelle_classe.Name = "libelle_classe";
            this.libelle_classe.Size = new System.Drawing.Size(125, 20);
            this.libelle_classe.TabIndex = 17;
            // 
            // nomMdc
            // 
            this.nomMdc.AutoSize = true;
            this.nomMdc.Location = new System.Drawing.Point(39, 95);
            this.nomMdc.Name = "nomMdc";
            this.nomMdc.Size = new System.Drawing.Size(89, 13);
            this.nomMdc.TabIndex = 16;
            this.nomMdc.Text = "Nom de la Classe";
            // 
            // enrBtn
            // 
            this.enrBtn.Location = new System.Drawing.Point(134, 185);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(75, 23);
            this.enrBtn.TabIndex = 15;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = true;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numéro de la Classe";
            // 
            // id_classe
            // 
            this.id_classe.FormattingEnabled = true;
            this.id_classe.Location = new System.Drawing.Point(166, 61);
            this.id_classe.Name = "id_classe";
            this.id_classe.Size = new System.Drawing.Size(125, 21);
            this.id_classe.TabIndex = 24;
            this.id_classe.SelectedValueChanged += new System.EventHandler(this.id_classe_SelectedValueChanged);
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(42, 185);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 84;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // FrmModifCls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 215);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.id_classe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emploi_du_temps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau_classe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmModifLbl);
            this.Controls.Add(this.libelle_classe);
            this.Controls.Add(this.nomMdc);
            this.Controls.Add(this.enrBtn);
            this.Name = "FrmModifCls";
            this.Text = "FrmModifCls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emploi_du_temps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox niveau_classe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmModifLbl;
        private System.Windows.Forms.TextBox libelle_classe;
        private System.Windows.Forms.Label nomMdc;
        private System.Windows.Forms.Button enrBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox id_classe;
        private System.Windows.Forms.Button suprBtn;
    }
}