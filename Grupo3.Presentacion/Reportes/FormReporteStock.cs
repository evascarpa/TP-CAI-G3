using Grupo3.Negocio;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion.Reportes
{
    public partial class FormReporteStock : Form
    {
        public FormPrincipal FormPrincipal;
        public FormReporteStock(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> lista = productoNegocio.Listar();
            List<Producto> listaStockCritico = lista.Where(x => x.stock <= 10)
                                            .OrderBy(x => x.idCategoria)
                                            .ToList();

            dgvReporteStockCritico.DataSource = listaStockCritico;
            dgvReporteStockCritico.Columns["fechaBaja"].Visible = false;
            dgvReporteStockCritico.Columns["idProveedor"].Visible = false;
            dgvReporteStockCritico.Columns["idUsuario"].Visible = false;


        }


        private void ucBotonStockCritico_Click(object sender, EventArgs e)
        {
        }

        private void ucBotonVentasPorVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormSelectorReportes(FormPrincipal));
        }

        private void ucBotonProdMasVendidos_Click(object sender, EventArgs e)
        {

        }

        private void ucTitulo2_Load(object sender, EventArgs e)
        {

        }
    }
}
