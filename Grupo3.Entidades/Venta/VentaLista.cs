using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Venta
{
    public class VentaLista
    {
        Item _producto;
        int _categoria;
        int _cantidad;
        int _precioUnitario;
        int _precioTotal;

        public VentaLista(Item producto, int cantidad, int precioUnitario, int precioTotal, int categoria)
        {
            _producto = producto;
            _cantidad = cantidad;
            _precioUnitario = precioUnitario;
            _precioTotal = precioTotal;
            _categoria = categoria;
        }

        public Item Producto { get => _producto; set => _producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public int PrecioTotal { get => _precioTotal; set => _precioTotal = value; }
        public int Categoria { get => _categoria; set => _categoria = value; }
    }
}