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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifElv));
            this.suprBtn = new System.Windows.Forms.Button();
            this.archBtn = new System.Windows.Forms.Button();
            this.dateNaissancePicker = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lblClasse = new System.Windows.Forms.Label();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.commentSante = new System.Windows.Forms.Label();
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
            this.TierTempsFalse = new System.Windows.Forms.RadioButton();
            this.TierTempsTrue = new System.Windows.Forms.RadioButton();
            this.tierTemps = new System.Windows.Forms.Label();
            this.errProNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProDateNaissance = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProTelEleve = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProTelPar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProCommentaire = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProDateNaissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelPar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProCommentaire)).BeginInit();
            this.SuspendLayout();
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(331, 317);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 87;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // archBtn
            // 
            this.archBtn.Location = new System.Drawing.Point(250, 317);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(75, 23);
            this.archBtn.TabIndex = 86;
            this.archBtn.Text = "Archiver";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.Click += new System.EventHandler(this.archBtn_Click);
            // 
            // dateNaissancePicker
            // 
            this.dateNaissancePicker.Location = new System.Drawing.Point(257, 135);
            this.dateNaissancePicker.Name = "dateNaissancePicker";
            this.dateNaissancePicker.Size = new System.Drawing.Size(191, 20);
            this.dateNaissancePicker.TabIndex = 84;
            this.dateNaissancePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateNaissancePicker_Validating);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(169, 317);
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
            this.lblClasse.Location = new System.Drawing.Point(123, 216);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(102, 13);
            this.lblClasse.TabIndex = 81;
            this.lblClasse.Text = "Libelle de la classe :";
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(257, 263);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(191, 20);
            this.commentSante_text.TabIndex = 80;
            this.commentSante_text.TextChanged += new System.EventHandler(this.commentSante_text_TextChanged);
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(123, 266);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 79;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(257, 187);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(191, 20);
            this.telParent_txt.TabIndex = 77;
            this.telParent_txt.Validating += new System.ComponentModel.CancelEventHandler(this.telParent_txt_Validating);
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(122, 190);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 76;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(257, 161);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.telEleve_txt.TabIndex = 75;
            this.telEleve_txt.Validated += new System.EventHandler(this.telEleve_txt_Validated);
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(122, 164);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 74;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // ModifEleve
            // 
            this.ModifEleve.AutoSize = true;
            this.ModifEleve.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifEleve.Location = new System.Drawing.Point(12, 9);
            this.ModifEleve.Name = "ModifEleve";
            this.ModifEleve.Size = new System.Drawing.Size(559, 45);
            this.ModifEleve.TabIndex = 73;
            this.ModifEleve.Text = "Modification/suppression d\'un élève";
            this.ModifEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(122, 138);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 72;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(257, 109);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.prenomEleve_txt.TabIndex = 71;
            this.prenomEleve_txt.Validating += new System.ComponentModel.CancelEventHandler(this.prenomEleve_txt_Validating);
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(122, 112);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 70;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(122, 86);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(35, 13);
            this.nomEleve.TabIndex = 69;
            this.nomEleve.Text = "Nom :";
            // 
            // nomElv_cmbx
            // 
            this.nomElv_cmbx.FormattingEnabled = true;
            this.nomElv_cmbx.Location = new System.Drawing.Point(257, 83);
            this.nomElv_cmbx.Name = "nomElv_cmbx";
            this.nomElv_cmbx.Size = new System.Drawing.Size(191, 21);
            this.nomElv_cmbx.TabIndex = 68;
            this.nomElv_cmbx.SelectionChangeCommitted += new System.EventHandler(this.nomElv_list_SelectionChangeCommitted);
            this.nomElv_cmbx.Validating += new System.ComponentModel.CancelEventHandler(this.nomElv_cmbx_Validating);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(373, 365);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 67;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Location = new System.Drawing.Point(257, 213);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(191, 21);
            this.lblClasse_cmbx.TabIndex = 88;
            this.lblClasse_cmbx.Validating += new System.ComponentModel.CancelEventHandler(this.lblClasse_cmbx_Validating);
            // 
            // TierTempsFalse
            // 
            this.TierTempsFalse.AutoSize = true;
            this.TierTempsFalse.Checked = true;
            this.TierTempsFalse.Location = new System.Drawing.Point(399, 240);
            this.TierTempsFalse.Name = "TierTempsFalse";
            this.TierTempsFalse.Size = new System.Drawing.Size(43, 17);
            this.TierTempsFalse.TabIndex = 161;
            this.TierTempsFalse.TabStop = true;
            this.TierTempsFalse.Text = "non";
            this.TierTempsFalse.UseVisualStyleBackColor = true;
            // 
            // TierTempsTrue
            // 
            this.TierTempsTrue.AutoSize = true;
            this.TierTempsTrue.Location = new System.Drawing.Point(257, 240);
            this.TierTempsTrue.Name = "TierTempsTrue";
            this.TierTempsTrue.Size = new System.Drawing.Size(39, 17);
            this.TierTempsTrue.TabIndex = 160;
            this.TierTempsTrue.Text = "oui";
            this.TierTempsTrue.UseVisualStyleBackColor = true;
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(123, 242);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 159;
            this.tierTemps.Text = "Tier temps :";
            // 
            // errProNom
            // 
            this.errProNom.ContainerControl = this;
            // 
            // errProPrenom
            // 
            this.errProPrenom.ContainerControl = this;
            // 
            // errProDateNaissance
            // 
            this.errProDateNaissance.ContainerControl = this;
            // 
            // errProTelEleve
            // 
            this.errProTelEleve.ContainerControl = this;
            // 
            // errProTelPar
            // 
            this.errProTelPar.ContainerControl = this;
            // 
            // errProClasse
            // 
            this.errProClasse.ContainerControl = this;
            // 
            // errProCommentaire
            // 
            this.errProCommentaire.ContainerControl = this;
            // 
            // FrmModifElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 408);
            this.Controls.Add(this.TierTempsFalse);
            this.Controls.Add(this.TierTempsTrue);
            this.Controls.Add(this.tierTemps);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.archBtn);
            this.Controls.Add(this.dateNaissancePicker);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.commentSante);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModifElv";
            this.Text = "Formulaire de modification des élèves";
            ((System.ComponentModel.ISupportInitialize)(this.errProNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProDateNaissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelPar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProCommentaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suprBtn;
        private System.Windows.Forms.Button archBtn;
        private System.Windows.Forms.DateTimePicker dateNaissancePicker;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.Label commentSante;
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
        private System.Windows.Forms.RadioButton TierTempsFalse;
        private System.Windows.Forms.RadioButton TierTempsTrue;
        private System.Windows.Forms.Label tierTemps;
        private System.Windows.Forms.ErrorProvider errProNom;
        private System.Windows.Forms.ErrorProvider errProPrenom;
        private System.Windows.Forms.ErrorProvider errProDateNaissance;
        private System.Windows.Forms.ErrorProvider errProTelEleve;
        private System.Windows.Forms.ErrorProvider errProTelPar;
        private System.Windows.Forms.ErrorProvider errProClasse;
        private System.Windows.Forms.ErrorProvider errProCommentaire;
    }
}