using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca
{
    public class Biblioteca
    {
        private List<Libro> _lstLibros = new List<Libro>();
        private List<Usuario> _lstUsuarios = new List<Usuario>();

        private Dictionary<string, int> _dicPrestamos = new Dictionary<string, int>();

        public void AgregarLibro(Libro libro)
        {
            if (libro == null) throw new ArgumentNullException(nameof(libro));
            if (_lstLibros.Any(l => l.ISBN == libro.ISBN))
                throw new InvalidOperationException("Ya existe un libro con ese ISBN.");
            _lstLibros.Add(libro);
        }

        // Añadir usuario
        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null) throw new ArgumentNullException(nameof(usuario));
            if (_lstUsuarios.Any(u => u.ID == usuario.ID))
                throw new InvalidOperationException("Ya existe un usuario con ese ID.");
            _lstUsuarios.Add(usuario);
        }

        // Comprobar disponibilidad de un libro
        public bool EstaDisponible(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) return false;
            return !_dicPrestamos.ContainsKey(isbn) && _lstLibros.Any(l => l.ISBN == isbn);
        }

        // Prestar libro: retorna true si se prestó correctamente, false si no
        public bool PrestarLibro(string isbn, int usuarioId, out string mensaje)
        {
            mensaje = string.Empty;

            if (!_lstLibros.Any(l => l.ISBN == isbn))
            {
                mensaje = "No existe un libro con ese ISBN.";
                return false;
            }
            if (!_lstUsuarios.Any(u => u.ID == usuarioId))
            {
                mensaje = "No existe un usuario con ese ID.";
                return false;
            }
            if (_dicPrestamos.ContainsKey(isbn))
            {
                mensaje = "El libro ya está prestado.";
                return false;
            }

            _dicPrestamos[isbn] = usuarioId;
            mensaje = "Préstamo realizado correctamente.";
            return true;
        }

        // Devolver libro
        public bool DevolverLibro(string isbn, out string mensaje)
        {
            mensaje = string.Empty;

            if (!_dicPrestamos.ContainsKey(isbn))
            {
                mensaje = "Ese libro no está prestado actualmente.";
                return false;
            }

            _dicPrestamos.Remove(isbn);
            mensaje = "Devolución registrada correctamente.";
            return true;
        }

        // Listados para UI
        public List<Libro> ObtenerLibros() => new List<Libro>(_lstLibros);

        public List<Usuario> ObtenerUsuarios() => new List<Usuario>(_lstUsuarios);

        // Lista de préstamos legibles: "ISBN -> UsuarioNombre (ID)"
        public List<string> ObtenerPrestamosActivos()
        {
            var salida = new List<string>();
            foreach (var kv in _dicPrestamos)
            {
                string isbn = kv.Key;
                int id = kv.Value;
                var usuario = _lstUsuarios.FirstOrDefault(u => u.ID == id);
                var libro = _lstLibros.FirstOrDefault(l => l.ISBN == isbn);
                string libroTxt = libro != null ? libro.Titulo : isbn;
                string usuarioTxt = usuario != null ? usuario.Nombre : id.ToString();
                salida.Add($"{libroTxt} (ISBN: {isbn}) -> {usuarioTxt} (ID: {id})");
            }
            return salida;
        }
    }
}
