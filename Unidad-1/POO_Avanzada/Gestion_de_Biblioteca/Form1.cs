using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca
{
    public partial class Form1 : Form
    {
        // Objeto global de la biblioteca
        private Biblioteca _biblioteca = new Biblioteca();

        public Form1()
        {
            InitializeComponent();
        }

        private bool TryParseIntWithMessage(string texto, out int valor, string mensajeError = "Introduce un número entero válido.")
        {
            if (int.TryParse(texto, out valor)) return true;
            MessageBox.Show(mensajeError, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            // Asignar uno por uno (según tu preferencia)
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string isbn = txtISBN.Text.Trim();

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Completa todos los campos del libro.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.ISBN = isbn;

            try
            {
                _biblioteca.AgregarLibro(libro);
                ActualizarListas();
                lblStatus.Text = "Libro agregado.";
                // limpiar controles
                txtTitulo.Clear();
                txtAutor.Clear();
                txtISBN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text.Trim();
            if (!TryParseIntWithMessage(txtIDUsuario.Text.Trim(), out int idUsuario)) return;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce el nombre del usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.ID = idUsuario;

            try
            {
                _biblioteca.AgregarUsuario(usuario);
                ActualizarListas();
                lblStatus.Text = "Usuario agregado.";
                txtNombreUsuario.Clear();
                txtIDUsuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBNPrestar.Text.Trim();
            if (!TryParseIntWithMessage(txtIDPrestar.Text.Trim(), out int idUsuario)) return;

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Introduce el ISBN del libro a prestar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resultado = _biblioteca.PrestarLibro(isbn, idUsuario, out string mensaje);
            lblStatus.Text = mensaje;
            if (resultado)
            {
                ActualizarListas();
                txtISBNPrestar.Clear();
                txtIDPrestar.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "No se pudo prestar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string isbn = txtISBNDevolver.Text.Trim();
            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Introduce el ISBN del libro a devolver.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resultado = _biblioteca.DevolverLibro(isbn, out string mensaje);
            lblStatus.Text = mensaje;
            if (resultado)
            {
                ActualizarListas();
                txtISBNDevolver.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "No se pudo devolver", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Actualiza los ListBox con la info actualizada
        private void ActualizarListas()
        {
            lstLibros.Items.Clear();
            foreach (var l in _biblioteca.ObtenerLibros())
            {
                string estado = _biblioteca.ObtenerPrestamosActivos().Any(p => p.Contains($"ISBN: {l.ISBN}")) ? "Prestado" : "Disponible";
                // Mejor obtener disponibilidad directamente
                bool disponible = _biblioteca.EstaDisponible(l.ISBN);
                estado = disponible ? "Disponible" : "Prestado";
                lstLibros.Items.Add($"{l.Titulo} — {l.Autor} (ISBN: {l.ISBN}) [{estado}]");
            }

            lstUsuarios.Items.Clear();
            foreach (var u in _biblioteca.ObtenerUsuarios())
            {
                lstUsuarios.Items.Add(u.ToString());
            }

            lstPrestamos.Items.Clear();
            foreach (var p in _biblioteca.ObtenerPrestamosActivos())
            {
                lstPrestamos.Items.Add(p);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListas();
        }
    }
}

