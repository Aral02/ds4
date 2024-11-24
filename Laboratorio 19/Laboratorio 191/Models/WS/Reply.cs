using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_191.Models.WS
{
    public class Reply
    {
        // Código de respuesta HTTP (por ejemplo, 200 para éxito, 404 para no encontrado, etc.)
        public int result { get; set; }

        // Datos opcionales; puede ser null si no hay información que retornar
        public object Data { get; set; }

        // Mensaje informativo para el cliente
        public string message { get; set; }

        // Constructor para establecer valores predeterminados
        public Reply()
        {
            result = 500; // Por defecto, error del servidor
            Data = null;  // Sin datos
            message = "Ocurrió un error inesperado"; // Mensaje genérico
        }
    }
}