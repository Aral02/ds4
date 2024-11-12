using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cadena de conexión a la base de datos
        string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear y abrir la conexión
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión abierta con el servidor SQL Server.");

                    // Definir la consulta SQL
                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    // Limpiar el ListBox antes de llenarlo
                    listBox1.Items.Clear();

                    // Leer los resultados y añadirlos al ListBox
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["ProductName"].ToString());
                    }

                    reader.Close();
                    MessageBox.Show("Productos cargados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    conexion.Close();
                    MessageBox.Show("Conexión cerrada.");
                }
            }
        }
    }
}

