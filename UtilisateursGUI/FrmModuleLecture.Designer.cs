namespace UtilisateursGUI
{
    partial class FrmModuleLecture
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
            this.StudentsView = new System.Windows.Forms.DataGridView();
            this.actualiserBtn = new System.Windows.Forms.Button();
            this.fmrButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsView
            // 
            this.StudentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsView.Location = new System.Drawing.Point(12, 12);
            this.StudentsView.Name = "StudentsView";
            this.StudentsView.Size = new System.Drawing.Size(1087, 404);
            this.StudentsView.TabIndex = 0;
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.Location = new System.Drawing.Point(822, 449);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(75, 23);
            this.actualiserBtn.TabIndex = 1;
            this.actualiserBtn.Text = "Acttualiser";
            this.actualiserBtn.UseVisualStyleBackColor = true;
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(918, 449);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(75, 23);
            this.fmrButton.TabIndex = 2;
            this.fmrButton.Text = "Fermer";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // FrmModuleLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 508);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.StudentsView);
            this.Name = "FrmModuleLecture";
            this.Text = "FrmModuleLecture";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsView;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.Button fmrButton;
    }
}