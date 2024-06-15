using Grupo3.Entidades;
using Grupo3.Entidades.Proveedor;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Negocio
{
    public class ProveedorNegocio
    {
        ProveedorService proveedorService = new ProveedorService();
        public List<Proveedor> Listar()
        {
            return proveedorService.TraerProveedores();
        }
        public void agregarProveedor(string idUsuario, string nombre, string apellido, string email, string cuit)
        {
            ProveedorPost proveedorPost = new ProveedorPost(idUsuario, nombre, apellido, email, cuit);
            proveedorService.AgregarProveedor(proveedorPost);
        }
        public void eliminarProveedor(Guid id, Guid idUsuario)
        {
            proveedorService.EliminarProveedor(id, idUsuario);
        }
      /*  public List<Producto> ListarPorVendedor(string vendedor)
        {
            ProveedorService ProveedorService = new ProveedorService();
            //return ProductoService.TraerProductosPorCategoria(categoria);
            var productos = ProveedorService.Traer(vendedor);

        }
      */
    }
}