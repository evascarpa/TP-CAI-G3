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
    public partial class FormSelectorReportes : Form
    {
        public FormPrincipal FormPrincipal;

        public FormSelectorReportes(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;

        }


        private void ucBotonStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormReporteStock(FormPrincipal));
        }

        private void ucBotonVentasPorVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormReporteVendedor(FormPrincipal));
        }

        private void ucBotonProdMasVendidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormReporteVendidosPorCategoria(FormPrincipal));
        }
    }
}
