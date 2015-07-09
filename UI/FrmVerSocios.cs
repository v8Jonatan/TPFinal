using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RN;

namespace UI
{
    public partial class FrmVerSocios : Form
    {
        public FrmVerSocios(Socio s)
        {
            InitializeComponent();
            this.lblVerApellido.Text = s.Apellido;
            this.lblVerCorreo.Text = s.Correo;
            this.lblVerDni.Text = s.Dni.ToString();
            this.lblVerNombres.Text = s.Nombres;
            this.lblVerTelefono.Text = s.Telefono.ToString();
        }

        private void FrmVerSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
