using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente : PersonaNoProveedor
{
    public int idUsuario { get; set; }
    public string host { get; set; }

    public Cliente(string nombre, string apellido, string email, DateTime fechaAlta, DateTime? fechaBaja,
        string direccion, string telefono, int dni, DateTime fechaNacimiento, int idUsuario, string host)
        : base(nombre, apellido, email, fechaAlta, fechaBaja, direccion, telefono, dni, fechaNacimiento)
    {
        this.idUsuario = idUsuario;
        this.host = host;
    }

    public override string ToString()
    {
        return $"{nombre} {apellido} {direccion}";
    }

}


