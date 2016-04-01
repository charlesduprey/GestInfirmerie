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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutElv));
            this.TierTempsFalse = new System.Windows.Forms.RadioButton();
            this.TierTempsTrue = new System.Windows.Forms.RadioButton();
            this.lblClasse_cmbx = new System.Windows.Forms.ComboBox();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.dateNaissancePicker = new System.Windows.Forms.DateTimePicker();
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
            this.errProNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProDateNaissance = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProTelEleve = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProTelPar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProCommentaire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProSave = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProDateNaissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelPar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProCommentaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).BeginInit();
            this.SuspendLayout();
            // 
            // TierTempsFalse
            // 
            this.TierTempsFalse.AutoSize = true;
            this.TierTempsFalse.Checked = true;
            this.TierTempsFalse.Location = new System.Drawing.Point(351, 241);
            this.TierTempsFalse.Name = "TierTempsFalse";
            this.TierTempsFalse.Size = new System.Drawing.Size(43, 17);
            this.TierTempsFalse.TabIndex = 158;
            this.TierTempsFalse.TabStop = true;
            this.TierTempsFalse.Text = "non";
            this.TierTempsFalse.UseVisualStyleBackColor = true;
            // 
            // TierTempsTrue
            // 
            this.TierTempsTrue.AutoSize = true;
            this.TierTempsTrue.Location = new System.Drawing.Point(209, 241);
            this.TierTempsTrue.Name = "TierTempsTrue";
            this.TierTempsTrue.Size = new System.Drawing.Size(39, 17);
            this.TierTempsTrue.TabIndex = 157;
            this.TierTempsTrue.Text = "oui";
            this.TierTempsTrue.UseVisualStyleBackColor = true;
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Items.AddRange(new object[] {
            "Sélectionner une classe",
            "(Collection)"});
            this.lblClasse_cmbx.Location = new System.Drawing.Point(209, 216);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(227, 21);
            this.lblClasse_cmbx.TabIndex = 156;
            this.lblClasse_cmbx.Validating += new System.ComponentModel.CancelEventHandler(this.lblClasse_cmbx_Validating);
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(209, 269);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(227, 20);
            this.commentSante_text.TabIndex = 155;
            this.commentSante_text.Validating += new System.ComponentModel.CancelEventHandler(this.commentSante_text_Validating);
            // 
            // dateNaissancePicker
            // 
            this.dateNaissancePicker.Location = new System.Drawing.Point(209, 138);
            this.dateNaissancePicker.Name = "dateNaissancePicker";
            this.dateNaissancePicker.Size = new System.Drawing.Size(227, 20);
            this.dateNaissancePicker.TabIndex = 154;
            this.dateNaissancePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateNaissancePicker_Validating);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(153, 320);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 153;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.Validating += new System.ComponentModel.CancelEventHandler(this.saveBtn_Validating);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(234, 320);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 152;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idClasse
            // 
            this.idClasse.AutoSize = true;
            this.idClasse.Location = new System.Drawing.Point(32, 219);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(44, 13);
            this.idClasse.TabIndex = 151;
            this.idClasse.Text = "Classe :";
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(32, 272);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(103, 13);
            this.commentSante.TabIndex = 150;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(32, 243);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(62, 13);
            this.tierTemps.TabIndex = 149;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(209, 190);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(227, 20);
            this.telParent_txt.TabIndex = 148;
            this.telParent_txt.Validating += new System.ComponentModel.CancelEventHandler(this.telParent_txt_Validating);
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(32, 197);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(122, 13);
            this.telParent.TabIndex = 147;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(209, 164);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.telEleve_txt.TabIndex = 146;
            this.telEleve_txt.Validating += new System.ComponentModel.CancelEventHandler(this.telEleve_txt_Validating);
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(32, 171);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(112, 13);
            this.telEleve.TabIndex = 145;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // AjoutEleve
            // 
            this.AjoutEleve.AutoSize = true;
            this.AjoutEleve.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutEleve.Location = new System.Drawing.Point(123, 29);
            this.AjoutEleve.Name = "AjoutEleve";
            this.AjoutEleve.Size = new System.Drawing.Size(222, 39);
            this.AjoutEleve.TabIndex = 144;
            this.AjoutEleve.Text = "Ajout d\'un élève";
            this.AjoutEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(32, 144);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 143;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(209, 112);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.prenomEleve_txt.TabIndex = 142;
            this.prenomEleve_txt.Validating += new System.ComponentModel.CancelEventHandler(this.prenomEleve_txt_Validating);
            // 
            // nomEleve_txt
            // 
            this.nomEleve_txt.Location = new System.Drawing.Point(209, 86);
            this.nomEleve_txt.Name = "nomEleve_txt";
            this.nomEleve_txt.Size = new System.Drawing.Size(227, 20);
            this.nomEleve_txt.TabIndex = 141;
            this.nomEleve_txt.Validating += new System.ComponentModel.CancelEventHandler(this.nomEleve_txt_Validating);
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(32, 115);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 140;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(32, 89);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(38, 13);
            this.nomEleve.TabIndex = 139;
            this.nomEleve.Text = "Nom  :";
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
            // errProSave
            // 
            this.errProSave.ContainerControl = this;
            // 
            // FrmAjoutElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 373);
            this.Controls.Add(this.TierTempsFalse);
            this.Controls.Add(this.TierTempsTrue);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.dateNaissancePicker);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutElv";
            this.Text = "Formulaire d\'ajout d\'élèves";
            ((System.ComponentModel.ISupportInitialize)(this.errProNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProDateNaissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProTelPar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProCommentaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TierTempsFalse;
        private System.Windows.Forms.RadioButton TierTempsTrue;
        private System.Windows.Forms.ComboBox lblClasse_cmbx;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.DateTimePicker dateNaissancePicker;
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
        private System.Windows.Forms.ErrorProvider errProNom;
        private System.Windows.Forms.ErrorProvider errProPrenom;
        private System.Windows.Forms.ErrorProvider errProDateNaissance;
        private System.Windows.Forms.ErrorProvider errProTelEleve;
        private System.Windows.Forms.ErrorProvider errProTelPar;
        private System.Windows.Forms.ErrorProvider errProClasse;
        private System.Windows.Forms.ErrorProvider errProCommentaire;
        private System.Windows.Forms.ErrorProvider errProSave;

    }
}