namespace UI
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.datagridDatos = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnDetalleSocio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnIsbn = new System.Windows.Forms.RadioButton();
            this.radioBtnAutor = new System.Windows.Forms.RadioButton();
            this.radiobtnTitulo = new System.Windows.Forms.RadioButton();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.prestamoToolStripMenuItem,
            this.catalogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSocioToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // agregarSocioToolStripMenuItem
            // 
            this.agregarSocioToolStripMenuItem.Name = "agregarSocioToolStripMenuItem";
            this.agregarSocioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarSocioToolStripMenuItem.Text = "Agregar Socio";
            this.agregarSocioToolStripMenuItem.Click += new System.EventHandler(this.agregarSocioToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // verReservasToolStripMenuItem
            // 
            this.verReservasToolStripMenuItem.Name = "verReservasToolStripMenuItem";
            this.verReservasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verReservasToolStripMenuItem.Text = "Ver Reservas";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPrestamosToolStripMenuItem,
            this.devolverToolStripMenuItem,
            this.realizarPrestamoToolStripMenuItem});
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamoToolStripMenuItem.Text = "Prestamos";
            // 
            // verPrestamosToolStripMenuItem
            // 
            this.verPrestamosToolStripMenuItem.Name = "verPrestamosToolStripMenuItem";
            this.verPrestamosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.verPrestamosToolStripMenuItem.Text = "Ver Prestamos";
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            // 
            // realizarPrestamoToolStripMenuItem
            // 
            this.realizarPrestamoToolStripMenuItem.Name = "realizarPrestamoToolStripMenuItem";
            this.realizarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.realizarPrestamoToolStripMenuItem.Text = "Realizar Prestamo";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibroToolStripMenuItem,
            this.agregarEjemplarToolStripMenuItem,
            this.buscarLibrosToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // agregarLibroToolStripMenuItem
            // 
            this.agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            this.agregarLibroToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            // 
            // agregarEjemplarToolStripMenuItem
            // 
            this.agregarEjemplarToolStripMenuItem.Name = "agregarEjemplarToolStripMenuItem";
            this.agregarEjemplarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.agregarEjemplarToolStripMenuItem.Text = "Agregar Ejemplar";
            // 
            // buscarLibrosToolStripMenuItem
            // 
            this.buscarLibrosToolStripMenuItem.Name = "buscarLibrosToolStripMenuItem";
            this.buscarLibrosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.buscarLibrosToolStripMenuItem.Text = "Buscar Libros";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(68, 62);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(109, 59);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(118, 20);
            this.txtDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Location = new System.Drawing.Point(109, 85);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(118, 20);
            this.txtNroSocio.TabIndex = 4;
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(49, 88);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(54, 13);
            this.lblNroSocio.TabIndex = 5;
            this.lblNroSocio.Text = "Nro.Socio";
            // 
            // datagridDatos
            // 
            this.datagridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDatos.Location = new System.Drawing.Point(52, 149);
            this.datagridDatos.Name = "datagridDatos";
            this.datagridDatos.Size = new System.Drawing.Size(253, 150);
            this.datagridDatos.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(396, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "NombreApellido";
            // 
            // btnDetalleSocio
            // 
            this.btnDetalleSocio.Location = new System.Drawing.Point(399, 88);
            this.btnDetalleSocio.Name = "btnDetalleSocio";
            this.btnDetalleSocio.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleSocio.TabIndex = 9;
            this.btnDetalleSocio.Text = "Detalles";
            this.btnDetalleSocio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnIsbn);
            this.panel1.Controls.Add(this.radioBtnAutor);
            this.panel1.Controls.Add(this.radiobtnTitulo);
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Location = new System.Drawing.Point(344, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 150);
            this.panel1.TabIndex = 10;
            // 
            // radioBtnIsbn
            // 
            this.radioBtnIsbn.AutoSize = true;
            this.radioBtnIsbn.Location = new System.Drawing.Point(148, 130);
            this.radioBtnIsbn.Name = "radioBtnIsbn";
            this.radioBtnIsbn.Size = new System.Drawing.Size(50, 17);
            this.radioBtnIsbn.TabIndex = 4;
            this.radioBtnIsbn.TabStop = true;
            this.radioBtnIsbn.Text = "ISBN";
            this.radioBtnIsbn.UseVisualStyleBackColor = true;
            // 
            // radioBtnAutor
            // 
            this.radioBtnAutor.AutoSize = true;
            this.radioBtnAutor.Location = new System.Drawing.Point(148, 98);
            this.radioBtnAutor.Name = "radioBtnAutor";
            this.radioBtnAutor.Size = new System.Drawing.Size(50, 17);
            this.radioBtnAutor.TabIndex = 3;
            this.radioBtnAutor.TabStop = true;
            this.radioBtnAutor.Text = "Autor";
            this.radioBtnAutor.UseVisualStyleBackColor = true;
            // 
            // radiobtnTitulo
            // 
            this.radiobtnTitulo.AutoSize = true;
            this.radiobtnTitulo.Location = new System.Drawing.Point(148, 64);
            this.radiobtnTitulo.Name = "radiobtnTitulo";
            this.radiobtnTitulo.Size = new System.Drawing.Size(51, 17);
            this.radiobtnTitulo.TabIndex = 2;
            this.radiobtnTitulo.TabStop = true;
            this.radiobtnTitulo.Text = "Titulo";
            this.radiobtnTitulo.UseVisualStyleBackColor = true;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(137, 15);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(13, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetalleSocio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.datagridDatos);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEjemplarToolStripMenuItem;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.DataGridView datagridDatos;
        private System.Windows.Forms.ToolStripMenuItem verReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLibrosToolStripMenuItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnDetalleSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnIsbn;
        private System.Windows.Forms.RadioButton radioBtnAutor;
        private System.Windows.Forms.RadioButton radiobtnTitulo;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}

