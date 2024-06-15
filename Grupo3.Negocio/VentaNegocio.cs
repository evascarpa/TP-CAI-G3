using Grupo3.Entidades;
using Grupo3.Entidades.Venta;
using Grupo3.Persistencia;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Grupo3.Negocio
{
    public class VentaNegocio
    {
        public void Crear(Guid idCliente, Guid idProducto, Guid idUsuario, int cantidad)
        {
            VentaService ventaService = new VentaService();
            VentaPost ventaPost = new VentaPost(idCliente, idUsuario, idProducto, cantidad);

            ventaService.Crear(ventaPost);
        }
        public List<Venta> Listar(Guid idCliente)
        {
            VentaService ventaService = new VentaService(idCliente);
            return ventaService.Listar<Venta>();
        }
        public void Baja(Guid idVenta, Guid idUsuario)
        {
            VentaService ventaService = new VentaService();
            ventaService.Baja(idVenta, idUsuario);
        }

        public Descuento calcularDescuento(List<VentaLista> ventas)
        {
            Descuento descuento = new Descuento();

            int descuentoElectro = ventas.Where(x => x.Categoria == 3).Sum(x => x.PrecioTotal);

            if (descuentoElectro > 100000)
            {
                descuento = new Descuento("Promo electro hogar", 0, 0.05);
            }

            return descuento;
        }

        private string Path { get; set; } = $@"C:\PdfPurebas\Template";
        private void CrearArchivo()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        public string GenerarPDF(int id, Cliente cliente, List<VentaLista> ventaLista, Descuento descuento)
        {
            try
            {
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string codigo = id.ToString("D8");
                CrearArchivo();
                string pathArchivo = $@"{Path}\{codigo}.pdf";
                var promociones = new[] { "Promoción 1: Descuento del 10%", "Promoción 2: Envío gratuito" };
                var montoTotal = ventaLista.Sum(d => d.PrecioTotal);

                int descuentos = 0;
                if (descuento != null)
                {
                    descuentos = Convert.ToInt32(montoTotal * descuento.Porcentaje);
                }
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {

                        page.Margin(10);
                        page.Header()
                            .AlignCenter()
                            .Text("ElectroHogar S.A.");

                        page.Content()
                           .Column(stack =>
                           {
                               stack.Item().Text($"Fecha de Operación: {DateTime.Now.ToString("dd/MM/yyyy")}");
                               stack.Item().Text($"Cliente: {cliente.nombre} {cliente.apellido}").AlignRight();
                               stack.Item().Text($"DNI: {cliente.dni}").AlignRight();
                               stack.Item().Text($"Direccion: {cliente.direccion}").AlignRight();
                               stack.Item().Text("Detalle").FontSize(14);

                               stack.Item().Table(table =>
                               {
                                   table.ColumnsDefinition(columns =>
                                   {
                                       columns.ConstantColumn(100);
                                       columns.RelativeColumn(3);
                                       columns.RelativeColumn();
                                       columns.RelativeColumn();
                                       columns.RelativeColumn();

                                   });

                                   table.Header(header =>
                                   {
                                       header.Cell().Element(Style).Text("IdProducto");
                                       header.Cell().Element(Style).Text("Descripción");
                                       header.Cell().Element(Style).AlignRight().Text("Cantidad");
                                       header.Cell().Element(Style).AlignRight().Text("Monto Unitario");
                                       header.Cell().Element(Style).AlignRight().Text("Monto Total");

                                       IContainer Style(IContainer container)
                                       {
                                           return container
                                               .DefaultTextStyle(x => x.SemiBold())
                                               .BorderBottom(1)
                                               .BorderColor(Colors.Grey.Darken2)
                                               .Padding(5);
                                       }
                                   });

                                   foreach (var venta in ventaLista)
                                   {

                                       table.Cell().Element(Style).Text($"{venta.Producto.Id}");
                                       table.Cell().Element(Style).Text($"{venta.Producto.Valor}");
                                       table.Cell().Element(Style).AlignRight().Text($"{venta.Cantidad}");
                                       table.Cell().Element(Style).AlignRight().Text($"{venta.PrecioUnitario}");
                                       table.Cell().Element(Style).AlignRight().Text($"{venta.PrecioTotal}");

                                       IContainer Style(IContainer container)
                                       {
                                           return container
                                               .BorderBottom(1)
                                               .BorderColor(Colors.Grey.Lighten2)
                                               .Padding(5);
                                       }
                                   }

                                   if (descuentos > 0)
                                   {
                                       table.Cell().Element(Style).Text($"");
                                       table.Cell().Element(Style).Text($"{descuento.Nombre}");
                                       table.Cell().Element(Style).AlignRight().Text($"");
                                       table.Cell().Element(Style).AlignRight().Text($"");
                                       table.Cell().Element(Style).AlignRight().Text($"{descuentos}");

                                       IContainer Style(IContainer container)
                                       {
                                           return container
                                               .BorderBottom(1)
                                               .BorderColor(Colors.Grey.Lighten2)
                                               .Padding(5);
                                       }

                                   }

                                   IContainer StyleFooter(IContainer container)
                                   {
                                       return container
                                           .BorderTop(1)
                                           .BorderColor(Colors.Grey.Darken2)
                                           .Padding(5);
                                   }

                                   table.Footer(footer =>
                                   {
                                       footer.Cell().ColumnSpan(4).Element(StyleFooter).AlignRight().DefaultTextStyle(x => x.SemiBold()).Text("Total");
                                       footer.Cell().Element(StyleFooter).DefaultTextStyle(x => x.SemiBold()).AlignRight().Text($"{montoTotal - descuentos}");
                                   });
                               });

                           });
                    });
                }).GeneratePdf(pathArchivo);

                return pathArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepcion al generar el comprobante");
            }
        }
    }
}