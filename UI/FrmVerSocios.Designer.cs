namespace UI
{
    partial class FrmVerSocios
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
            this.radiobtnEspecial = new System.Windows.Forms.RadioButton();
            this.radiobtnComun = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblVerApellido = new System.Windows.Forms.Label();
            this.lblVerNombres = new System.Windows.Forms.Label();
            this.lblVerDni = new System.Windows.Forms.Label();
            this.lblVerTelefono = new System.Windows.Forms.Label();
            this.lblVerCorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiobtnEspecial
            // 
            this.radiobtnEspecial.AutoSize = true;
            this.radiobtnEspecial.Location = new System.Drawing.Point(224, 283);
            this.radiobtnEspecial.Name = "radiobtnEspecial";
            this.radiobtnEspecial.Size = new System.Drawing.Size(65, 17);
            this.radiobtnEspecial.TabIndex = 27;
            this.radiobtnEspecial.Text = "Especial";
            this.radiobtnEspecial.UseVisualStyleBackColor = true;
            // 
            // radiobtnComun
            // 
            this.radiobtnComun.AutoSize = true;
            this.radiobtnComun.Checked = true;
            this.radiobtnComun.Location = new System.Drawing.Point(100, 283);
            this.radiobtnComun.Name = "radiobtnComun";
            this.radiobtnComun.Size = new System.Drawing.Size(58, 17);
            this.radiobtnComun.TabIndex = 26;
            this.radiobtnComun.TabStop = true;
            this.radiobtnComun.Text = "Comun";
            this.radiobtnComun.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(157, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(97, 228);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 24;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(97, 183);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(97, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 20;
            this.lblDni.Text = "Dni";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(97, 96);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 18;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(97, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "Apellido";
            // 
            // lblVerApellido
            // 
            this.lblVerApellido.AutoSize = true;
            this.lblVerApellido.Location = new System.Drawing.Point(205, 57);
            this.lblVerApellido.Name = "lblVerApellido";
            this.lblVerApellido.Size = new System.Drawing.Size(44, 13);
            this.lblVerApellido.TabIndex = 28;
            this.lblVerApellido.Text = "Apellido";
            // 
            // lblVerNombres
            // 
            this.lblVerNombres.AutoSize = true;
            this.lblVerNombres.Location = new System.Drawing.Point(205, 96);
            this.lblVerNombres.Name = "lblVerNombres";
            this.lblVerNombres.Size = new System.Drawing.Size(44, 13);
            this.lblVerNombres.TabIndex = 29;
            this.lblVerNombres.Text = "Apellido";
            // 
            // lblVerDni
            // 
            this.lblVerDni.AutoSize = true;
            this.lblVerDni.Location = new System.Drawing.Point(205, 139);
            this.lblVerDni.Name = "lblVerDni";
            this.lblVerDni.Size = new System.Drawing.Size(44, 13);
            this.lblVerDni.TabIndex = 30;
            this.lblVerDni.Text = "Apellido";
            // 
            // lblVerTelefono
            // 
            this.lblVerTelefono.AutoSize = true;
            this.lblVerTelefono.Location = new System.Drawing.Point(205, 183);
            this.lblVerTelefono.Name = "lblVerTelefono";
            this.lblVerTelefono.Size = new System.Drawing.Size(44, 13);
            this.lblVerTelefono.TabIndex = 31;
            this.lblVerTelefono.Text = "Apellido";
            // 
            // lblVerCorreo
            // 
            this.lblVerCorreo.AutoSize = true;
            this.lblVerCorreo.Location = new System.Drawing.Point(205, 228);
            this.lblVerCorreo.Name = "lblVerCorreo";
            this.lblVerCorreo.Size = new System.Drawing.Size(44, 13);
            this.lblVerCorreo.TabIndex = 32;
            this.lblVerCorreo.Text = "Apellido";
            // 
            // FrmVerSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 448);
            this.Controls.Add(this.lblVerCorreo);
            this.Controls.Add(this.lblVerTelefono);
            this.Controls.Add(this.lblVerDni);
            this.Controls.Add(this.lblVerNombres);
            this.Controls.Add(this.lblVerApellido);
            this.Controls.Add(this.radiobtnEspecial);
            this.Controls.Add(this.radiobtnComun);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellido);
            this.Name = "FrmVerSocios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmVerSocios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnEspecial;
        private System.Windows.Forms.RadioButton radiobtnComun;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblVerApellido;
        private System.Windows.Forms.Label lblVerNombres;
        private System.Windows.Forms.Label lblVerDni;
        private System.Windows.Forms.Label lblVerTelefono;
        private System.Windows.Forms.Label lblVerCorreo;
    }
}