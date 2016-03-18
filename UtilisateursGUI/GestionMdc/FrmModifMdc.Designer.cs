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
            this.nommedic = new System.Windows.Forms.ComboBox();
            this.savemodif = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.archiveoui = new System.Windows.Forms.RadioButton();
            this.archivenon = new System.Windows.Forms.RadioButton();
            this.archivemedic = new System.Windows.Forms.GroupBox();
            this.archivemedic.SuspendLayout();
            this.SuspendLayout();
            // 
            // nommedic
            // 
            this.nommedic.FormattingEnabled = true;
            this.nommedic.Location = new System.Drawing.Point(143, 69);
            this.nommedic.Name = "nommedic";
            this.nommedic.Size = new System.Drawing.Size(200, 24);
            this.nommedic.TabIndex = 0;
            // 
            // savemodif
            // 
            this.savemodif.Location = new System.Drawing.Point(143, 276);
            this.savemodif.Name = "savemodif";
            this.savemodif.Size = new System.Drawing.Size(98, 31);
            this.savemodif.TabIndex = 1;
            this.savemodif.Text = "Modifier";
            this.savemodif.UseVisualStyleBackColor = true;
            this.savemodif.Click += new System.EventHandler(this.savemodif_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // archiveoui
            // 
            this.archiveoui.AutoSize = true;
            this.archiveoui.Location = new System.Drawing.Point(27, 45);
            this.archiveoui.Name = "archiveoui";
            this.archiveoui.Size = new System.Drawing.Size(48, 21);
            this.archiveoui.TabIndex = 4;
            this.archiveoui.TabStop = true;
            this.archiveoui.Text = "oui";
            this.archiveoui.UseVisualStyleBackColor = true;
            // 
            // archivenon
            // 
            this.archivenon.AutoSize = true;
            this.archivenon.Location = new System.Drawing.Point(132, 45);
            this.archivenon.Name = "archivenon";
            this.archivenon.Size = new System.Drawing.Size(55, 21);
            this.archivenon.TabIndex = 5;
            this.archivenon.TabStop = true;
            this.archivenon.Text = "Non";
            this.archivenon.UseVisualStyleBackColor = true;
            // 
            // archivemedic
            // 
            this.archivemedic.Controls.Add(this.archivenon);
            this.archivemedic.Controls.Add(this.archiveoui);
            this.archivemedic.Location = new System.Drawing.Point(143, 157);
            this.archivemedic.Name = "archivemedic";
            this.archivemedic.Size = new System.Drawing.Size(200, 100);
            this.archivemedic.TabIndex = 6;
            this.archivemedic.TabStop = false;
            this.archivemedic.Text = "Archive";
            // 
            // FrmModifMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 393);
            this.Controls.Add(this.archivemedic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.savemodif);
            this.Controls.Add(this.nommedic);
            this.Name = "FrmModifMdc";
            this.Text = "Form1";
            this.archivemedic.ResumeLayout(false);
            this.archivemedic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nommedic;
        private System.Windows.Forms.Button savemodif;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton archiveoui;
        private System.Windows.Forms.RadioButton archivenon;
        private System.Windows.Forms.GroupBox archivemedic;
    }
}