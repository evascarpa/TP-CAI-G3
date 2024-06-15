using Grupo3.Entidades;
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
    public partial class FormReporteVendidosPorCategoria : Form
    {
        private FormPrincipal FormPrincipal;

        public FormReporteVendidosPorCategoria(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            FormPrincipal = formPrincipal;
            List<Item> listacat = new List<Item>();
            listacat.Add(new Item("0", "Todas"));
            listacat.Add(new Item("1", "Audio"));
            listacat.Add(new Item("2", "Celulares"));
            listacat.Add(new Item("3", "Electro Hogar"));
            listacat.Add(new Item("4", "Informática"));
            listacat.Add(new Item("5", "Smart TV"));

            cmbCategoria.DisplayMember = "Valor";
            cmbCategoria.ValueMember = "Id";

            cmbCategoria.DataSource = listacat
                .OrderBy(x => x.Id)
                .ToList();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormSelectorReportes(FormPrincipal));
        }

        private void cmbCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
