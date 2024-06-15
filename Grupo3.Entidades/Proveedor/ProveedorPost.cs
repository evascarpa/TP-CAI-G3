using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Proveedor
{
    public class ProveedorPost
    {
        string _idUsuario;
        string _nombre;
        string _apellido;
        string _email;
        string _cuit;

        public ProveedorPost(string idusuario, string nombre, string apellido, string email, string cuit)
        {
            _idUsuario = idusuario;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
        }

        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public string email { get => _email; set => _email = value; }
        public string cuit { get => _cuit; set => _cuit = value; }

    }
}
