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
        private List<Autor> autores;
        private Biblioteca biblioteca;
        public FrmLibros(Biblioteca biblio)
        {
            InitializeComponent();
            biblioteca = biblio;
            comboBoxAutores.DataSource = autores;
            comboBoxAutores.DisplayMember = "Apenom";
            
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string genero = txtGenero.Text;
            string isbn = txtIsbn.Text;
            int cantEjemplares= int.Parse(txtEjemplares.Text);
            Autor autor = (Autor)comboBoxAutores.SelectedItem;
            string editorial = txtEditorial.Text; 
            nuevoLibro = new Libro(titulo, genero,isbn,editorial,cantEjemplares);
            nuevoLibro.Autor = autor;

            this.Close();
        }
        public Libro NuevoLibro
        {
            get { return nuevoLibro; }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            FrmAutor fr = new FrmAutor();
            fr.ShowDialog();
            Autor nuevoAutor = fr.NuevoAutor;
            if (nuevoAutor != null)
            {
                biblioteca.agregarAutor(nuevoAutor);
            }
            comboBoxAutores.DataSource = null;
            comboBoxAutores.DisplayMember = null;
            comboBoxAutores.DataSource = biblioteca.Autores;
            comboBoxAutores.DisplayMember = "Apenom";
        }
       
    }
}
