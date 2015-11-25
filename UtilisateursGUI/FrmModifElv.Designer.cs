namespace UtilisateursGUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.save_btn = new System.Windows.Forms.Button();
            this.idClasse_txt = new System.Windows.Forms.TextBox();
            this.idClasse = new System.Windows.Forms.Label();
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
            this.nomElv_list = new System.Windows.Forms.ComboBox();
            this.close_button = new System.Windows.Forms.Button();
            this.tierTemps_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(154, 416);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 61;
            this.save_btn.Text = "Enregistrer";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // idClasse_txt
            // 
            this.idClasse_txt.Location = new System.Drawing.Point(212, 335);
            this.idClasse_txt.Name = "idClasse_txt";
            this.idClasse_txt.Size = new System.Drawing.Size(191, 20);
            this.idClasse_txt.TabIndex = 60;
            // 
            // idClasse
            // 
            this.idClasse.AutoSize = true;
            this.idClasse.Location = new System.Drawing.Point(77, 338);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(118, 13);
            this.idClasse.TabIndex = 59;
            this.idClasse.Text = "Identifiant de la classe :";
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(212, 310);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(191, 20);
            this.commentSante_text.TabIndex = 58;
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(77, 312);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 57;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(77, 286);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 56;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(212, 257);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(191, 20);
            this.telParent_txt.TabIndex = 55;
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(77, 260);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 54;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(212, 231);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.telEleve_txt.TabIndex = 53;
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(77, 234);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 52;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // ModifEleve
            // 
            this.ModifEleve.AutoSize = true;
            this.ModifEleve.Location = new System.Drawing.Point(183, 56);
            this.ModifEleve.Name = "ModifEleve";
            this.ModifEleve.Size = new System.Drawing.Size(112, 13);
            this.ModifEleve.TabIndex = 51;
            this.ModifEleve.Text = "Modification de l\'élève";
            this.ModifEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(77, 208);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 50;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(212, 179);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.prenomEleve_txt.TabIndex = 49;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(77, 182);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 48;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(77, 156);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(38, 13);
            this.nomEleve.TabIndex = 47;
            this.nomEleve.Text = "Nom  :";
            // 
            // nomElv_list
            // 
            this.nomElv_list.FormattingEnabled = true;
            this.nomElv_list.Location = new System.Drawing.Point(212, 153);
            this.nomElv_list.Name = "nomElv_list";
            this.nomElv_list.Size = new System.Drawing.Size(191, 21);
            this.nomElv_list.TabIndex = 46;
            this.nomElv_list.SelectionChangeCommitted += new System.EventHandler(this.nomElv_list_SelectionChangeCommitted);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(235, 416);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 45;
            this.close_button.Text = "Fermer";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // tierTemps_txt
            // 
            this.tierTemps_txt.Location = new System.Drawing.Point(212, 284);
            this.tierTemps_txt.Name = "tierTemps_txt";
            this.tierTemps_txt.Size = new System.Drawing.Size(191, 20);
            this.tierTemps_txt.TabIndex = 64;
            // 
            // FrmModifElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 494);
            this.Controls.Add(this.tierTemps_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.idClasse_txt);
            this.Controls.Add(this.idClasse);
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
            this.Controls.Add(this.nomElv_list);
            this.Controls.Add(this.close_button);
            this.Name = "FrmModifElv";
            this.Text = "FrmModifElv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox idClasse_txt;
        private System.Windows.Forms.Label idClasse;
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
        private System.Windows.Forms.ComboBox nomElv_list;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox tierTemps_txt;
    }
}