using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_sumar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los textos de los TextBox a números
                int numero1 = int.Parse(Num1.Text);
                int numero2 = int.Parse(Num2.Text);

                // Realizar la suma
                int resultado = numero1 + numero2;

                // Mostrar el resultado en el Label
                Res.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                Res.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}