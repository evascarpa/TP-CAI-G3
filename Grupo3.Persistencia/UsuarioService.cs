using Grupo3.Entidades;
using Grupo3.Entidades.Proveedor;
using Grupo3.Entidades.Usuario;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public class UsuarioService
    {
        public List<Usuario> TraerUsuariosActivos(Guid a)
        {
            String path = "/api/Usuario/TraerUsuariosActivos?id=" + a;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Usuario> listadoUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
                    return listadoUsuarios;
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
            return usuarios;

        }
        public Guid LogIn(UsuarioLogInRequest usuarioLogInRequest)
        {
            String path = "/api/Usuario/LogIn";

            var jsonRequest = JsonConvert.SerializeObject(usuarioLogInRequest);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    return Guid.Parse(respuesta.Replace(@"""", ""));
                }
                else if (((int)response.StatusCode) == 403)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception("Cuenta inactiva");
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception("Credenciales incorrectas");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
        public void CambiarPassword(CambioPassword cambioPassword)
        {
            String path = $"/api/Usuario/CambiarContraseña";
            try
            {
                var pepe = JsonConvert.SerializeObject(cambioPassword);
                HttpResponseMessage response = WebHelper.Patch(path, JsonConvert.SerializeObject(cambioPassword));
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
        public void ElminarUsuario(Guid id, Guid idUsuario)
        {
            String path = "/api/Usuario/BajaUsuario";

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
        public void AgregarUsuario(UsuarioPost usuarioPost)
        {
            String path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(usuarioPost);

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

        public void ActivarUsuario(Guid id, Guid idUsuario)
        {
            String path = "/api/Usuario/ReactivarUsuario";

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());

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

    }
}
