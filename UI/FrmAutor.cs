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
    public partial class FrmAutor : Form
    {
        Autor nuevoAutor;
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido=txtApellido.Text;
            string nacionalidad=txtNacionalidad.Text;

            nuevoAutor = new Autor(0,apellido,nacionalidad);
            this.Close();

        }
        public Autor NuevoAutor
        {
            get { return nuevoAutor; }
        }

    }
}
