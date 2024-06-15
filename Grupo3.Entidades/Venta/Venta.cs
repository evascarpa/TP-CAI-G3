using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Venta
{
    Guid _id;
    Guid _idCliente;
    Guid _idProducto;
    int _cantidad;
    int _categoria;
    DateTime _fechaAlta;
    int _estado;
    Guid _idUsuario;

    public Venta(Guid id, Guid idCliente, Guid idProducto, int cantidad, DateTime fechaAlta, int estado, Guid idUsuario, int categoria)
    {
        _id = id;
        _idCliente = idCliente;
        _idProducto = idProducto;
        _cantidad = cantidad;
        _fechaAlta = fechaAlta;
        _estado = estado;
        _idUsuario = idUsuario;
        _categoria = categoria;
    }

    public Guid Id { get => _id; set => _id = value; }
    public Guid IdCliente { get => _idCliente; set => _idCliente = value; }
    public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
    public int Cantidad { get => _cantidad; set => _cantidad = value; }
    public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    public int Estado { get => _estado; set => _estado = value; }
    public int Categoria { get => _categoria; set => _categoria = value; }
    public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }

}
