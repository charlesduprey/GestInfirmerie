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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifMdc));
            this.frmModifLbl = new System.Windows.Forms.Label();
            this.libelleMdcCmbx = new System.Windows.Forms.ComboBox();
            this.libelleMdcLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.errProSave = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProMdcTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.archBtn = new System.Windows.Forms.Button();
            this.suprBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProMdcTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // frmModifLbl
            // 
            this.frmModifLbl.AutoSize = true;
            this.frmModifLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModifLbl.Location = new System.Drawing.Point(15, 9);
            this.frmModifLbl.Name = "frmModifLbl";
            this.frmModifLbl.Size = new System.Drawing.Size(331, 39);
            this.frmModifLbl.TabIndex = 0;
            this.frmModifLbl.Text = "Modifier un médicament";
            // 
            // libelleMdcCmbx
            // 
            this.libelleMdcCmbx.FormattingEnabled = true;
            this.libelleMdcCmbx.Location = new System.Drawing.Point(155, 61);
            this.libelleMdcCmbx.Name = "libelleMdcCmbx";
            this.libelleMdcCmbx.Size = new System.Drawing.Size(121, 21);
            this.libelleMdcCmbx.TabIndex = 1;
            this.libelleMdcCmbx.SelectionChangeCommitted += new System.EventHandler(this.libelleMdcCmbx_SelectionChangeCommitted);
            this.libelleMdcCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.libelleMdcCmbx_Validating);
            // 
            // libelleMdcLbl
            // 
            this.libelleMdcLbl.AutoSize = true;
            this.libelleMdcLbl.Location = new System.Drawing.Point(73, 64);
            this.libelleMdcLbl.Name = "libelleMdcLbl";
            this.libelleMdcLbl.Size = new System.Drawing.Size(76, 13);
            this.libelleMdcLbl.TabIndex = 2;
            this.libelleMdcLbl.Text = "Médicaments :";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(184, 99);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.Validating += new System.ComponentModel.CancelEventHandler(this.saveBtn_Validating);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(271, 99);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errProSave
            // 
            this.errProSave.ContainerControl = this;
            // 
            // errProMdcTxt
            // 
            this.errProMdcTxt.ContainerControl = this;
            // 
            // archBtn
            // 
            this.archBtn.Location = new System.Drawing.Point(22, 99);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(75, 23);
            this.archBtn.TabIndex = 84;
            this.archBtn.Text = "Archiver";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.Click += new System.EventHandler(this.archBtn_Click);
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(103, 99);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 83;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // FrmModifMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 133);
            this.Controls.Add(this.archBtn);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.libelleMdcLbl);
            this.Controls.Add(this.libelleMdcCmbx);
            this.Controls.Add(this.frmModifLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModifMdc";
            this.Text = "FrmModifMdc";
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProMdcTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmModifLbl;
        private System.Windows.Forms.ComboBox libelleMdcCmbx;
        private System.Windows.Forms.Label libelleMdcLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ErrorProvider errProSave;
        private System.Windows.Forms.ErrorProvider errProMdcTxt;
        private System.Windows.Forms.Button archBtn;
        private System.Windows.Forms.Button suprBtn;
    }
}