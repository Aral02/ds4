using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Laboratorio_192.Models.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetItemsAsync()
        {
            var url = "http://localhost:8080/items";

            try
            {
                // Realizar la solicitud GET
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si el estado no es exitoso (200-299)

                // Leer el contenido de la respuesta
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody); // Manejar la respuesta aquí
            }
            catch (HttpRequestException ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
            }
        }
    }

}
