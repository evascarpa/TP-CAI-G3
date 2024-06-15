using Grupo3.Entidades.Venta;
using Grupo3.Entidades;
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

    public partial class FormReporteVendedor : Form
    {
        public FormPrincipal FormPrincipal;

        public FormReporteVendedor(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            List<Item> items = clienteNegocio.Listar()
                .Select(x => new Item(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new Item("", "Seleccione"));

            cmbVendedores.DisplayMember = "Valor";
            cmbVendedores.ValueMember = "Id";
            cmbVendedores.DataSource = items;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormSelectorReportes(FormPrincipal));

        }

        private void ucBotonStockCritico_Click(object sender, EventArgs e)
        {

        }

        private void ucTitulo2_Load(object sender, EventArgs e)
        {

        }

        private void ucBotonStockCritico_Click_1(object sender, EventArgs e)
        {
            
            if (cmbVendedores.SelectedIndex != 0)
            {
                VentaNegocio ventaNegocio = new VentaNegocio();

                string vendedor = cmbVendedores.SelectedValue.ToString();

                List<Venta> listaVend = ventaNegocio.Listar(Guid.Parse(vendedor));
                dgvReporteVentasPorVendedor.DataSource = listaVend.GroupBy(x => x.FechaAlta.Month).Select(x => new { Mes = x.Key, Cantidad = x.Count() }).OrderBy(x => x.Mes).ToList();
            }
            else
            {
                MessageBox.Show("Seleccione un valor válido");
            }
            
        }
    }
}
