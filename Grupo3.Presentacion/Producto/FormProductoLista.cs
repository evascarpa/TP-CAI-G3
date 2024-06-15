using Grupo3.Entidades;
using Grupo3.Negocio;
using Grupo3.Persistencia;
using Grupo3.Presentacion.Proveedores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion
{
    public partial class FormProductoLista : Form
    {
        public FormPrincipal FormPrincipal;

        Validador validador = new Validador();

        public FormProductoLista(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            cargarDatos();
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

        private void cargarDatos()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();

            List<Producto> lista = productoNegocio.Listar();
            lista = lista.OrderBy(x => x.idCategoria).ToList();

            dgvProducto.DataSource = lista;
            dgvProducto.Columns["fechaBaja"].Visible = false;
            dgvProducto.Columns["idProveedor"].Visible = false;
            dgvProducto.Columns["idUsuario"].Visible = false;

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAgregar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormProductoAlta(FormPrincipal));
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex != 0)
            {
                ProductoNegocio productoNegocio = new ProductoNegocio();

                string categoria = cmbCategoria.SelectedValue.ToString();

                List<Producto> listacat = productoNegocio.ListarXCategoria(Int32.Parse(categoria));
                listacat = listacat.OrderBy(Producto => Producto.nombre).ToList();

                dgvProducto.DataSource = listacat;
            }
            else
            {
                cargarDatos();
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el producto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvProducto.CurrentRow;
                    string idValue = selectedRow.Cells["id"].Value.ToString();
                    string nombre = selectedRow.Cells["nombre"].Value.ToString();
                    string stock = selectedRow.Cells["stock"].Value.ToString();
                    ProductoService productoService = new ProductoService();

                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormProductoEditar(FormPrincipal, Guid.Parse(idValue), nombre, stock));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea dar de baja el producto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvProducto.CurrentRow;
                        object idValue = selectedRow.Cells["id"].Value;

                        ProductoNegocio productoNegocio = new ProductoNegocio();
                        productoNegocio.bajaProducto(Guid.Parse(idValue.ToString()), UsuarioSesion.Id);
                    }
                    cargarDatos();

                }
                else
                {
                    MessageBox.Show("Seleccione una producto para dar de baja");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
