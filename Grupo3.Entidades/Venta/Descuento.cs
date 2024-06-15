using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Venta
{
    public class Descuento
    {
        string _nombre;
        int _monto;
        double _porcentaje;

        public Descuento()
        {
        }

        public Descuento(string nombre, int monto, double porcentaje)
        {
            _nombre = nombre;
            _monto = monto;
            _porcentaje = porcentaje;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Monto { get => _monto; set => _monto = value; }
        public double Porcentaje { get => _porcentaje; set => _porcentaje = value; }
    }
}