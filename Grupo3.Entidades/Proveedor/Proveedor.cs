using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Proveedor : Persona
{
    public string cuit { get; set; }
    public string categorias { get; set; }

    public Proveedor(string nombre, string apellido, string email, DateTime fechaAlta, DateTime? fechaBaja,
        string cuit, string categorias)
        : base(nombre, apellido, email, fechaAlta, fechaBaja)
    {
        this.cuit = cuit;
        this.categorias = categorias;
    }
        public override string ToString()
    {
        return $"{nombre} {apellido} {cuit}";
    }
}

