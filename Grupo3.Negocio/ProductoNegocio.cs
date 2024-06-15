using Grupo3.Entidades.Producto;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Negocio
{
    public class ProductoNegocio
    {
        ProductoService productoService = new ProductoService();
        public List<Producto> Listar()
        {
            var productos= productoService.TraerProductos();
           
            foreach (Producto producto in productos.Where(x => x.stock <= 10))
            { 
                producto.stockBajo = true;
            }
            return productos;
        }

        public List<Producto> ListarXCategoria(int categoria)
        {
            ProductoService ProductoService = new ProductoService();
            //return ProductoService.TraerProductosPorCategoria(categoria);
            var productos= ProductoService.TraerProductosPorCategoria(categoria);

            foreach (Producto producto in productos.Where(x => x.stock <= 10))
            {
                producto.stockBajo = true;
            }
            return productos;

        }

        public void agregarProducto(int idCategoria, string idUsuario, string idProveedor, string nombre, int precio, int stock)
        {
            ProductoPost productoPost = new ProductoPost(idCategoria, idUsuario, idProveedor, nombre, precio, stock);
            productoService.AgregarProducto(productoPost);

        }

        public void modificarProducto(Guid id, Guid idUsuario, int precio, int stock)
        {            
            productoService.ModificarProducto(id, idUsuario, precio, stock);
        }

        public void bajaProducto(Guid id, Guid idUsuario)
        {
            productoService.BorrarProducto(id, idUsuario);
        }
    }
}