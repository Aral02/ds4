using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_121
{
    public partial class Form1 : Form
    {
        public class Calculos
        {
            // Método para calcular la distancia recorrida
            public double CalcularDistancia(double velocidad, double tiempo)
            {
                return velocidad * tiempo;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VEL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los valores ingresados
                double velocidad = Convert.ToDouble(VEL.Text);
                double tiempo = Convert.ToDouble(TIME.Text);

                // Instanciamos la clase de Cálculos
                Calculos calculos = new Calculos();

                // Calculamos la distancia
                double distancia = calculos.CalcularDistancia(velocidad, tiempo);

                // Mostramos el resultado en el Label
                RES.Text = $" {distancia} metros";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            VEL.Clear();
            TIME.Clear();
            RES.Clear();
            VEL.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
