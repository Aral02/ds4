using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_123
{
    public partial class Form1 : Form
    {
        public class Triangulo
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public Triangulo(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public double CalcularSemiperimetro()
            {
                return (A + B + C) / 2;
            }

            public double CalcularArea()
            {
                double s = CalcularSemiperimetro();
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }

        }
        private Triangulo triangulo;
            public Form1()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    // Obtener los valores de los TextBox y convertirlos a double
                    double a = Convert.ToDouble(A.Text);
                    double b = Convert.ToDouble(B.Text);
                    double c = Convert.ToDouble(C.Text);

                    // Crear una instancia de la clase Triangulo
                    triangulo = new Triangulo(a, b, c);

                    // Calcular el semiperímetro
                    double semiperimetro = triangulo.CalcularSemiperimetro();

                    // Mostrar el resultado en el Label
                    P.Text = $"{semiperimetro}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                A.Clear();
                B.Clear();
                C.Clear();
                P.Clear();
                AREA.Clear();
                A.Focus();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        private void btn_area_Click(object sender, EventArgs e)
        {
            try
            {
                if (triangulo == null)
                {
                    MessageBox.Show("Primero debe calcular el semiperímetro.");
                    return;
                }

                // Calcular el área
                double area = triangulo.CalcularArea();

                // Mostrar el resultado en el Label
                AREA.Text = $"{area}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
        }
    }
}
    
