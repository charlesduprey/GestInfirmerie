namespace UtilisateursGUI.GestionMdc
{
    partial class FrmModifMdc
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
            this.label1 = new System.Windows.Forms.Label();
            this.LibelleLbl = new System.Windows.Forms.Label();
            this.libelleMdcLbl = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LibelleLbl
            // 
            this.LibelleLbl.AutoSize = true;
            this.LibelleLbl.Location = new System.Drawing.Point(55, 87);
            this.LibelleLbl.Name = "LibelleLbl";
            this.LibelleLbl.Size = new System.Drawing.Size(37, 13);
            this.LibelleLbl.TabIndex = 1;
            this.LibelleLbl.Text = "Libellé";
            // 
            // libelleMdcLbl
            // 
            this.libelleMdcLbl.FormattingEnabled = true;
            this.libelleMdcLbl.Location = new System.Drawing.Point(127, 84);
            this.libelleMdcLbl.Name = "libelleMdcLbl";
            this.libelleMdcLbl.Size = new System.Drawing.Size(176, 21);
            this.libelleMdcLbl.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(83, 190);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(188, 190);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FrmModifMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 256);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.libelleMdcLbl);
            this.Controls.Add(this.LibelleLbl);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifMdc";
            this.Text = "FrmModifMdc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LibelleLbl;
        private System.Windows.Forms.ComboBox libelleMdcLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}