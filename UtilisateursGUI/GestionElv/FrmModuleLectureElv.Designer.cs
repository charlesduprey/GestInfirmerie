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
            this.modifBtn = new System.Windows.Forms.Button();
            this.fmrButton = new System.Windows.Forms.Button();
            this.actualiserBtn = new System.Windows.Forms.Button();
            this.StudentsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifBtn
            // 
            this.modifBtn.Location = new System.Drawing.Point(728, 449);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(75, 23);
            this.modifBtn.TabIndex = 11;
            this.modifBtn.Text = "Modifier";
            this.modifBtn.UseVisualStyleBackColor = true;
            this.modifBtn.Click += new System.EventHandler(this.modifBtn_Click);
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(918, 449);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(75, 23);
            this.fmrButton.TabIndex = 10;
            this.fmrButton.Text = "Fermer";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.Location = new System.Drawing.Point(822, 449);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(75, 23);
            this.actualiserBtn.TabIndex = 9;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = true;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // StudentsView
            // 
            this.StudentsView.AllowUserToAddRows = false;
            this.StudentsView.AllowUserToDeleteRows = false;
            this.StudentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsView.Location = new System.Drawing.Point(12, 12);
            this.StudentsView.Name = "StudentsView";
            this.StudentsView.ReadOnly = true;
            this.StudentsView.Size = new System.Drawing.Size(1087, 404);
            this.StudentsView.TabIndex = 8;
            // 
            // FrmModuleLectureElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 497);
            this.Controls.Add(this.modifBtn);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.StudentsView);
            this.Name = "FrmModuleLectureElv";
            this.Text = "FrmModuleLectureElv";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modifBtn;
        private System.Windows.Forms.Button fmrButton;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.DataGridView StudentsView;
    }
}