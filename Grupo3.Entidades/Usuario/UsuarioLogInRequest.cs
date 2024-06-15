using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Usuario
{
    public class UsuarioLogInRequest
    {
        string _nombreUsuario;
        string _contraseña;

        public UsuarioLogInRequest(string nombreUsuario, string contraseña)
        {
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
        }

        public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string contraseña { get => _contraseña; set => _contraseña = value; }
    }
}
