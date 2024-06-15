using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades
{
    public class Baja
    {
        Guid _id;
        Guid _idUsuario;

        public Baja(Guid id, Guid idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
        public Guid id { get => _id; set => _id = value; }
        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
