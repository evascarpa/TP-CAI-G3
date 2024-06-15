using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Producto
{
    public class ProductoPost
    {
        int _idCategoria;
        string _idUsuario;
        string _idProveedor;
        string _nombre;
        int _precio;
        int _stock;

        public ProductoPost(int idCategoria, string idUsuario, string idProveedor, string nombre, int precio, int stock)
        {
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }

        public int idCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public int precio { get => _precio; set => _precio = value; }
        public int stock { get => _stock; set => _stock = value; }
    }
}