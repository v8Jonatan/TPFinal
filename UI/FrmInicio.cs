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
            // buscar de prueba para ver si lo agregaba bien colo funciona con dni
            Socio s=biblioteca.buscarDni(int.Parse(txtDni.Text));
            if (s != null)
                txtNroSocio.Text = s.Id.ToString();
            else
                MessageBox.Show(this, "Socio no existe");
           
        }
    }
}
