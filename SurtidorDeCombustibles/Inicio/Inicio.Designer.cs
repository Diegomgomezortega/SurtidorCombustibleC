namespace Inicio
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnConfiguraciones = new System.Windows.Forms.Button();
            this.ImgInicio = new System.Windows.Forms.PictureBox();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Lavender;
            this.lblBienvenido.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(147, -2);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(326, 54);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Lavender;
            this.btnVentas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVentas.Location = new System.Drawing.Point(79, 295);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(107, 38);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.BackColor = System.Drawing.Color.Lavender;
            this.btnConfiguraciones.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfiguraciones.Location = new System.Drawing.Point(192, 295);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(221, 38);
            this.btnConfiguraciones.TabIndex = 3;
            this.btnConfiguraciones.Text = "CONFIGURACIONES";
            this.btnConfiguraciones.UseVisualStyleBackColor = false;
            // 
            // ImgInicio
            // 
            this.ImgInicio.Image = ((System.Drawing.Image)(resources.GetObject("ImgInicio.Image")));
            this.ImgInicio.InitialImage = null;
            this.ImgInicio.Location = new System.Drawing.Point(2, 37);
            this.ImgInicio.Name = "ImgInicio";
            this.ImgInicio.Size = new System.Drawing.Size(575, 321);
            this.ImgInicio.TabIndex = 0;
            this.ImgInicio.TabStop = false;
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.Lavender;
            this.btnCerrarAplicacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(436, 295);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(107, 38);
            this.btnCerrarAplicacion.TabIndex = 4;
            this.btnCerrarAplicacion.Text = "CERRAR";
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.btnCerrarAplicacion);
            this.Controls.Add(this.btnConfiguraciones);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.ImgInicio);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgInicio;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnConfiguraciones;
        private System.Windows.Forms.Button btnCerrarAplicacion;
    }
}

