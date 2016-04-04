namespace UtilisateursGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.fmrButton = new System.Windows.Forms.Button();
            this.appelMdlLectureGestElv = new System.Windows.Forms.Button();
            this.gestElv = new System.Windows.Forms.Label();
            this.gestMdc = new System.Windows.Forms.Label();
            this.appelMdlLectureGestMdc = new System.Windows.Forms.Button();
            this.ajoutElvBtn = new System.Windows.Forms.Button();
            this.ajoutMdcBtn = new System.Windows.Forms.Button();
            this.modifMdcBtn = new System.Windows.Forms.Button();
            this.modifElvBtn = new System.Windows.Forms.Button();
            this.modifVstBtn = new System.Windows.Forms.Button();
            this.ajoutVstBtn = new System.Windows.Forms.Button();
            this.appelMdlLectureGestVst = new System.Windows.Forms.Button();
            this.gestVst = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(380, 254);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(108, 23);
            this.fmrButton.TabIndex = 5;
            this.fmrButton.Text = "Fermer l\'application";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // appelMdlLectureGestElv
            // 
            this.appelMdlLectureGestElv.Location = new System.Drawing.Point(72, 174);
            this.appelMdlLectureGestElv.Name = "appelMdlLectureGestElv";
            this.appelMdlLectureGestElv.Size = new System.Drawing.Size(108, 27);
            this.appelMdlLectureGestElv.TabIndex = 4;
            this.appelMdlLectureGestElv.Text = "Module Lecture";
            this.appelMdlLectureGestElv.UseVisualStyleBackColor = true;
            this.appelMdlLectureGestElv.Click += new System.EventHandler(this.appelMdlLectureGestElv_Click);
            // 
            // gestElv
            // 
            this.gestElv.AutoSize = true;
            this.gestElv.Location = new System.Drawing.Point(69, 41);
            this.gestElv.Name = "gestElv";
            this.gestElv.Size = new System.Drawing.Size(97, 13);
            this.gestElv.TabIndex = 6;
            this.gestElv.Text = "Gestion des élèves";
            // 
            // gestMdc
            // 
            this.gestMdc.AutoSize = true;
            this.gestMdc.Location = new System.Drawing.Point(233, 41);
            this.gestMdc.Name = "gestMdc";
            this.gestMdc.Size = new System.Drawing.Size(128, 13);
            this.gestMdc.TabIndex = 7;
            this.gestMdc.Text = "Gestion des médicaments";
            // 
            // appelMdlLectureGestMdc
            // 
            this.appelMdlLectureGestMdc.Location = new System.Drawing.Point(242, 174);
            this.appelMdlLectureGestMdc.Name = "appelMdlLectureGestMdc";
            this.appelMdlLectureGestMdc.Size = new System.Drawing.Size(108, 27);
            this.appelMdlLectureGestMdc.TabIndex = 8;
            this.appelMdlLectureGestMdc.Text = "Module Lecture";
            this.appelMdlLectureGestMdc.UseVisualStyleBackColor = true;
            this.appelMdlLectureGestMdc.Click += new System.EventHandler(this.appelMdlLectureGestMdc_Click);
            // 
            // ajoutElvBtn
            // 
            this.ajoutElvBtn.Location = new System.Drawing.Point(72, 71);
            this.ajoutElvBtn.Name = "ajoutElvBtn";
            this.ajoutElvBtn.Size = new System.Drawing.Size(108, 27);
            this.ajoutElvBtn.TabIndex = 9;
            this.ajoutElvBtn.Text = "Ajouter";
            this.ajoutElvBtn.UseVisualStyleBackColor = true;
            this.ajoutElvBtn.Click += new System.EventHandler(this.ajoutElvBtn_Click);
            // 
            // ajoutMdcBtn
            // 
            this.ajoutMdcBtn.Location = new System.Drawing.Point(242, 71);
            this.ajoutMdcBtn.Name = "ajoutMdcBtn";
            this.ajoutMdcBtn.Size = new System.Drawing.Size(108, 27);
            this.ajoutMdcBtn.TabIndex = 10;
            this.ajoutMdcBtn.Text = "Ajouter";
            this.ajoutMdcBtn.UseVisualStyleBackColor = true;
            this.ajoutMdcBtn.Click += new System.EventHandler(this.ajoutMdcBtn_Click);
            // 
            // modifMdcBtn
            // 
            this.modifMdcBtn.Location = new System.Drawing.Point(242, 104);
            this.modifMdcBtn.Name = "modifMdcBtn";
            this.modifMdcBtn.Size = new System.Drawing.Size(108, 29);
            this.modifMdcBtn.TabIndex = 11;
            this.modifMdcBtn.Text = "Modifier/supprimer";
            this.modifMdcBtn.UseVisualStyleBackColor = true;
            this.modifMdcBtn.Click += new System.EventHandler(this.modifMdcBtn_Click);
            // 
            // modifElvBtn
            // 
            this.modifElvBtn.Location = new System.Drawing.Point(72, 104);
            this.modifElvBtn.Name = "modifElvBtn";
            this.modifElvBtn.Size = new System.Drawing.Size(108, 29);
            this.modifElvBtn.TabIndex = 13;
            this.modifElvBtn.Text = "Modifier/supprimer";
            this.modifElvBtn.UseVisualStyleBackColor = true;
            this.modifElvBtn.Click += new System.EventHandler(this.modifElvBtn_Click);
            // 
            // modifVstBtn
            // 
            this.modifVstBtn.Location = new System.Drawing.Point(409, 104);
            this.modifVstBtn.Name = "modifVstBtn";
            this.modifVstBtn.Size = new System.Drawing.Size(108, 29);
            this.modifVstBtn.TabIndex = 18;
            this.modifVstBtn.Text = "Modifier";
            this.modifVstBtn.UseVisualStyleBackColor = true;
            this.modifVstBtn.Click += new System.EventHandler(this.modifVstBtn_Click);
            // 
            // ajoutVstBtn
            // 
            this.ajoutVstBtn.Location = new System.Drawing.Point(409, 71);
            this.ajoutVstBtn.Name = "ajoutVstBtn";
            this.ajoutVstBtn.Size = new System.Drawing.Size(108, 27);
            this.ajoutVstBtn.TabIndex = 17;
            this.ajoutVstBtn.Text = "Ajouter";
            this.ajoutVstBtn.UseVisualStyleBackColor = true;
            this.ajoutVstBtn.Click += new System.EventHandler(this.ajoutVstBtn_Click);
            // 
            // appelMdlLectureGestVst
            // 
            this.appelMdlLectureGestVst.Location = new System.Drawing.Point(409, 174);
            this.appelMdlLectureGestVst.Name = "appelMdlLectureGestVst";
            this.appelMdlLectureGestVst.Size = new System.Drawing.Size(108, 27);
            this.appelMdlLectureGestVst.TabIndex = 16;
            this.appelMdlLectureGestVst.Text = "Module Lecture";
            this.appelMdlLectureGestVst.UseVisualStyleBackColor = true;
            this.appelMdlLectureGestVst.Click += new System.EventHandler(this.appelMdlLectureGestVst_Click);
            // 
            // gestVst
            // 
            this.gestVst.AutoSize = true;
            this.gestVst.Location = new System.Drawing.Point(413, 41);
            this.gestVst.Name = "gestVst";
            this.gestVst.Size = new System.Drawing.Size(95, 13);
            this.gestVst.TabIndex = 15;
            this.gestVst.Text = "Gestion des visites";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Administration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifVstBtn);
            this.Controls.Add(this.ajoutVstBtn);
            this.Controls.Add(this.appelMdlLectureGestVst);
            this.Controls.Add(this.gestVst);
            this.Controls.Add(this.modifElvBtn);
            this.Controls.Add(this.modifMdcBtn);
            this.Controls.Add(this.ajoutMdcBtn);
            this.Controls.Add(this.ajoutElvBtn);
            this.Controls.Add(this.appelMdlLectureGestMdc);
            this.Controls.Add(this.gestMdc);
            this.Controls.Add(this.gestElv);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.appelMdlLectureGestElv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu de l\'application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fmrButton;
        private System.Windows.Forms.Button appelMdlLectureGestElv;
        private System.Windows.Forms.Label gestElv;
        private System.Windows.Forms.Label gestMdc;
        private System.Windows.Forms.Button appelMdlLectureGestMdc;
        private System.Windows.Forms.Button ajoutElvBtn;
        private System.Windows.Forms.Button ajoutMdcBtn;
        private System.Windows.Forms.Button modifMdcBtn;
        private System.Windows.Forms.Button modifElvBtn;
        private System.Windows.Forms.Button modifVstBtn;
        private System.Windows.Forms.Button ajoutVstBtn;
        private System.Windows.Forms.Button appelMdlLectureGestVst;
        private System.Windows.Forms.Label gestVst;
        private System.Windows.Forms.Button button1;
    }
}

