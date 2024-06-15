using Grupo3.Entidades;
using Grupo3.Entidades.Venta;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public abstract class ABMService
    {
        public abstract string pathCrear { get; set; }
        public abstract string pathListar { get; set; }
        public abstract string pathBaja { get; set; }
        public virtual bool esBajaLogica { get; set; } = false;
        public void Crear<T>(T postData)
        {
            var jsonRequest = JsonConvert.SerializeObject(postData);

            try
            {
                HttpResponseMessage response = WebHelper.Post(pathCrear, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<T> Listar<T>()
        {
            List<T> resultado = new List<T>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(pathListar);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<T> listadoClientes = JsonConvert.DeserializeObject<List<T>>(contentStream);
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
            return resultado;
        }
        public void Baja(Guid id, Guid idUsuario)
        {
            try
            {
                Dictionary<string, string> map = new Dictionary<string, string>();
                map.Add("id", id.ToString());
                map.Add("idUsuario", idUsuario.ToString());

                var jsonRequest = JsonConvert.SerializeObject(map);

                HttpResponseMessage response = esBajaLogica ? WebHelper.Patch(pathBaja, JsonConvert.SerializeObject(jsonRequest)) : WebHelper.Delete(pathBaja);
                if (!response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
