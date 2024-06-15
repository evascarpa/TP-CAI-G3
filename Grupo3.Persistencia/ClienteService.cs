using Grupo3.Entidades.Cliente;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public class ClienteService
    {
        public List<Cliente> getClientes()
        {
            String path = "/api/Cliente/GetClientes";
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Cliente> listadoClientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
                  
                    return listadoClientes;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return clientes;

        }

        //TRAER EL CLIENTE QUE QUIERO EDITAR
        public Cliente BuscarUnCliente(Guid id)
        {
            String path = "/api/Cliente/GetCliente?id=" + id;
           // Cliente cliente = new Cliente();
           // List<Cliente> cliente = new List<Cliente>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Cliente clienteBuscado = JsonConvert.DeserializeObject<Cliente>(contentStream);

                    return clienteBuscado;
                }
                else
                {
                    Console.WriteLine($"Error en búsqueda de cliente: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception("Excepcion");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex;
            }
           
        }

        public void ModificarCliente(Guid idCliente, String direccion, String telefono, String email)
        {
            String path = "/api/Cliente/PatchCliente";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idCliente.ToString());
            map.Add("direccion", direccion);
            map.Add("telefono", telefono);
            map.Add("email", email);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex;
            }
        }

        public void AgregarCliente(ClientePost altaCliente)
        {
            String path = "/api/Cliente/AgregarCliente";

            var jsonRequest = JsonConvert.SerializeObject(altaCliente);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex; 
            }
        }

        public void BorrarCliente(Guid idCliente)
        {
            String path = "/api/Cliente/BajaCliente?id=" + idCliente;

            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
