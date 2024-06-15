using Grupo3.Entidades.Producto;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public class ProductoService
    {
        public List<Producto> TraerProductos()
        {
            String path = "/api/Producto/TraerProductos";
            List<Producto> productos = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return listadoProductos;
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
            return productos;

        }

        public List<Producto> TraerProductosPorCategoria(int categoria)
        {
            String path = $"/api/Producto/TraerProductosPorCategoria?catnum="+categoria;
            List<Producto> resultado = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return listadoProductos;
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
            return resultado;
        }

        public void ModificarProducto(Guid id, Guid idUsuario, int precio, int stock)
        {
            String path = "/api/Producto/ModificarProducto";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());
            map.Add("precio", precio.ToString());
            map.Add("stock", stock.ToString());

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

        public void AgregarProducto(ProductoPost Productopost)
        {
            String path = "/api/Producto/AgregarProducto";

            var jsonRequest = JsonConvert.SerializeObject(Productopost);

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

        public void BorrarProducto(Guid id, Guid idUsuario)
        {
            String path = "/api/Producto/BajaProducto";

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
