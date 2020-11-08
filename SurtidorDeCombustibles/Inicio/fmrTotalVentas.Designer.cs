namespace Inicio
{
    partial class fmrTotalVentas
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
            this.dgvVentaTotal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentaTotal
            // 
            this.dgvVentaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaTotal.Location = new System.Drawing.Point(12, 12);
            this.dgvVentaTotal.Name = "dgvVentaTotal";
            this.dgvVentaTotal.Size = new System.Drawing.Size(345, 274);
            this.dgvVentaTotal.TabIndex = 0;
            // 
            // fmrTotalVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.dgvVentaTotal);
            this.Name = "fmrTotalVentas";
            this.Text = "Total Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentaTotal;
    }
}