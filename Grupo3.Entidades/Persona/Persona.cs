using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Persona
{
    public Guid id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string email { get; set; }  
    public DateTime fechaAlta { get; set; }
    public DateTime? fechaBaja { get; set; }    

    public Persona(string nombre, string apellido, string email, DateTime fechaAlta, DateTime? fechaBaja)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.fechaAlta = DateTime.Now;
        this.fechaBaja = fechaBaja;
    }
}