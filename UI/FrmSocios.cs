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
    public partial class FrmSocios : Form
    {
        private Socio nuevoSocio;
        public FrmSocios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string noms = txtNombres.Text;
            string ape = txtApellido.Text;
            string correo = txtCorreo.Text;
            int tele = int.Parse(txtTelefono.Text);
            int dni = int.Parse(txtDni.Text);
            if (radiobtnComun.Checked)
            {
                nuevoSocio = new Comun(0, correo, noms, ape, tele, dni);
            }
            else
            {
                nuevoSocio = new Especial(0, correo, noms, ape, tele, dni);
            }
            this.Close();

        }
        public Socio NuevoSocio
        {
            get { return nuevoSocio; }
        }
    }
}
