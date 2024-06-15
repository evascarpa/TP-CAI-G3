using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Entidades.Cliente
{
    public class ClientePost
    {
        Guid _idUsuario;
        string _nombre;
        string _apellido;
        int _dni;
        string _direccion;
        string _telefono;
        string _email;
        DateTime _fechaNacimiento;
        string _host;

        public ClientePost(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            _idUsuario = idUsuario;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
            _host = host;

        }


        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string host { get => _host; set => _host = value; }









        /*
        public ClientePost(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            this.id = Guid.NewGuid();
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.host = host;
        }


        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string host { get; set; }

        */


    }
}