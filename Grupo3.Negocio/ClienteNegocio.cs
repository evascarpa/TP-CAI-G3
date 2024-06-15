using Grupo3.Entidades.Cliente;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Negocio
{
    public class ClienteNegocio
    {
        public void agregar(ClientePost cliente)
        {
            //implementar alta de cliente
            ClienteService clienteService = new ClienteService();    
            clienteService.AgregarCliente(cliente); 

            // Cliente cliente = new Cliente(); 

        }
        public List<Cliente> Listar()
        {
            ClienteService clienteService = new ClienteService();
            return clienteService.getClientes();

        }

        public Cliente buscarUnCliente(Guid id) 
        {
            ClienteService clienteService = new ClienteService();
            return clienteService.BuscarUnCliente(id);             
        }

        public void modificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {
            ClienteService clienteService = new ClienteService();
            //clienteService.BuscarUnCliente(); 
            clienteService.ModificarCliente(idCliente, direccion, telefono, email);
        }



    }
}
