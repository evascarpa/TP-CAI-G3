using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Venta
{
    public class VentaPost
    {
        Guid _idCliente;
        Guid _idUsuario;
        Guid _idProducto;
        int _cantidad;

        public VentaPost(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad)
        {
            _idCliente = idCliente;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _cantidad = cantidad;
        }

        public Guid idCliente { get => _idCliente; set => _idCliente = value; }
        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid idProducto { get => _idProducto; set => _idProducto = value; }
        public int cantidad { get => _cantidad; set => _cantidad = value; }
    }
}


