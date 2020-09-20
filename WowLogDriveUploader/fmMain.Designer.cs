namespace WowLogDriveUploader
{
    partial class WowLogDriveUploader
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WowLogDriveUploader));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreArchivo = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfigurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.btSubirADrive = new System.Windows.Forms.Button();
            this.tbEstado = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre o descripción del log de HOY DIA";
            // 
            // tbNombreArchivo
            // 
            this.tbNombreArchivo.Location = new System.Drawing.Point(15, 47);
            this.tbNombreArchivo.Multiline = false;
            this.tbNombreArchivo.Name = "tbNombreArchivo";
            this.tbNombreArchivo.Size = new System.Drawing.Size(233, 23);
            this.tbNombreArchivo.TabIndex = 2;
            this.tbNombreArchivo.Text = "";
            this.tbNombreArchivo.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.tsbConfigurar,
            this.toolStripSeparator3,
            this.tsbAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(263, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2.Text = "Edición";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbConfigurar
            // 
            this.tsbConfigurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfigurar.Image")));
            this.tsbConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfigurar.Name = "tsbConfigurar";
            this.tsbConfigurar.Size = new System.Drawing.Size(68, 22);
            this.tsbConfigurar.Text = "Configurar";
            this.tsbConfigurar.Click += new System.EventHandler(this.tsbConfigurar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAyuda
            // 
            this.tsbAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAyuda.Image")));
            this.tsbAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(45, 22);
            this.tsbAyuda.Text = "Ayuda";
            this.tsbAyuda.Click += new System.EventHandler(this.tsbAyuda_Click);
            // 
            // btSubirADrive
            // 
            this.btSubirADrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubirADrive.Location = new System.Drawing.Point(12, 97);
            this.btSubirADrive.Name = "btSubirADrive";
            this.btSubirADrive.Size = new System.Drawing.Size(236, 42);
            this.btSubirADrive.TabIndex = 4;
            this.btSubirADrive.Text = "Subir a Drive";
            this.btSubirADrive.UseVisualStyleBackColor = true;
            this.btSubirADrive.Click += new System.EventHandler(this.btSubirADrive_Click);
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(12, 167);
            this.tbEstado.Multiline = false;
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.ReadOnly = true;
            this.tbEstado.Size = new System.Drawing.Size(239, 23);
            this.tbEstado.TabIndex = 2;
            this.tbEstado.Text = "Listo para empezar la subida.";
            this.tbEstado.WordWrap = false;
            // 
            // WowLogDriveUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 197);
            this.Controls.Add(this.btSubirADrive);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbNombreArchivo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WowLogDriveUploader";
            this.Text = "WowLogDriveUploader";
            this.Load += new System.EventHandler(this.WowLogDriveUploader_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbNombreArchivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbConfigurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.Button btSubirADrive;
        public System.Windows.Forms.RichTextBox tbEstado;
    }
}

