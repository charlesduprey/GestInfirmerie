namespace UtilisateursGUI.GestionElv
{
    partial class FrmModuleLectureElv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuleLectureElv));
            this.modifBtn = new System.Windows.Forms.Button();
            this.fmrButton = new System.Windows.Forms.Button();
            this.actualiserBtn = new System.Windows.Forms.Button();
            this.StudentsView = new System.Windows.Forms.DataGridView();
            this.ajoutBtn = new System.Windows.Forms.Button();
            this.elvArchBtn = new System.Windows.Forms.Button();
            this.elvNonArchBtn = new System.Windows.Forms.Button();
            this.elementsAffiches = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifBtn
            // 
            this.modifBtn.Location = new System.Drawing.Point(743, 479);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(106, 23);
            this.modifBtn.TabIndex = 11;
            this.modifBtn.Text = "Modifier/Supprimer";
            this.modifBtn.UseVisualStyleBackColor = true;
            this.modifBtn.Click += new System.EventHandler(this.modifBtn_Click);
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(885, 479);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(75, 23);
            this.fmrButton.TabIndex = 10;
            this.fmrButton.Text = "Fermer";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.Location = new System.Drawing.Point(457, 479);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(131, 23);
            this.actualiserBtn.TabIndex = 9;
            this.actualiserBtn.Text = "Voir tous les eleves";
            this.actualiserBtn.UseVisualStyleBackColor = true;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // StudentsView
            // 
            this.StudentsView.AllowUserToAddRows = false;
            this.StudentsView.AllowUserToDeleteRows = false;
            this.StudentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsView.Location = new System.Drawing.Point(12, 83);
            this.StudentsView.Name = "StudentsView";
            this.StudentsView.ReadOnly = true;
            this.StudentsView.Size = new System.Drawing.Size(960, 346);
            this.StudentsView.TabIndex = 8;
            // 
            // ajoutBtn
            // 
            this.ajoutBtn.Location = new System.Drawing.Point(662, 479);
            this.ajoutBtn.Name = "ajoutBtn";
            this.ajoutBtn.Size = new System.Drawing.Size(75, 23);
            this.ajoutBtn.TabIndex = 13;
            this.ajoutBtn.Text = "Ajouter";
            this.ajoutBtn.UseVisualStyleBackColor = true;
            this.ajoutBtn.Click += new System.EventHandler(this.ajoutBtn_Click);
            // 
            // elvArchBtn
            // 
            this.elvArchBtn.Location = new System.Drawing.Point(197, 479);
            this.elvArchBtn.Name = "elvArchBtn";
            this.elvArchBtn.Size = new System.Drawing.Size(124, 23);
            this.elvArchBtn.TabIndex = 14;
            this.elvArchBtn.Text = "Élèves Archivés";
            this.elvArchBtn.UseVisualStyleBackColor = true;
            this.elvArchBtn.Click += new System.EventHandler(this.elvArchBtn_Click);
            // 
            // elvNonArchBtn
            // 
            this.elvNonArchBtn.Location = new System.Drawing.Point(327, 479);
            this.elvNonArchBtn.Name = "elvNonArchBtn";
            this.elvNonArchBtn.Size = new System.Drawing.Size(124, 23);
            this.elvNonArchBtn.TabIndex = 15;
            this.elvNonArchBtn.Text = "Élèves non archivés";
            this.elvNonArchBtn.UseVisualStyleBackColor = true;
            this.elvNonArchBtn.Click += new System.EventHandler(this.elvNonArchBtn_Click);
            // 
            // elementsAffiches
            // 
            this.elementsAffiches.AutoSize = true;
            this.elementsAffiches.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsAffiches.Location = new System.Drawing.Point(307, 23);
            this.elementsAffiches.Name = "elementsAffiches";
            this.elementsAffiches.Size = new System.Drawing.Size(365, 39);
            this.elementsAffiches.TabIndex = 16;
            this.elementsAffiches.Text = "Affichage de tous les élèves";
            // 
            // FrmModuleLectureElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 527);
            this.Controls.Add(this.elementsAffiches);
            this.Controls.Add(this.elvNonArchBtn);
            this.Controls.Add(this.elvArchBtn);
            this.Controls.Add(this.ajoutBtn);
            this.Controls.Add(this.modifBtn);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.StudentsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModuleLectureElv";
            this.Text = "Affichage des élèves";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifBtn;
        private System.Windows.Forms.Button fmrButton;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.DataGridView StudentsView;
        private System.Windows.Forms.Button ajoutBtn;
        private System.Windows.Forms.Button elvArchBtn;
        private System.Windows.Forms.Button elvNonArchBtn;
        private System.Windows.Forms.Label elementsAffiches;
    }
}