
using Grupo3.Entidades;
using Grupo3.Entidades.Usuario;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Negocio
{
    public class UsuarioNegocio
    {

        UsuarioService usuarioService = new UsuarioService();

        public List<Usuario> Listar()
        {
            UsuarioService usuarioService = new UsuarioService();
            return usuarioService.TraerUsuariosActivos(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"));
        }
        public void AgregarUsuario(string idUsuario, int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            UsuarioPost usuarioPost = new UsuarioPost(idUsuario, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(usuarioPost);
        }
        public void CambiarPassword(string idUsuario, string password, string nuevaPassword )
        {
            usuarioService.CambiarPassword(new CambioPassword(idUsuario, password, nuevaPassword));
        }
        public void eliminarUsuario(Guid id, Guid idUsuario)
        {
            usuarioService.ElminarUsuario(id, idUsuario);
        }

        public void ActivarUsuario(Guid id, Guid idUsuario)
        {
            usuarioService.ActivarUsuario(id, idUsuario);
        }
        public Guid LogIn(string usuario, string password)
        {
            UsuarioLogInRequest usuarioLogInRequest = new UsuarioLogInRequest(usuario, password);

            return usuarioService.LogIn(usuarioLogInRequest);
        }

    }
}
