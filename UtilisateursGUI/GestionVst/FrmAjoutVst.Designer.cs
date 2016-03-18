namespace UtilisateursGUI.GestionVst
{
    partial class FrmAjoutVst
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
            this.dateNaissance = new System.Windows.Forms.Label();
            this.prenomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve = new System.Windows.Forms.Label();
            this.nomEleve = new System.Windows.Forms.Label();
            this.nomElv_cmbx = new System.Windows.Forms.ComboBox();
            this.ModifEleve = new System.Windows.Forms.Label();
            this.lblClasse_cmbx = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.dateVstPicker = new System.Windows.Forms.DateTimePicker();
            this.dateVstLbl = new System.Windows.Forms.Label();
            this.hrArvLbl = new System.Windows.Forms.Label();
            this.dateTimeArv = new System.Windows.Forms.DateTimePicker();
            this.hrDepLbl = new System.Windows.Forms.Label();
            this.dateTimeDep = new System.Windows.Forms.DateTimePicker();
            this.commentVst = new System.Windows.Forms.Label();
            this.commentTxtbx = new System.Windows.Forms.TextBox();
            this.poulsLbl = new System.Windows.Forms.Label();
            this.motifTxtbx = new System.Windows.Forms.TextBox();
            this.motifLbl = new System.Windows.Forms.Label();
            this.prescriptionLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.backHomeYes = new System.Windows.Forms.RadioButton();
            this.tellPrYes = new System.Windows.Forms.RadioButton();
            this.hospitalYes = new System.Windows.Forms.RadioButton();
            this.backHomeNo = new System.Windows.Forms.RadioButton();
            this.tellPrNo = new System.Windows.Forms.RadioButton();
            this.hospitalNo = new System.Windows.Forms.RadioButton();
            this.backHomeGroup = new System.Windows.Forms.GroupBox();
            this.hospitalGroup = new System.Windows.Forms.GroupBox();
            this.tellPrGroup = new System.Windows.Forms.GroupBox();
            this.lblMdc_list = new System.Windows.Forms.ComboBox();
            this.poulsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.qteNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.qteLbl = new System.Windows.Forms.Label();
            this.backHomeGroup.SuspendLayout();
            this.hospitalGroup.SuspendLayout();
            this.tellPrGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poulsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qteNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(63, 171);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(102, 13);
            this.dateNaissance.TabIndex = 89;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(198, 142);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(191, 20);
            this.prenomEleve_txt.TabIndex = 88;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(63, 145);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.prenomEleve.TabIndex = 87;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(63, 119);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(35, 13);
            this.nomEleve.TabIndex = 86;
            this.nomEleve.Text = "Nom :";
            // 
            // nomElv_cmbx
            // 
            this.nomElv_cmbx.FormattingEnabled = true;
            this.nomElv_cmbx.Location = new System.Drawing.Point(198, 116);
            this.nomElv_cmbx.Name = "nomElv_cmbx";
            this.nomElv_cmbx.Size = new System.Drawing.Size(191, 21);
            this.nomElv_cmbx.TabIndex = 85;
            this.nomElv_cmbx.SelectionChangeCommitted += new System.EventHandler(this.nomElv_list_SelectionChangeCommitted);
            // 
            // ModifEleve
            // 
            this.ModifEleve.AutoSize = true;
            this.ModifEleve.Location = new System.Drawing.Point(181, 39);
            this.ModifEleve.Name = "ModifEleve";
            this.ModifEleve.Size = new System.Drawing.Size(87, 13);
            this.ModifEleve.TabIndex = 91;
            this.ModifEleve.Text = "Ajout d\'une visite";
            this.ModifEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Location = new System.Drawing.Point(198, 194);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(191, 21);
            this.lblClasse_cmbx.TabIndex = 93;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(63, 197);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(102, 13);
            this.lblClasse.TabIndex = 92;
            this.lblClasse.Text = "Libelle de la classe :";
            // 
            // dateVstPicker
            // 
            this.dateVstPicker.Location = new System.Drawing.Point(198, 237);
            this.dateVstPicker.Name = "dateVstPicker";
            this.dateVstPicker.Size = new System.Drawing.Size(191, 20);
            this.dateVstPicker.TabIndex = 94;
            // 
            // dateVstLbl
            // 
            this.dateVstLbl.AutoSize = true;
            this.dateVstLbl.Location = new System.Drawing.Point(63, 241);
            this.dateVstLbl.Name = "dateVstLbl";
            this.dateVstLbl.Size = new System.Drawing.Size(89, 13);
            this.dateVstLbl.TabIndex = 95;
            this.dateVstLbl.Text = "Date de la visite :";
            // 
            // hrArvLbl
            // 
            this.hrArvLbl.AutoSize = true;
            this.hrArvLbl.Location = new System.Drawing.Point(63, 267);
            this.hrArvLbl.Name = "hrArvLbl";
            this.hrArvLbl.Size = new System.Drawing.Size(85, 13);
            this.hrArvLbl.TabIndex = 97;
            this.hrArvLbl.Text = "Heure d\'arrivée :";
            // 
            // dateTimeArv
            // 
            this.dateTimeArv.Location = new System.Drawing.Point(198, 263);
            this.dateTimeArv.Name = "dateTimeArv";
            this.dateTimeArv.Size = new System.Drawing.Size(191, 20);
            this.dateTimeArv.TabIndex = 96;
            // 
            // hrDepLbl
            // 
            this.hrDepLbl.AutoSize = true;
            this.hrDepLbl.Location = new System.Drawing.Point(63, 293);
            this.hrDepLbl.Name = "hrDepLbl";
            this.hrDepLbl.Size = new System.Drawing.Size(90, 13);
            this.hrDepLbl.TabIndex = 99;
            this.hrDepLbl.Text = "Heure de départ :";
            // 
            // dateTimeDep
            // 
            this.dateTimeDep.Location = new System.Drawing.Point(198, 289);
            this.dateTimeDep.Name = "dateTimeDep";
            this.dateTimeDep.Size = new System.Drawing.Size(191, 20);
            this.dateTimeDep.TabIndex = 98;
            // 
            // commentVst
            // 
            this.commentVst.AutoSize = true;
            this.commentVst.Location = new System.Drawing.Point(63, 344);
            this.commentVst.Name = "commentVst";
            this.commentVst.Size = new System.Drawing.Size(74, 13);
            this.commentVst.TabIndex = 100;
            this.commentVst.Text = "Commentaire :";
            // 
            // commentTxtbx
            // 
            this.commentTxtbx.Location = new System.Drawing.Point(198, 341);
            this.commentTxtbx.Name = "commentTxtbx";
            this.commentTxtbx.Size = new System.Drawing.Size(191, 20);
            this.commentTxtbx.TabIndex = 101;
            // 
            // poulsLbl
            // 
            this.poulsLbl.AutoSize = true;
            this.poulsLbl.Location = new System.Drawing.Point(63, 370);
            this.poulsLbl.Name = "poulsLbl";
            this.poulsLbl.Size = new System.Drawing.Size(39, 13);
            this.poulsLbl.TabIndex = 102;
            this.poulsLbl.Text = "Pouls :";
            // 
            // motifTxtbx
            // 
            this.motifTxtbx.Location = new System.Drawing.Point(198, 315);
            this.motifTxtbx.Name = "motifTxtbx";
            this.motifTxtbx.Size = new System.Drawing.Size(191, 20);
            this.motifTxtbx.TabIndex = 105;
            // 
            // motifLbl
            // 
            this.motifLbl.AutoSize = true;
            this.motifLbl.Location = new System.Drawing.Point(63, 318);
            this.motifLbl.Name = "motifLbl";
            this.motifLbl.Size = new System.Drawing.Size(83, 13);
            this.motifLbl.TabIndex = 104;
            this.motifLbl.Text = "Motif de la visite";
            // 
            // prescriptionLbl
            // 
            this.prescriptionLbl.AutoSize = true;
            this.prescriptionLbl.Location = new System.Drawing.Point(63, 395);
            this.prescriptionLbl.Name = "prescriptionLbl";
            this.prescriptionLbl.Size = new System.Drawing.Size(68, 13);
            this.prescriptionLbl.TabIndex = 106;
            this.prescriptionLbl.Text = "Prescription :";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(209, 622);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 117;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(290, 622);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 116;
            this.cancelBtn.Text = "Fermer";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // backHomeYes
            // 
            this.backHomeYes.AutoSize = true;
            this.backHomeYes.Location = new System.Drawing.Point(24, 45);
            this.backHomeYes.Name = "backHomeYes";
            this.backHomeYes.Size = new System.Drawing.Size(41, 17);
            this.backHomeYes.TabIndex = 118;
            this.backHomeYes.Text = "Oui";
            this.backHomeYes.UseVisualStyleBackColor = true;
            // 
            // tellPrYes
            // 
            this.tellPrYes.AutoSize = true;
            this.tellPrYes.Location = new System.Drawing.Point(23, 45);
            this.tellPrYes.Name = "tellPrYes";
            this.tellPrYes.Size = new System.Drawing.Size(41, 17);
            this.tellPrYes.TabIndex = 119;
            this.tellPrYes.Text = "Oui";
            this.tellPrYes.UseVisualStyleBackColor = true;
            // 
            // hospitalYes
            // 
            this.hospitalYes.AutoSize = true;
            this.hospitalYes.Location = new System.Drawing.Point(19, 45);
            this.hospitalYes.Name = "hospitalYes";
            this.hospitalYes.Size = new System.Drawing.Size(41, 17);
            this.hospitalYes.TabIndex = 120;
            this.hospitalYes.Text = "Oui";
            this.hospitalYes.UseVisualStyleBackColor = true;
            // 
            // backHomeNo
            // 
            this.backHomeNo.AutoSize = true;
            this.backHomeNo.Checked = true;
            this.backHomeNo.Location = new System.Drawing.Point(24, 68);
            this.backHomeNo.Name = "backHomeNo";
            this.backHomeNo.Size = new System.Drawing.Size(45, 17);
            this.backHomeNo.TabIndex = 121;
            this.backHomeNo.TabStop = true;
            this.backHomeNo.Text = "Non";
            this.backHomeNo.UseVisualStyleBackColor = true;
            // 
            // tellPrNo
            // 
            this.tellPrNo.AutoSize = true;
            this.tellPrNo.Checked = true;
            this.tellPrNo.Location = new System.Drawing.Point(23, 68);
            this.tellPrNo.Name = "tellPrNo";
            this.tellPrNo.Size = new System.Drawing.Size(45, 17);
            this.tellPrNo.TabIndex = 122;
            this.tellPrNo.TabStop = true;
            this.tellPrNo.Text = "Non";
            this.tellPrNo.UseVisualStyleBackColor = true;
            this.tellPrNo.CheckedChanged += new System.EventHandler(this.nomElv_list_SelectionChangeCommitted);
            // 
            // hospitalNo
            // 
            this.hospitalNo.AutoSize = true;
            this.hospitalNo.Checked = true;
            this.hospitalNo.Location = new System.Drawing.Point(20, 68);
            this.hospitalNo.Name = "hospitalNo";
            this.hospitalNo.Size = new System.Drawing.Size(45, 17);
            this.hospitalNo.TabIndex = 123;
            this.hospitalNo.TabStop = true;
            this.hospitalNo.Text = "Non";
            this.hospitalNo.UseVisualStyleBackColor = true;
            // 
            // backHomeGroup
            // 
            this.backHomeGroup.Controls.Add(this.backHomeNo);
            this.backHomeGroup.Controls.Add(this.backHomeYes);
            this.backHomeGroup.Location = new System.Drawing.Point(66, 475);
            this.backHomeGroup.Name = "backHomeGroup";
            this.backHomeGroup.Size = new System.Drawing.Size(99, 103);
            this.backHomeGroup.TabIndex = 124;
            this.backHomeGroup.TabStop = false;
            this.backHomeGroup.Text = "Retour au domicile";
            // 
            // hospitalGroup
            // 
            this.hospitalGroup.Controls.Add(this.hospitalNo);
            this.hospitalGroup.Controls.Add(this.hospitalYes);
            this.hospitalGroup.Location = new System.Drawing.Point(179, 475);
            this.hospitalGroup.Name = "hospitalGroup";
            this.hospitalGroup.Size = new System.Drawing.Size(99, 103);
            this.hospitalGroup.TabIndex = 125;
            this.hospitalGroup.TabStop = false;
            this.hospitalGroup.Text = "Hôpital";
            // 
            // tellPrGroup
            // 
            this.tellPrGroup.Controls.Add(this.tellPrYes);
            this.tellPrGroup.Controls.Add(this.tellPrNo);
            this.tellPrGroup.Location = new System.Drawing.Point(290, 475);
            this.tellPrGroup.Name = "tellPrGroup";
            this.tellPrGroup.Size = new System.Drawing.Size(99, 103);
            this.tellPrGroup.TabIndex = 126;
            this.tellPrGroup.TabStop = false;
            this.tellPrGroup.Text = "Parents prévenus";
            // 
            // lblMdc_list
            // 
            this.lblMdc_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblMdc_list.FormattingEnabled = true;
            this.lblMdc_list.Location = new System.Drawing.Point(198, 392);
            this.lblMdc_list.Name = "lblMdc_list";
            this.lblMdc_list.Size = new System.Drawing.Size(191, 21);
            this.lblMdc_list.TabIndex = 123;
            // 
            // poulsNumUpDown
            // 
            this.poulsNumUpDown.Location = new System.Drawing.Point(198, 368);
            this.poulsNumUpDown.Name = "poulsNumUpDown";
            this.poulsNumUpDown.Size = new System.Drawing.Size(191, 20);
            this.poulsNumUpDown.TabIndex = 127;
            this.poulsNumUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // qteNumUpDown
            // 
            this.qteNumUpDown.Location = new System.Drawing.Point(198, 419);
            this.qteNumUpDown.Name = "qteNumUpDown";
            this.qteNumUpDown.Size = new System.Drawing.Size(191, 20);
            this.qteNumUpDown.TabIndex = 128;
            // 
            // qteLbl
            // 
            this.qteLbl.AutoSize = true;
            this.qteLbl.Location = new System.Drawing.Point(63, 421);
            this.qteLbl.Name = "qteLbl";
            this.qteLbl.Size = new System.Drawing.Size(53, 13);
            this.qteLbl.TabIndex = 108;
            this.qteLbl.Text = "Quantité :";
            // 
            // FrmAjoutVst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 669);
            this.Controls.Add(this.qteNumUpDown);
            this.Controls.Add(this.poulsNumUpDown);
            this.Controls.Add(this.lblMdc_list);
            this.Controls.Add(this.tellPrGroup);
            this.Controls.Add(this.hospitalGroup);
            this.Controls.Add(this.backHomeGroup);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.qteLbl);
            this.Controls.Add(this.prescriptionLbl);
            this.Controls.Add(this.motifTxtbx);
            this.Controls.Add(this.motifLbl);
            this.Controls.Add(this.poulsLbl);
            this.Controls.Add(this.commentTxtbx);
            this.Controls.Add(this.commentVst);
            this.Controls.Add(this.hrDepLbl);
            this.Controls.Add(this.dateTimeDep);
            this.Controls.Add(this.hrArvLbl);
            this.Controls.Add(this.dateTimeArv);
            this.Controls.Add(this.dateVstLbl);
            this.Controls.Add(this.dateVstPicker);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.ModifEleve);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.prenomEleve_txt);
            this.Controls.Add(this.prenomEleve);
            this.Controls.Add(this.nomEleve);
            this.Controls.Add(this.nomElv_cmbx);
            this.Name = "FrmAjoutVst";
            this.Text = "FrmAjoutVst";
            this.backHomeGroup.ResumeLayout(false);
            this.backHomeGroup.PerformLayout();
            this.hospitalGroup.ResumeLayout(false);
            this.hospitalGroup.PerformLayout();
            this.tellPrGroup.ResumeLayout(false);
            this.tellPrGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poulsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qteNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateNaissance;
        private System.Windows.Forms.TextBox prenomEleve_txt;
        private System.Windows.Forms.Label prenomEleve;
        private System.Windows.Forms.Label nomEleve;
        private System.Windows.Forms.ComboBox nomElv_cmbx;
        private System.Windows.Forms.Label ModifEleve;
        private System.Windows.Forms.ComboBox lblClasse_cmbx;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.DateTimePicker dateVstPicker;
        private System.Windows.Forms.Label dateVstLbl;
        private System.Windows.Forms.Label hrArvLbl;
        private System.Windows.Forms.DateTimePicker dateTimeArv;
        private System.Windows.Forms.Label hrDepLbl;
        private System.Windows.Forms.DateTimePicker dateTimeDep;
        private System.Windows.Forms.Label commentVst;
        private System.Windows.Forms.TextBox commentTxtbx;
        private System.Windows.Forms.Label poulsLbl;
        private System.Windows.Forms.TextBox motifTxtbx;
        private System.Windows.Forms.Label motifLbl;
        private System.Windows.Forms.Label prescriptionLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton backHomeYes;
        private System.Windows.Forms.RadioButton tellPrYes;
        private System.Windows.Forms.RadioButton hospitalYes;
        private System.Windows.Forms.RadioButton backHomeNo;
        private System.Windows.Forms.RadioButton tellPrNo;
        private System.Windows.Forms.RadioButton hospitalNo;
        private System.Windows.Forms.GroupBox backHomeGroup;
        private System.Windows.Forms.GroupBox hospitalGroup;
        private System.Windows.Forms.GroupBox tellPrGroup;
        private System.Windows.Forms.ComboBox lblMdc_list;
        private System.Windows.Forms.NumericUpDown poulsNumUpDown;
        private System.Windows.Forms.NumericUpDown qteNumUpDown;
        private System.Windows.Forms.Label qteLbl;
    }
}