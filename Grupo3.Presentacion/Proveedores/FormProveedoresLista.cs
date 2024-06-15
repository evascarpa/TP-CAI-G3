using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion.Proveedores
{
    public partial class FormProveedoresLista : Form
    {
        public FormPrincipal FormPrincipal; // consultar si esto va

        public FormProveedoresLista(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            cargarDatos();
            FormPrincipal = formPrincipal; // consultar si esto va
        }
        private void cargarDatos()
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            List<Proveedor> lista = proveedorNegocio.Listar();
            lista = lista.OrderBy(Proveedor => Proveedor.nombre).ToList();

            dgvProveedores.DataSource = lista;
            dgvProveedores.Columns["id"].DisplayIndex = 0;
            dgvProveedores.Columns["nombre"].DisplayIndex = 1;
            dgvProveedores.Columns["apellido"].DisplayIndex = 2;
            dgvProveedores.Columns["fechaAlta"].Visible = false;
            dgvProveedores.Columns["fechaBaja"].Visible = false;
            ActualizarCategoria();


        }

        private void ActualizarCategoria()
        {
            CategoriaArchivo archivo = new CategoriaArchivo();
            List<CategoriaFormato> listcat = archivo.RecuperarRegistros();
            foreach (CategoriaFormato cat in listcat)
            {
                string IdProveedor = cat.Id;
                string Cat = cat.Categoria;
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    if (row.Cells["id"].Value.ToString() != null && row.Cells["id"].Value.ToString() == IdProveedor)
                    {
                        row.Cells["categorias"].Value = Cat;
                        break;
                    }
                }
            }           
        }

        private void dgvProovedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormProveedoresAlta(FormPrincipal));
        }
        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea borrar el proveedor?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvProveedores.CurrentRow;
                        object idValue = selectedRow.Cells["id"].Value;
                        ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

                        proveedorNegocio.eliminarProveedor(Guid.Parse(idValue.ToString()), UsuarioSesion.Id);
                        cargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para borrarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
