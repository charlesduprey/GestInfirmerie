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
            this.fmrButton = new System.Windows.Forms.Button();
            this.appelMdlLectureGestElv = new System.Windows.Forms.Button();
            this.gestElv = new System.Windows.Forms.Label();
            this.gestMdc = new System.Windows.Forms.Label();
            this.appelMdlLectureGestMdc = new System.Windows.Forms.Button();
            this.ajoutElvBtn = new System.Windows.Forms.Button();
            this.ajoutMdcBtn = new System.Windows.Forms.Button();
            this.modifMdcBtn = new System.Windows.Forms.Button();
            this.suprMdcBtn = new System.Windows.Forms.Button();
            this.modifElvBtn = new System.Windows.Forms.Button();
            this.suprElvBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(162, 247);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(90, 23);
            this.fmrButton.TabIndex = 5;
            this.fmrButton.Text = "Fermer";
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
            this.modifMdcBtn.Text = "Modifier";
            this.modifMdcBtn.UseVisualStyleBackColor = true;
            this.modifMdcBtn.Click += new System.EventHandler(this.modifMdcBtn_Click);
            // 
            // suprMdcBtn
            // 
            this.suprMdcBtn.Location = new System.Drawing.Point(242, 139);
            this.suprMdcBtn.Name = "suprMdcBtn";
            this.suprMdcBtn.Size = new System.Drawing.Size(108, 29);
            this.suprMdcBtn.TabIndex = 12;
            this.suprMdcBtn.Text = "Supprimer";
            this.suprMdcBtn.UseVisualStyleBackColor = true;
            this.suprMdcBtn.Click += new System.EventHandler(this.suprMdcBtn_Click);
            // 
            // modifElvBtn
            // 
            this.modifElvBtn.Location = new System.Drawing.Point(72, 106);
            this.modifElvBtn.Name = "modifElvBtn";
            this.modifElvBtn.Size = new System.Drawing.Size(108, 27);
            this.modifElvBtn.TabIndex = 13;
            this.modifElvBtn.Text = "Modifier";
            this.modifElvBtn.UseVisualStyleBackColor = true;
            this.modifElvBtn.Click += new System.EventHandler(this.modifElvBtn_Click);
            // 
            // suprElvBtn
            // 
            this.suprElvBtn.Location = new System.Drawing.Point(72, 139);
            this.suprElvBtn.Name = "suprElvBtn";
            this.suprElvBtn.Size = new System.Drawing.Size(108, 27);
            this.suprElvBtn.TabIndex = 14;
            this.suprElvBtn.Text = "Supprimer";
            this.suprElvBtn.UseVisualStyleBackColor = true;
            this.suprElvBtn.Click += new System.EventHandler(this.suprElvBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 298);
            this.Controls.Add(this.suprElvBtn);
            this.Controls.Add(this.modifElvBtn);
            this.Controls.Add(this.suprMdcBtn);
            this.Controls.Add(this.modifMdcBtn);
            this.Controls.Add(this.ajoutMdcBtn);
            this.Controls.Add(this.ajoutElvBtn);
            this.Controls.Add(this.appelMdlLectureGestMdc);
            this.Controls.Add(this.gestMdc);
            this.Controls.Add(this.gestElv);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.appelMdlLectureGestElv);
            this.Name = "Menu";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button suprMdcBtn;
        private System.Windows.Forms.Button modifElvBtn;
        private System.Windows.Forms.Button suprElvBtn;
    }
}

