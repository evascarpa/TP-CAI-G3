using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Venta
{
    public class Comprobante
    {
        int _id;
        Guid _idCliente;
        string _cliente;
        string _path;
        DateTime _fechaAlta;

        public Comprobante(int id, Guid idCliente, string cliente, string path, DateTime fechaAlta)
        {
            _id = id;
            _idCliente = idCliente;
            _cliente = cliente;
            _path = path;
            _fechaAlta = fechaAlta;
        }

        public int Id { get => _id; set => _id = value; }
        public Guid IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string Path { get => _path; set => _path = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
