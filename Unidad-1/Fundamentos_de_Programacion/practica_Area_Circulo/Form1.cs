using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_Area_Circulo
{
    public partial class Form1: Form
    {
        double dblRadio = 0;
        double dblArea = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            dblRadio = double.Parse(txtRadio.Text);
            if (dblRadio > 0)
            {
                dblArea = Math.PI * (dblRadio * dblRadio);
                lblAreaCirculo.Text = $"A = {dblArea}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor de radio valido.");
            }
        }
    }
}
