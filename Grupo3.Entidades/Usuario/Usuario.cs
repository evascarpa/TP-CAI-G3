using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Usuario : PersonaNoProveedor
{
    public string nombreUsuario { get; set; }   
    public string contraseña { get; set; }
    public int host { get; set; }

    public Usuario(string nombre, string apellido, string email, DateTime fechaAlta, DateTime? fechaBaja,
        string direccion, string telefono, int dni, DateTime fechaNacimiento, string nombreUsuario, string contraseña, int host)
        : base (nombre, apellido, email, fechaAlta, fechaBaja, direccion, telefono, dni, fechaNacimiento)
    {
        this.nombreUsuario = nombreUsuario;
        this.contraseña = contraseña;
        this.host = host;
    }
}
