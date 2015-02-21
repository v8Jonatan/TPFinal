namespace UI
{
    partial class FrmLibros
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
            this.lblEjemplares = new System.Windows.Forms.Label();
            this.txtEjemplares = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxAutores = new System.Windows.Forms.ComboBox();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEjemplares
            // 
            this.lblEjemplares.AutoSize = true;
            this.lblEjemplares.Location = new System.Drawing.Point(118, 239);
            this.lblEjemplares.Name = "lblEjemplares";
            this.lblEjemplares.Size = new System.Drawing.Size(58, 13);
            this.lblEjemplares.TabIndex = 19;
            this.lblEjemplares.Text = "Ejemplares";
            // 
            // txtEjemplares
            // 
            this.txtEjemplares.Location = new System.Drawing.Point(178, 236);
            this.txtEjemplares.Name = "txtEjemplares";
            this.txtEjemplares.Size = new System.Drawing.Size(100, 20);
            this.txtEjemplares.TabIndex = 18;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(118, 194);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 17;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(178, 191);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 16;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(118, 150);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(178, 147);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 14;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(118, 107);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 13;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(118, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(178, 65);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // comboBoxAutores
            // 
            this.comboBoxAutores.FormattingEnabled = true;
            this.comboBoxAutores.Location = new System.Drawing.Point(178, 107);
            this.comboBoxAutores.Name = "comboBoxAutores";
            this.comboBoxAutores.Size = new System.Drawing.Size(154, 21);
            this.comboBoxAutores.TabIndex = 20;
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.Location = new System.Drawing.Point(378, 107);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarAutor.TabIndex = 21;
            this.btnAgregarAutor.Text = "Agregar Autor";
            this.btnAgregarAutor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(178, 305);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarLibro.TabIndex = 22;
            this.btnAgregarLibro.Text = "Aceptar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.btnAgregarAutor);
            this.Controls.Add(this.comboBoxAutores);
            this.Controls.Add(this.lblEjemplares);
            this.Controls.Add(this.txtEjemplares);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Name = "FrmLibros";
            this.Text = "FrmLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjemplares;
        private System.Windows.Forms.TextBox txtEjemplares;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox comboBoxAutores;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.Button btnAgregarLibro;
    }
}