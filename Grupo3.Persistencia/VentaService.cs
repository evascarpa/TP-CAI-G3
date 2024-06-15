using Grupo3.Entidades;
using Grupo3.Entidades.Venta;
using Grupo3.Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Persistencia
{
    public class VentaService : ABMService
    {
        public Guid idCliente { get; set; }
        public override string pathCrear { get; set; } = "/api/Venta/AgregarVenta";
        public override string pathListar { get; set; } = "";
        public override string pathBaja { get; set; } = $"/api/Venta/DevolverVenta";
        public override bool esBajaLogica { get; set; } = true;

        public VentaService()
        {
        }
        public VentaService(Guid idCliente)
        { 
            this.idCliente = idCliente;
            pathListar = $"/api/Venta/GetVentaByCliente?id={idCliente}";
        }
    }
}
