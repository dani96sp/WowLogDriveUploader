namespace WowLogDriveUploader
{
    partial class fmConfig
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
            this.btGuardarConfig = new System.Windows.Forms.Button();
            this.tbRutaLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdCarpetaDrive = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClientId = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClientSecret = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btGuardarConfig
            // 
            this.btGuardarConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarConfig.Location = new System.Drawing.Point(101, 253);
            this.btGuardarConfig.Name = "btGuardarConfig";
            this.btGuardarConfig.Size = new System.Drawing.Size(236, 42);
            this.btGuardarConfig.TabIndex = 9;
            this.btGuardarConfig.Text = "Guardar";
            this.btGuardarConfig.UseVisualStyleBackColor = true;
            this.btGuardarConfig.Click += new System.EventHandler(this.btGuardarConfig_Click);
            // 
            // tbRutaLog
            // 
            this.tbRutaLog.Location = new System.Drawing.Point(9, 28);
            this.tbRutaLog.Multiline = false;
            this.tbRutaLog.Name = "tbRutaLog";
            this.tbRutaLog.Size = new System.Drawing.Size(418, 25);
            this.tbRutaLog.TabIndex = 7;
            this.tbRutaLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ruta absoluta del combatlog";
            // 
            // tbIdCarpetaDrive
            // 
            this.tbIdCarpetaDrive.Location = new System.Drawing.Point(9, 79);
            this.tbIdCarpetaDrive.Multiline = false;
            this.tbIdCarpetaDrive.Name = "tbIdCarpetaDrive";
            this.tbIdCarpetaDrive.Size = new System.Drawing.Size(418, 25);
            this.tbIdCarpetaDrive.TabIndex = 8;
            this.tbIdCarpetaDrive.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID_CARPETA_DRIVE";
            // 
            // lbClientId
            // 
            this.lbClientId.AutoSize = true;
            this.lbClientId.Location = new System.Drawing.Point(12, 126);
            this.lbClientId.Name = "lbClientId";
            this.lbClientId.Size = new System.Drawing.Size(44, 13);
            this.lbClientId.TabIndex = 6;
            this.lbClientId.Text = "clientId ";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(9, 142);
            this.tbClientId.Multiline = false;
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(418, 25);
            this.tbClientId.TabIndex = 8;
            this.tbClientId.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "clientSecret ";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Location = new System.Drawing.Point(9, 199);
            this.tbClientSecret.Multiline = false;
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.Size = new System.Drawing.Size(418, 25);
            this.tbClientSecret.TabIndex = 8;
            this.tbClientSecret.Text = "";
            // 
            // fmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 314);
            this.Controls.Add(this.btGuardarConfig);
            this.Controls.Add(this.tbRutaLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientSecret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClientId);
            this.Controls.Add(this.lbClientId);
            this.Controls.Add(this.tbIdCarpetaDrive);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmConfig";
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardarConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox tbRutaLog;
        public System.Windows.Forms.RichTextBox tbIdCarpetaDrive;
        private System.Windows.Forms.Label lbClientId;
        public System.Windows.Forms.RichTextBox tbClientId;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox tbClientSecret;
    }
}