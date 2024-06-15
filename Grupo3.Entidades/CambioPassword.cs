using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades
{
    public class CambioPassword
    {
        string _nombreUsuario;
        string _contraseña;
        string _contraseñaNueva;

        public CambioPassword(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _contraseñaNueva = contraseñaNueva;
        }
        public string contraseña { get => _contraseña; set => _contraseña = value; }
        public string contraseñaNueva { get => _contraseñaNueva; set => _contraseñaNueva = value; }
        public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

    }
}
