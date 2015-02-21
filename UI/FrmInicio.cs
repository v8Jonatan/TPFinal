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
    public partial class FrmInicio : Form
    {
        private Biblioteca biblioteca;
        public FrmInicio()
        {
            InitializeComponent();
            biblioteca = new Biblioteca();
          
        }
        
        private void agregarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSocios fr = new FrmSocios();
                fr.ShowDialog();
                if (fr.NuevoSocio != null)
                {
                    biblioteca.agregarSocio(fr.NuevoSocio);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Socio s;
            if (!txtDni.Text.Trim().Equals(""))                     //Revisa el textbox en el que va a hacer la búsqueda
            {
                s = biblioteca.buscarDni(int.Parse(txtDni.Text));
                if (s != null){
                    txtNroSocio.Text = s.Id.ToString();
                    mostrarBusqueda(s);
                }       
                else
                    MessageBox.Show(this, "Socio no existe");
            }
            else
            {
                s = biblioteca.buscarNroSocio(int.Parse(txtNroSocio.Text));
                if (s != null){
                   txtDni.Text = s.Dni.ToString();
                    mostrarBusqueda(s);
                }
                else
                    MessageBox.Show(this, "Socio no existe");
            }
        }

        private void mostrarBusqueda(Socio s)
        {
            lblNombre.Visible = true;
            btnDetalleSocio.Visible = true;
            panel1.Visible = false;
            verPrestamosToolStripMenuItem.Enabled = true;
            verReservasToolStripMenuItem.Enabled = true;
            realizarPrestamoToolStripMenuItem.Enabled = true;
            devolverToolStripMenuItem.Enabled = true;

            lblNombre.Text = string.Concat(string.Concat(s.Nombres, " "), s.Apellido);
            //Debería cargar automáticamente los préstamos que tiene esa persona vigentes
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

            biblioteca = biblioteca.recuperarse();
            //version de prueba mia anterior  
           // biblioteca.cargarse();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void verReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void verPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void realizarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibros fr = new FrmLibros();
            fr.ShowDialog();
            Libro libro = fr.NuevoLibro;
            if (libro != null)
            {
                biblioteca.agregarLibro(libro);
            }
        }
    }
}
