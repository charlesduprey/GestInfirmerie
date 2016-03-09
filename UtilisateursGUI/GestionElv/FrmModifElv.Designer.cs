namespace UtilisateursGUI.GestionElv
{
    partial class FrmModifElv
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
            this.suprBtn = new System.Windows.Forms.Button();
            this.archBtn = new System.Windows.Forms.Button();
            this.tierTemps_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lblClasse = new System.Windows.Forms.Label();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.commentSante = new System.Windows.Forms.Label();
            this.tierTemps = new System.Windows.Forms.Label();
            this.telParent_txt = new System.Windows.Forms.TextBox();
            this.telParent = new System.Windows.Forms.Label();
            this.telEleve_txt = new System.Windows.Forms.TextBox();
            this.telEleve = new System.Windows.Forms.Label();
            this.ModifEleve = new System.Windows.Forms.Label();
            this.dateNaissance = new System.Windows.Forms.Label();
            this.prenomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve = new System.Windows.Forms.Label();
            this.nomEleve = new System.Windows.Forms.Label();
            this.nomElv_cmbx = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lblClasse_cmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(226, 299);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 87;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // archBtn
            // 
            this.archBtn.Location = new System.Drawing.Point(145, 299);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(75, 23);
            this.archBtn.TabIndex = 86;
            this.archBtn.Text = "Archiver";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.Click += new System.EventHandler(this.archBtn_Click);
            // 
            // tierTemps_txt
            // 
            this.tierTemps_txt.Location = new System.Drawing.Point(152, 196);
            this.tierTemps_txt.Name = "tierTemps_txt";
            this.tierTemps_txt.Size = new System.Drawing.Size(191, 20);
            this.tierTemps_txt.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(64, 299);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 83;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(17, 250);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(102, 13);
            this.lblClasse.TabIndex = 81;
            this.lblClasse.Text = "Libelle de la classe :";
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(152, 222);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(191, 20);
            this.commentSante_text.TabIndex = 80;
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(17, 224);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 79;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(17, 198);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 78;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(152, 169);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(191, 20);
            this.telParent_txt.TabIndex = 77;
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(17, 172);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 76;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(152, 143);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.telEleve_txt.TabIndex = 75;
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(17, 146);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 74;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // ModifEleve
            // 
            this.ModifEleve.AutoSize = true;
            this.ModifEleve.Location = new System.Drawing.Point(117, 9);
            this.ModifEleve.Name = "ModifEleve";
            this.ModifEleve.Size = new System.Drawing.Size(173, 13);
            this.ModifEleve.TabIndex = 73;
            this.ModifEleve.Text = "Modification/suppression de l\'élève";
            this.ModifEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(17, 120);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 72;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(152, 91);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.prenomEleve_txt.TabIndex = 71;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(17, 94);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 70;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(17, 68);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(35, 13);
            this.nomEleve.TabIndex = 69;
            this.nomEleve.Text = "Nom :";
            // 
            // nomElv_cmbx
            // 
            this.nomElv_cmbx.FormattingEnabled = true;
            this.nomElv_cmbx.Location = new System.Drawing.Point(152, 65);
            this.nomElv_cmbx.Name = "nomElv_cmbx";
            this.nomElv_cmbx.Size = new System.Drawing.Size(191, 21);
            this.nomElv_cmbx.TabIndex = 68;
            this.nomElv_cmbx.SelectionChangeCommitted += new System.EventHandler(this.nomElv_list_SelectionChangeCommitted);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(268, 347);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 67;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Location = new System.Drawing.Point(152, 247);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(191, 21);
            this.lblClasse_cmbx.TabIndex = 88;
            // 
            // FrmModifElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 392);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.archBtn);
            this.Controls.Add(this.tierTemps_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.commentSante);
            this.Controls.Add(this.tierTemps);
            this.Controls.Add(this.telParent_txt);
            this.Controls.Add(this.telParent);
            this.Controls.Add(this.telEleve_txt);
            this.Controls.Add(this.telEleve);
            this.Controls.Add(this.ModifEleve);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.prenomEleve_txt);
            this.Controls.Add(this.prenomEleve);
            this.Controls.Add(this.nomEleve);
            this.Controls.Add(this.nomElv_cmbx);
            this.Controls.Add(this.closeBtn);
            this.Name = "FrmModifElv";
            this.Text = "FrmModifElv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suprBtn;
        private System.Windows.Forms.Button archBtn;
        private System.Windows.Forms.TextBox tierTemps_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.Label commentSante;
        private System.Windows.Forms.Label tierTemps;
        private System.Windows.Forms.TextBox telParent_txt;
        private System.Windows.Forms.Label telParent;
        private System.Windows.Forms.TextBox telEleve_txt;
        private System.Windows.Forms.Label telEleve;
        private System.Windows.Forms.Label ModifEleve;
        private System.Windows.Forms.Label dateNaissance;
        private System.Windows.Forms.TextBox prenomEleve_txt;
        private System.Windows.Forms.Label prenomEleve;
        private System.Windows.Forms.Label nomEleve;
        private System.Windows.Forms.ComboBox nomElv_cmbx;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox lblClasse_cmbx;
    }
}