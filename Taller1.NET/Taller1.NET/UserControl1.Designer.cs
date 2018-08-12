namespace Taller1.NET
{
    partial class PanelRegistro
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHora = new System.Windows.Forms.Label();
            this.txtArtículo = new System.Windows.Forms.TextBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoEst = new System.Windows.Forms.Label();
            this.lblReportadoPor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.cbxReportadoPor = new System.Windows.Forms.ComboBox();
            this.lblNombreEst = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxUbicacion = new System.Windows.Forms.ComboBox();
            this.btnConsultaCuadrantes = new System.Windows.Forms.Button();
            this.Mapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(2, 125);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // txtArtículo
            // 
            this.txtArtículo.Location = new System.Drawing.Point(132, 61);
            this.txtArtículo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtículo.Name = "txtArtículo";
            this.txtArtículo.Size = new System.Drawing.Size(215, 20);
            this.txtArtículo.TabIndex = 2;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Items.AddRange(new object[] {
            "7 am - 8 am",
            "8 am - 9 am",
            "9 am - 10 am",
            "10 am - 11 am",
            "11 am - 12 am",
            "12 am - 1 pm",
            "1 pm - 2 pm",
            "2 pm - 3 pm",
            "3 pm - 4 pm",
            "4 pm - 5 pm",
            "5 pm - 6 pm",
            "6 pm - 7 pm",
            "7 pm - 8 pm",
            "8 pm - 9 pm",
            "9 pm - 10 pm"});
            this.cbxHora.Location = new System.Drawing.Point(132, 123);
            this.cbxHora.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(215, 21);
            this.cbxHora.TabIndex = 4;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(2, 64);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(44, 13);
            this.lblArticulo.TabIndex = 4;
            this.lblArticulo.Text = "Artículo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(2, 99);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(215, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(132, 93);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblCodigoEst
            // 
            this.lblCodigoEst.AutoSize = true;
            this.lblCodigoEst.Location = new System.Drawing.Point(2, 35);
            this.lblCodigoEst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoEst.Name = "lblCodigoEst";
            this.lblCodigoEst.Size = new System.Drawing.Size(92, 13);
            this.lblCodigoEst.TabIndex = 2;
            this.lblCodigoEst.Text = "Código estudiante";
            // 
            // lblReportadoPor
            // 
            this.lblReportadoPor.AutoSize = true;
            this.lblReportadoPor.Location = new System.Drawing.Point(2, 152);
            this.lblReportadoPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportadoPor.Name = "lblReportadoPor";
            this.lblReportadoPor.Size = new System.Drawing.Size(75, 13);
            this.lblReportadoPor.TabIndex = 13;
            this.lblReportadoPor.Text = "Reportado por";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 5);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(2, 186);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(58, 13);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // cbxReportadoPor
            // 
            this.cbxReportadoPor.FormattingEnabled = true;
            this.cbxReportadoPor.Items.AddRange(new object[] {
            "Beycker Alexis Ágredo Mosquera",
            "Juan Diego Carvajal Castaño",
            "Leonardo Franco Calpa"});
            this.cbxReportadoPor.Location = new System.Drawing.Point(132, 150);
            this.cbxReportadoPor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxReportadoPor.Name = "cbxReportadoPor";
            this.cbxReportadoPor.Size = new System.Drawing.Size(215, 21);
            this.cbxReportadoPor.TabIndex = 5;
            // 
            // lblNombreEst
            // 
            this.lblNombreEst.AutoSize = true;
            this.lblNombreEst.Location = new System.Drawing.Point(2, 7);
            this.lblNombreEst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEst.Name = "lblNombreEst";
            this.lblNombreEst.Size = new System.Drawing.Size(96, 13);
            this.lblNombreEst.TabIndex = 0;
            this.lblNombreEst.Text = "Nombre estudiante";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(460, 33);
            this.txtCarga.Multiline = true;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.ReadOnly = true;
            this.txtCarga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarga.Size = new System.Drawing.Size(330, 435);
            this.txtCarga.TabIndex = 14;
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(457, 8);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(54, 13);
            this.lblCarga.TabIndex = 15;
            this.lblCarga.Text = "Registros:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(460, 482);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(99, 38);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar Registros";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(86, 483);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(99, 37);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(238, 483);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 37);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxUbicacion
            // 
            this.cbxUbicacion.FormattingEnabled = true;
            this.cbxUbicacion.Items.AddRange(new object[] {
            "Zona1",
            "Zona2",
            "Zona3",
            "Zona4",
            "Zona5",
            "Zona6",
            "Zona7",
            "Zona8",
            "Zona9"});
            this.cbxUbicacion.Location = new System.Drawing.Point(132, 177);
            this.cbxUbicacion.Name = "cbxUbicacion";
            this.cbxUbicacion.Size = new System.Drawing.Size(215, 21);
            this.cbxUbicacion.TabIndex = 19;
            // 
            // btnConsultaCuadrantes
            // 
            this.btnConsultaCuadrantes.Location = new System.Drawing.Point(715, 482);
            this.btnConsultaCuadrantes.Name = "btnConsultaCuadrantes";
            this.btnConsultaCuadrantes.Size = new System.Drawing.Size(75, 39);
            this.btnConsultaCuadrantes.TabIndex = 20;
            this.btnConsultaCuadrantes.Text = "Consulta Cuadrantes";
            this.btnConsultaCuadrantes.UseVisualStyleBackColor = true;
            this.btnConsultaCuadrantes.Click += new System.EventHandler(this.btnConsultaCuadrantes_Click);
            // 
            // Mapa
            // 
            this.Mapa.Image = global::Taller1.NET.Properties.Resources.mapaIcesi;
            this.Mapa.Location = new System.Drawing.Point(5, 207);
            this.Mapa.Margin = new System.Windows.Forms.Padding(2);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(423, 261);
            this.Mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mapa.TabIndex = 7;
            this.Mapa.TabStop = false;
            // 
            // PanelRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsultaCuadrantes);
            this.Controls.Add(this.cbxUbicacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lblNombreEst);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.cbxReportadoPor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtArtículo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.lblReportadoPor);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblCodigoEst);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCodigo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelRegistro";
            this.Size = new System.Drawing.Size(801, 532);
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtArtículo;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCodigoEst;
        private System.Windows.Forms.Label lblReportadoPor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox cbxReportadoPor;
        private System.Windows.Forms.PictureBox Mapa;
        private System.Windows.Forms.Label lblNombreEst;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbxUbicacion;
        private System.Windows.Forms.Button btnConsultaCuadrantes;
    }
}
