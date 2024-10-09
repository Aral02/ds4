using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Laboratorio_122
{
    public partial class Form1 : Form
    {
        public class Calculos
        {
            public double CalcularPromedio(double n1, double n2, double n3)
            {
                return (n1 + n2 + n3) / 3;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los valores ingresados
                double n1 = Convert.ToDouble(N1.Text);
                double n2 = Convert.ToDouble(N2.Text);
                double n3 = Convert.ToDouble(N3.Text);

                // Instanciamos la clase de Cálculos
                Calculos calculos = new Calculos();

                // Calculamos el promedio
                double prom = calculos.CalcularPromedio(n1, n2, n3);

                // Mostramos el resultado en el Label
                Avg.Text = $" {prom} metros";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            N1.Clear();
            N2.Clear();
            N3.Clear();
            Avg.Clear();
            N1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
