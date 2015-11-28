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
            this.listeClasse = new System.Windows.Forms.ComboBox();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tierTemps_txt = new System.Windows.Forms.TextBox();
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
            this.nomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve = new System.Windows.Forms.Label();
            this.nomEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeClasse
            // 
            this.listeClasse.FormattingEnabled = true;
            this.listeClasse.Location = new System.Drawing.Point(207, 213);
            this.listeClasse.Name = "listeClasse";
            this.listeClasse.Size = new System.Drawing.Size(227, 21);
            this.listeClasse.TabIndex = 135;
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(207, 266);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(227, 20);
            this.commentSante_text.TabIndex = 134;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // tierTemps_txt
            // 
            this.tierTemps_txt.Location = new System.Drawing.Point(207, 240);
            this.tierTemps_txt.Name = "tierTemps_txt";
            this.tierTemps_txt.Size = new System.Drawing.Size(227, 20);
            this.tierTemps_txt.TabIndex = 132;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(207, 312);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(227, 36);
            this.saveBtn.TabIndex = 131;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(33, 312);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 36);
            this.closeButton.TabIndex = 130;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idClasse
            // 
            this.idClasse.AutoSize = true;
            this.idClasse.Location = new System.Drawing.Point(30, 221);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(118, 13);
            this.idClasse.TabIndex = 129;
            this.idClasse.Text = "Identifiant de la classe :";
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(30, 269);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 128;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(30, 243);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 127;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(207, 187);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(227, 20);
            this.telParent_txt.TabIndex = 126;
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(30, 194);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 125;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(207, 161);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.telEleve_txt.TabIndex = 124;
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(30, 168);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 123;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // AjoutEleve
            // 
            this.AjoutEleve.AutoSize = true;
            this.AjoutEleve.Location = new System.Drawing.Point(166, 31);
            this.AjoutEleve.Name = "AjoutEleve";
            this.AjoutEleve.Size = new System.Drawing.Size(79, 13);
            this.AjoutEleve.TabIndex = 122;
            this.AjoutEleve.Text = "Ajout de l\'élève";
            this.AjoutEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(30, 141);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 121;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // nomEleve_txt
            // 
            this.nomEleve_txt.Location = new System.Drawing.Point(207, 83);
            this.nomEleve_txt.Name = "nomEleve_txt";
            this.nomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.nomEleve_txt.TabIndex = 120;
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(207, 109);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.prenomEleve_txt.TabIndex = 119;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(30, 112);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 118;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(30, 86);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(38, 13);
            this.nomEleve.TabIndex = 117;
            this.nomEleve.Text = "Nom  :";
            // 
            // FrmAjoutElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 380);
            this.Controls.Add(this.listeClasse);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tierTemps_txt);
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
            this.Controls.Add(this.nomEleve_txt);
            this.Controls.Add(this.prenomEleve_txt);
            this.Controls.Add(this.prenomEleve);
            this.Controls.Add(this.nomEleve);
            this.Name = "FrmAjoutElv";
            this.Text = "FrmAjoutElv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listeClasse;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tierTemps_txt;
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
        private System.Windows.Forms.TextBox nomEleve_txt;
        private System.Windows.Forms.TextBox prenomEleve_txt;
        private System.Windows.Forms.Label prenomEleve;
        private System.Windows.Forms.Label nomEleve;
    }
}