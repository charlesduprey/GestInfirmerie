namespace UtilisateursGUI.GestionMdc
{
    partial class FrmAjoutMdc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutMdc));
            this.nomMdc_txt = new System.Windows.Forms.TextBox();
            this.nomMdc = new System.Windows.Forms.Label();
            this.enrBtn = new System.Windows.Forms.Button();
            this.errProMdcTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProSave = new System.Windows.Forms.ErrorProvider(this.components);
            this.frmModifLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProMdcTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).BeginInit();
            this.SuspendLayout();
            // 
            // nomMdc_txt
            // 
            this.nomMdc_txt.Location = new System.Drawing.Point(167, 71);
            this.nomMdc_txt.Name = "nomMdc_txt";
            this.nomMdc_txt.Size = new System.Drawing.Size(125, 20);
            this.nomMdc_txt.TabIndex = 5;
            this.nomMdc_txt.Validating += new System.ComponentModel.CancelEventHandler(this.nomMdc_txt_Validating);
            // 
            // nomMdc
            // 
            this.nomMdc.AutoSize = true;
            this.nomMdc.Location = new System.Drawing.Point(40, 74);
            this.nomMdc.Name = "nomMdc";
            this.nomMdc.Size = new System.Drawing.Size(105, 13);
            this.nomMdc.TabIndex = 4;
            this.nomMdc.Text = "Nom du Médicament";
            // 
            // enrBtn
            // 
            this.enrBtn.Location = new System.Drawing.Point(195, 97);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(75, 23);
            this.enrBtn.TabIndex = 3;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = true;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click);
            this.enrBtn.Validating += new System.ComponentModel.CancelEventHandler(this.enrBtn_Validating);
            // 
            // errProMdcTxt
            // 
            this.errProMdcTxt.ContainerControl = this;
            // 
            // errProSave
            // 
            this.errProSave.ContainerControl = this;
            // 
            // frmModifLbl
            // 
            this.frmModifLbl.AutoSize = true;
            this.frmModifLbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmModifLbl.Location = new System.Drawing.Point(12, 9);
            this.frmModifLbl.Name = "frmModifLbl";
            this.frmModifLbl.Size = new System.Drawing.Size(318, 39);
            this.frmModifLbl.TabIndex = 6;
            this.frmModifLbl.Text = "Ajouter un médicament";
            // 
            // FrmAjoutMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 143);
            this.Controls.Add(this.frmModifLbl);
            this.Controls.Add(this.nomMdc_txt);
            this.Controls.Add(this.nomMdc);
            this.Controls.Add(this.enrBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutMdc";
            this.Text = "Ajouter un médicament";
            ((System.ComponentModel.ISupportInitialize)(this.errProMdcTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomMdc_txt;
        private System.Windows.Forms.Label nomMdc;
        private System.Windows.Forms.Button enrBtn;
        private System.Windows.Forms.ErrorProvider errProMdcTxt;
        private System.Windows.Forms.ErrorProvider errProSave;
        private System.Windows.Forms.Label frmModifLbl;
    }
}