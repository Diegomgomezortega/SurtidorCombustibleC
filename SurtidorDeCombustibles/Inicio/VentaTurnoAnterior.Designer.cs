namespace Inicio
{
    partial class VentaTurnoAnterior
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
            this.dgvTurnoAnterior = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnoAnterior
            // 
            this.dgvTurnoAnterior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnoAnterior.Location = new System.Drawing.Point(12, 3);
            this.dgvTurnoAnterior.Name = "dgvTurnoAnterior";
            this.dgvTurnoAnterior.Size = new System.Drawing.Size(365, 196);
            this.dgvTurnoAnterior.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(311, 226);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 39);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VentaTurnoAnterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 290);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTurnoAnterior);
            this.Name = "VentaTurnoAnterior";
            this.Text = "Turno Anterior";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoAnterior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnoAnterior;
        private System.Windows.Forms.Button btnVolver;
    }
}