﻿using System;
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
        private Socio socioActual;
        public FrmInicio()
        {
            InitializeComponent();

            biblioteca = new Biblioteca();
            Biblioteca nueva = biblioteca.recuperarse();
            biblioteca = nueva;
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
            if (!txtDni.Text.Trim().Equals(""))           
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
            this.socioActual=s;
            lblNombre.Visible = true;
            btnDetalleSocio.Visible = true;
            panel1.Visible = false;
            verPrestamosToolStripMenuItem.Enabled = true;
            verReservasToolStripMenuItem.Enabled = true;
            realizarPrestamoToolStripMenuItem.Enabled = true;
            devolverToolStripMenuItem.Enabled = true;
            lblNombre.Text = string.Concat(string.Concat(s.Nombres, " "), s.Apellido);
            //Cargar automáticamente los préstamos que tiene esa persona vigentes
            mostrarPrestamosVigentes(s.Prestamos.FindAll(x => x.Devolucion == false)); 
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
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
            if (datagridDatos.SelectedRows.Count == 1)//datagridDatos.SelectedRows.Count == 1
            {
                int codLibro=(int)datagridDatos.SelectedRows[0].Cells[0].Value;
                //int codLibro = 3;
                biblioteca.RealizarPrestamo(codLibro, socioActual);

            }
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibros fr = new FrmLibros(biblioteca);
            fr.ShowDialog();
            Libro libro = fr.NuevoLibro;
            if (libro != null)
            {
                biblioteca.agregarLibro(libro);
            }
            else
            {
                
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            //if (txtBusqueda.Equals("todos"))
             //   datagridDatos.DataSource = biblioteca.Libros;
           // else
            if (radiobtnTitulo.Checked)
            {
                datagridDatos.DataSource=
                biblioteca.buscarLibro(txtBusqueda.Text,"titulo");
            }
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Metodo para reservar despues mover a la parte web
            int idlibro=3;
          //  biblioteca.reservar(socioActual,idlibro);
        }

        private void agregarEjemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void mostrarPrestamosVigentes(List<Prestamo> prestamos)
        {
            //Debe cargar en el dataGridView
            datagridDatos.DataSource = prestamos;
            //Por ahí deberíamos filtrar algunas filas que no queramos ver en la tabla desde este metodo
        }

        private void btnDetalleSocio_Click(object sender, EventArgs e)
        {
            FrmVerSocios fr = new FrmVerSocios(socioActual);
            fr.ShowDialog();
        }
    }
}
