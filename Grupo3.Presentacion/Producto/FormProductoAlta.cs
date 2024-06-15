using Grupo3.Entidades;
using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;
using Grupo3.Presentacion.Ventas;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Grupo3.Presentacion
{
    public partial class FormProductoAlta : Form
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private FormPrincipal FormPrincipal;

        Validador validador = new Validador();

        public FormProductoAlta(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            List<Item> listap = proveedorNegocio.Listar()
                .Select(x => new Item(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            listap.Insert(0, new Item("", "Seleccione"));

            cmbProveedor.DisplayMember = "Valor";
            cmbProveedor.ValueMember = "Id";
            cmbProveedor.DataSource = listap;

            List<Item> listacat = new List<Item>();
            listacat.Add(new Item("0", "Seleccione"));
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

            FormPrincipal = formPrincipal;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            CategoriaArchivo archivo = new CategoriaArchivo();
            try
            {
                if (validador.textoVacio(txtNombre) || validador.mayorAm(txtPrecio) || validador.textoVacio(txtStock)
                    || cmbCategoria.SelectedIndex == 0 || !validador.seleccionoValor(cmbProveedor, errorProveedor))
                {
                    errorGuardar.Show();
                    errorGuardar.label1_set("◆Todos los campos deben estar completos");
                }
                else
                {
                    errorGuardar.Hide();
                    string idProveedor = cmbProveedor.SelectedValue.ToString();
                    string categoria = cmbCategoria.SelectedValue.ToString();
                    string idUsuario = UsuarioSesion.Id.ToString();
                    string nombre = txtNombre.Text;
                    int precio = Int32.Parse(txtPrecio.Text);
                    int stock = Int32.Parse(txtStock.Text);
                    productoNegocio.agregarProducto(Int32.Parse(categoria), idUsuario, idProveedor, nombre, precio, stock);
                    archivo.GuardarCategoria(idProveedor, categoria);
                    DialogResult result = MessageBox.Show("Producto agregado exitosamente. Desea agregar otro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        cmbProveedor.SelectedIndex = 0;
                        cmbCategoria.SelectedIndex = 0;
                        txtNombre.Text = String.Empty;
                        txtPrecio.Text = String.Empty;
                        txtStock.Text = String.Empty;
                    }
                    else
                    {
                        this.Hide();
                        FormPrincipal.AbrirFormulario(new FormProductoLista(FormPrincipal));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtNombre, validador.textoVacio, errorNombre, "◆El Nombre no puede estar vacio");
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtPrecio, errorPrecio, "◆Solo Numeros");
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (validador.mayorAm(txtPrecio))
            {
                errorPrecio.Show();
                errorPrecio.label1_set("◆El precio debe ser mayor a 0");
            }
            else
            {
                errorPrecio.Hide();
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtStock, errorStock, "◆Solo Numeros");
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtStock, validador.textoVacio, errorStock, "◆El Stock no puede estar vacio");
        }

        private void cmbProveedor_Leave(object sender, EventArgs e)
        {
            validador.seleccionoValor(cmbProveedor, errorProveedor);
        }

        private void cmbCategoria_Leave(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == 0)
            {
                errorCategoria.Show();
                errorCategoria.label1_set("◆Debe seleccionar un valor");
            }
            else
            {
                errorCategoria.Hide();
            }
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormProductoLista(FormPrincipal));
        }
    }
}
