using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Coche_y_Libro
{
    public partial class Form1: Form
    {
        Coche unCoche = new Coche();
        Libro unLibro = new Libro();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            unCoche.Acelerar();
            lblValorVelocidad.Text = (unCoche.Velocidad).ToString() + "km/h";
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            unCoche.Frenar();
            lblValorVelocidad.Text = (unCoche.Velocidad).ToString() + "km/h"; 
            
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            unLibro.Titulo = txtTitulo.Text;
            unLibro.Autor = txtAutor.Text;
            MessageBox.Show(unLibro.MostrarInformacion());
        }
    }
}
