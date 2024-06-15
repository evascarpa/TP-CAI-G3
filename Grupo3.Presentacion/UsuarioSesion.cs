using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Presentacion
{
    public static class UsuarioSesion
    {
        public static string Nombre { get; set; }
        public static Guid Id { get; set; }
        
        public static void Limpiar()
        {
            Nombre = String.Empty;
            Id = Guid.Empty;
           
        }
    }
}
