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
            FrmSocios fr = new FrmSocios();
            fr.ShowDialog();
            if (fr.NuevoSocio != null)
            {
                biblioteca.agregarSocio()
            }
        }
    }
}
