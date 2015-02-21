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
    public partial class FrmLibros : Form
    {
        private Libro nuevoLibro; 
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string genero = txtGenero.Text;
            string isbn = txtIsbn.Text;
            int cantEjemplares= int.Parse(txtEjemplares.Text);
            nuevoLibro = new Libro(titulo, genero, isbn, cantEjemplares);

            this.Close();
        }
        public Libro NuevoLibro
        {
            get { return nuevoLibro; }
        }
    }
}
