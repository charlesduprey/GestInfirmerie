namespace UtilisateursGUI.GestionMdc
{
    partial class FrmSuprMdc
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
            this.suprBtn = new System.Windows.Forms.Button();
            this.SuprMdc = new System.Windows.Forms.Label();
            this.lblMdc = new System.Windows.Forms.Label();
            this.lblMdc_list = new System.Windows.Forms.ComboBox();
            this.close_button = new System.Windows.Forms.Button();
            this.archBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(108, 108);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 81;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // SuprMdc
            // 
            this.SuprMdc.AutoSize = true;
            this.SuprMdc.Location = new System.Drawing.Point(79, 23);
            this.SuprMdc.Name = "SuprMdc";
            this.SuprMdc.Size = new System.Drawing.Size(140, 13);
            this.SuprMdc.TabIndex = 71;
            this.SuprMdc.Text = "Suppression du médicament";
            this.SuprMdc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMdc
            // 
            this.lblMdc.AutoSize = true;
            this.lblMdc.Location = new System.Drawing.Point(24, 65);
            this.lblMdc.Name = "lblMdc";
            this.lblMdc.Size = new System.Drawing.Size(43, 13);
            this.lblMdc.TabIndex = 67;
            this.lblMdc.Text = "Libellé :";
            // 
            // lblMdc_list
            // 
            this.lblMdc_list.FormattingEnabled = true;
            this.lblMdc_list.Location = new System.Drawing.Point(99, 62);
            this.lblMdc_list.Name = "lblMdc_list";
            this.lblMdc_list.Size = new System.Drawing.Size(191, 21);
            this.lblMdc_list.TabIndex = 66;
            this.lblMdc_list.SelectionChangeCommitted += new System.EventHandler(this.lblMdc_list_SelectionChangeCommitted);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(189, 108);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 65;
            this.close_button.Text = "Fermer";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // archBtn
            // 
            this.archBtn.Location = new System.Drawing.Point(27, 108);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(75, 23);
            this.archBtn.TabIndex = 82;
            this.archBtn.Text = "Archiver";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.Click += new System.EventHandler(this.archBtn_Click);
            // 
            // FrmSuprMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 157);
            this.Controls.Add(this.archBtn);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.SuprMdc);
            this.Controls.Add(this.lblMdc);
            this.Controls.Add(this.lblMdc_list);
            this.Controls.Add(this.close_button);
            this.Name = "FrmSuprMdc";
            this.Text = "FrmSuprMdc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suprBtn;
        private System.Windows.Forms.Label SuprMdc;
        private System.Windows.Forms.Label lblMdc;
        private System.Windows.Forms.ComboBox lblMdc_list;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button archBtn;
    }
}