namespace UtilisateursGUI.GestionElv
{
    partial class FrmAjoutElv
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
            this.TierTempsFalse = new System.Windows.Forms.RadioButton();
            this.TierTempsTrue = new System.Windows.Forms.RadioButton();
            this.lblClasse_cmbx = new System.Windows.Forms.ComboBox();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.idClasse = new System.Windows.Forms.Label();
            this.commentSante = new System.Windows.Forms.Label();
            this.tierTemps = new System.Windows.Forms.Label();
            this.telParent_txt = new System.Windows.Forms.TextBox();
            this.telParent = new System.Windows.Forms.Label();
            this.telEleve_txt = new System.Windows.Forms.TextBox();
            this.telEleve = new System.Windows.Forms.Label();
            this.AjoutEleve = new System.Windows.Forms.Label();
            this.dateNaissance = new System.Windows.Forms.Label();
            this.prenomEleve_txt = new System.Windows.Forms.TextBox();
            this.nomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve = new System.Windows.Forms.Label();
            this.nomEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TierTempsFalse
            // 
            this.TierTempsFalse.AutoSize = true;
            this.TierTempsFalse.Location = new System.Drawing.Point(348, 242);
            this.TierTempsFalse.Name = "TierTempsFalse";
            this.TierTempsFalse.Size = new System.Drawing.Size(43, 17);
            this.TierTempsFalse.TabIndex = 158;
            this.TierTempsFalse.Text = "non";
            this.TierTempsFalse.UseVisualStyleBackColor = true;
            // 
            // TierTempsTrue
            // 
            this.TierTempsTrue.AutoSize = true;
            this.TierTempsTrue.Checked = true;
            this.TierTempsTrue.Location = new System.Drawing.Point(206, 242);
            this.TierTempsTrue.Name = "TierTempsTrue";
            this.TierTempsTrue.Size = new System.Drawing.Size(39, 17);
            this.TierTempsTrue.TabIndex = 157;
            this.TierTempsTrue.TabStop = true;
            this.TierTempsTrue.Text = "oui";
            this.TierTempsTrue.UseVisualStyleBackColor = true;
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Location = new System.Drawing.Point(206, 214);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(227, 21);
            this.lblClasse_cmbx.TabIndex = 156;
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(206, 267);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(227, 20);
            this.commentSante_text.TabIndex = 155;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 154;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(206, 313);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(227, 36);
            this.saveBtn.TabIndex = 153;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(32, 313);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 36);
            this.closeButton.TabIndex = 152;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idClasse
            // 
            this.idClasse.AutoSize = true;
            this.idClasse.Location = new System.Drawing.Point(34, 217);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(44, 13);
            this.idClasse.TabIndex = 151;
            this.idClasse.Text = "Classe :";
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(29, 270);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 150;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(29, 244);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 149;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(206, 188);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(227, 20);
            this.telParent_txt.TabIndex = 148;
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(29, 195);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 147;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(206, 162);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.telEleve_txt.TabIndex = 146;
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(29, 169);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 145;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // AjoutEleve
            // 
            this.AjoutEleve.AutoSize = true;
            this.AjoutEleve.Location = new System.Drawing.Point(165, 32);
            this.AjoutEleve.Name = "AjoutEleve";
            this.AjoutEleve.Size = new System.Drawing.Size(79, 13);
            this.AjoutEleve.TabIndex = 144;
            this.AjoutEleve.Text = "Ajout de l\'élève";
            this.AjoutEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(29, 142);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 143;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(206, 110);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.prenomEleve_txt.TabIndex = 142;
            // 
            // nomEleve_txt
            // 
            this.nomEleve_txt.Location = new System.Drawing.Point(206, 84);
            this.nomEleve_txt.Name = "nomEleve_txt";
            this.nomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.nomEleve_txt.TabIndex = 141;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(29, 113);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 140;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(29, 87);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(38, 13);
            this.nomEleve.TabIndex = 139;
            this.nomEleve.Text = "Nom  :";
            // 
            // FrmAjoutElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 380);
            this.Controls.Add(this.TierTempsFalse);
            this.Controls.Add(this.TierTempsTrue);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.idClasse);
            this.Controls.Add(this.commentSante);
            this.Controls.Add(this.tierTemps);
            this.Controls.Add(this.telParent_txt);
            this.Controls.Add(this.telParent);
            this.Controls.Add(this.telEleve_txt);
            this.Controls.Add(this.telEleve);
            this.Controls.Add(this.AjoutEleve);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.prenomEleve_txt);
            this.Controls.Add(this.nomEleve_txt);
            this.Controls.Add(this.prenomEleve);
            this.Controls.Add(this.nomEleve);
            this.Name = "FrmAjoutElv";
            this.Text = "FrmAjoutElv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TierTempsFalse;
        private System.Windows.Forms.RadioButton TierTempsTrue;
        private System.Windows.Forms.ComboBox lblClasse_cmbx;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label idClasse;
        private System.Windows.Forms.Label commentSante;
        private System.Windows.Forms.Label tierTemps;
        private System.Windows.Forms.TextBox telParent_txt;
        private System.Windows.Forms.Label telParent;
        private System.Windows.Forms.TextBox telEleve_txt;
        private System.Windows.Forms.Label telEleve;
        private System.Windows.Forms.Label AjoutEleve;
        private System.Windows.Forms.Label dateNaissance;
        private System.Windows.Forms.TextBox prenomEleve_txt;
        private System.Windows.Forms.TextBox nomEleve_txt;
        private System.Windows.Forms.Label prenomEleve;
        private System.Windows.Forms.Label nomEleve;

    }
}