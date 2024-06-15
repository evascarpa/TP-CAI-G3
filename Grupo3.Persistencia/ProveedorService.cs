using Grupo3.Entidades;
using Grupo3.Entidades.Proveedor;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public class ProveedorService
    {
        public List<Proveedor> TraerProveedores()
        {
            String path = "/api/Proveedor/TraerProveedores";
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Proveedor> listadoProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
                    return listadoProveedores;
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
            return proveedores;
        }

        public void AgregarProveedor(ProveedorPost proveedorPost)
        {
            String path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(proveedorPost);

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
            
        public void EliminarProveedor(Guid id, Guid idUsuario)
        {
            String path = "/api/Proveedor/BajaProveedor";

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());

            var jsonRequest = JsonConvert.SerializeObject(map);
            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
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
        }
    } 