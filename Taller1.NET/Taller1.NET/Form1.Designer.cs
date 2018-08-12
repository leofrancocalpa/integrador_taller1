namespace Taller1.NET
{
    partial class Form1
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
            this.groupBoxReporte = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelRegistro1 = new Taller1.NET.PanelRegistro();
            this.groupBoxReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReporte
            // 
            this.groupBoxReporte.Controls.Add(this.lblDescripcion);
            this.groupBoxReporte.Controls.Add(this.panelRegistro1);
            this.groupBoxReporte.Location = new System.Drawing.Point(8, 8);
            this.groupBoxReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxReporte.Name = "groupBoxReporte";
            this.groupBoxReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxReporte.Size = new System.Drawing.Size(817, 587);
            this.groupBoxReporte.TabIndex = 3;
            this.groupBoxReporte.TabStop = false;
            this.groupBoxReporte.Text = "Reporte de Robo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(4, 19);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(352, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Llene todos los campos correspondientes al objeto perdido del estudiante";
            // 
            // panelRegistro1
            // 
            this.panelRegistro1.Location = new System.Drawing.Point(7, 54);
            this.panelRegistro1.Margin = new System.Windows.Forms.Padding(1);
            this.panelRegistro1.Name = "panelRegistro1";
            this.panelRegistro1.Size = new System.Drawing.Size(801, 529);
            this.panelRegistro1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 603);
            this.Controls.Add(this.groupBoxReporte);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BEDDF";
            this.groupBoxReporte.ResumeLayout(false);
            this.groupBoxReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelRegistro panelRegistro1;
        private System.Windows.Forms.GroupBox groupBoxReporte;
        private System.Windows.Forms.Label lblDescripcion;
    }
}

