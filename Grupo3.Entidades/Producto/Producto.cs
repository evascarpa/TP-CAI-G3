using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    public Guid id { get; set; }
    public int idCategoria { get; set; }
    public string nombre { get; set; }
    public DateTime fechaAlta { get; set; }
    public DateTime? fechaBaja { get; set; }
    public int precio { get; set; }
    public int stock { get; set; }
    public int idUsuario { get; set; }
    public int idProveedor { get; set; }
    public bool stockBajo { get; set; }  //incializa siempre en false

    public Producto(int idCategoria, string nombre, DateTime? fechaBaja, int precio, int stock,
                    int idUsuario, int idProveedor)
    {
        this.id = id;
        this.idCategoria = idCategoria;
        this.nombre = nombre;
        this.fechaAlta = DateTime.Now;
        this.fechaBaja = fechaBaja;
        this.precio = precio;
        this.stock = stock;
        this.idUsuario = idUsuario;
    }

    public override string ToString()
    {
        return $"{nombre} {precio} {stock}";
    }
}
