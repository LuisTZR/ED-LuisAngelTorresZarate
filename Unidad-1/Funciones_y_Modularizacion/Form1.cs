using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_y_Modularizacion
{
    public partial class Form1 : Form
    {
        private List<double> numeros = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private double Sumar(double a, double b) => a + b;
        private double Restar(double a, double b) => a - b;
        private double Multiplicar(double a, double b) => a * b;
        private double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }

        // Función que recibe la lista y devuelve su promedio
        private double Promedio(List<double> lista)
        {
            if (lista == null || lista.Count == 0) throw new InvalidOperationException("La lista está vacía.");
            double suma = 0;
            foreach (var n in lista) suma += n;
            return suma / lista.Count;
        }

        private bool TryParseDouble(string texto, out double valor)
        {
            if (double.TryParse(texto, out valor))
                return true;

            MessageBox.Show("Introduce un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!TryParseDouble(txtA.Text, out double a)) return;
            if (!TryParseDouble(txtB.Text, out double b)) return;

            double r = Sumar(a, b);
            lblResultado.Text = r.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!TryParseDouble(txtA.Text, out double a)) return;
            if (!TryParseDouble(txtB.Text, out double b)) return;

            double r = Restar(a, b);
            lblResultado.Text = r.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!TryParseDouble(txtA.Text, out double a)) return;
            if (!TryParseDouble(txtB.Text, out double b)) return;

            double r = Multiplicar(a, b);
            lblResultado.Text = r.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!TryParseDouble(txtA.Text, out double a)) return;
            if (!TryParseDouble(txtB.Text, out double b)) return;

            try
            {
                double r = Dividir(a, b);
                lblResultado.Text = r.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "∞";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!TryParseDouble(txtNumero.Text, out double n)) return;

            numeros.Add(n);
            lstNumeros.Items.Add(n.ToString());
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                double p = Promedio(numeros);
                lblPromedio.Text = p.ToString("G"); // formato general
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            lstNumeros.Items.Clear();
            lblPromedio.Text = string.Empty;
            txtNumero.Clear();
        }
    }
}
