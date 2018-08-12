namespace MapaIcesi
{
    partial class Mapa
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtInfoCuadrantes = new System.Windows.Forms.TextBox();
            this.btnLimpiarTexArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1058, 560);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gMapControl1_OnPolygonClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // txtInfoCuadrantes
            // 
            this.txtInfoCuadrantes.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfoCuadrantes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInfoCuadrantes.Location = new System.Drawing.Point(707, 28);
            this.txtInfoCuadrantes.Multiline = true;
            this.txtInfoCuadrantes.Name = "txtInfoCuadrantes";
            this.txtInfoCuadrantes.ReadOnly = true;
            this.txtInfoCuadrantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfoCuadrantes.Size = new System.Drawing.Size(327, 383);
            this.txtInfoCuadrantes.TabIndex = 1;
            // 
            // btnLimpiarTexArea
            // 
            this.btnLimpiarTexArea.Location = new System.Drawing.Point(707, 418);
            this.btnLimpiarTexArea.Name = "btnLimpiarTexArea";
            this.btnLimpiarTexArea.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarTexArea.TabIndex = 2;
            this.btnLimpiarTexArea.Text = "Limpiar";
            this.btnLimpiarTexArea.UseVisualStyleBackColor = true;
            this.btnLimpiarTexArea.Click += new System.EventHandler(this.btnLimpiarTexArea_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 560);
            this.Controls.Add(this.btnLimpiarTexArea);
            this.Controls.Add(this.txtInfoCuadrantes);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Mapa";
            this.Text = "Consultas Mapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtInfoCuadrantes;
        private System.Windows.Forms.Button btnLimpiarTexArea;
    }
}

