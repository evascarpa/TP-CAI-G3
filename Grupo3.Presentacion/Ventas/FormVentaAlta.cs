using Grupo3.Entidades;
using Grupo3.Entidades.Venta;
using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;
using System.Data;
using System.Diagnostics;

namespace Grupo3.Presentacion.Ventas
{
    public partial class FormVentaAlta : Form
    {
        private List<Producto> productos = new List<Producto>();
        private List<VentaLista> ventaLista = new List<VentaLista>();
        private List<Cliente> clientes = new List<Cliente>();

        private Validador validador = new Validador();
        private FormPrincipal FormPrincipal;

        public FormVentaAlta(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clientes = clienteNegocio.Listar();

            List<Item> items = clientes
                .Select(x => new Item(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new Item("", "Seleccione"));

            cmbCliente.DisplayMember = "Valor";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = items;

            ProductoNegocio productoNegocio = new ProductoNegocio();

            productos = productoNegocio.Listar();

            items = productos
                .Select(x => new Item(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new Item("", "Seleccione"));

            cmbProducto.DisplayMember = "Valor";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = items;

            FormPrincipal = formPrincipal;
        }



        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Producto productoSeleccionado = cmbProducto.SelectedItem as Producto;
                    if (productoSeleccionado != null)
                    {
                        Guid idProducto = productoSeleccionado.id;

                        if (!ValidarStock(Convert.ToInt32(txtCantidad.Text), idProducto))
                        {
                            MessageBox.Show("No hay stock para el producto");
                            return;
                        }
                    }

                    try
                    {
                        VentaNegocio ventaNegocio = new VentaNegocio();
                        ventaNegocio.Crear(Guid.Parse(cmbCliente.SelectedValue.ToString()), Guid.Parse(cmbProducto.SelectedValue.ToString()), UsuarioSesion.Id, Convert.ToInt32(txtCantidad.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    errorGeneral.Visible = false;
                    ventaLista.Add(new VentaLista(
                        new Item(cmbProducto.SelectedValue.ToString(),
                        cmbProducto.SelectedItem.ToString()),
                        Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecioUnitario.Text),
                        Convert.ToInt32(txtPrecioTotal.Text),
                        productos.First(x => x.id == Guid.Parse(cmbProducto.SelectedValue.ToString())).idCategoria));

                    dgvVentas.DataSource = null;

                    dgvVentas.DataSource = ventaLista;
                }
                else
                {
                    errorGeneral.Visible = true;
                    errorGeneral.label1_set("◆Corregir campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarStock(int stock, Guid idProducto)
        {
            return productos.FirstOrDefault(x => x.id == idProducto).stock < stock;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea dar de baja la venta?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvVentas.CurrentRow;
                        object idValue = selectedRow.Cells["id"].Value;

                        VentaNegocio ventaNegocio = new VentaNegocio();
                        ventaNegocio.Baja(Guid.Parse(idValue.ToString()), UsuarioSesion.Id);
                        this.Hide();
                        FormPrincipal.AbrirFormulario(new FormVentaLista(FormPrincipal));
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una venta para dar de baja");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Validar()
        {
            bool esValido = true;

            esValido = validador.textoVacio(txtCantidad, errorCantidad) && esValido;
            esValido = validador.seleccionoValor(cmbCliente, errorCliente) && esValido;
            esValido = validador.seleccionoValor(cmbProducto, errorProducto) && esValido;
            esValido = validador.mayorAm(txtCantidad, errorCantidad, 0) && esValido;

            return esValido;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtCantidad, errorCantidad, "◆Solo Numeros");
            CalcularPrecio();
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            validador.textoVacio(txtCantidad, errorCantidad);
            validador.mayorAm(txtCantidad, errorCantidad, 0);
            CalcularPrecio();
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormVentaLista(FormPrincipal));
        }

        private void cmbProducto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        private void CalcularPrecio()
        {
            if (!String.IsNullOrEmpty(cmbProducto.SelectedValue.ToString()) && !String.IsNullOrEmpty(txtCantidad.Text))
            {
                Guid idProducto = Guid.Parse(cmbProducto.SelectedValue.ToString());

                var precio = productos.FirstOrDefault(x => x.id == idProducto).precio;

                txtPrecioUnitario.Text = precio.ToString();

                txtPrecioTotal.Text = (precio * Convert.ToInt32(txtCantidad.Text)).ToString();
            }
            else
            {
                txtPrecioUnitario.Text = String.Empty;
            }
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            var cliente = clientes.First(x => x.id.ToString() == cmbCliente.SelectedValue.ToString());

            ComprobanteLog comprobanteLog = new ComprobanteLog();
            var id = comprobanteLog.UltimoId();
            var path = ventaNegocio.GenerarPDF(id, cliente, ventaLista, ventaNegocio.calcularDescuento(ventaLista));
            comprobanteLog.Agregar(id, cliente, path);

            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("El archivo PDF no se pudo generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCliente_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            bool clienteNoSeleccionado = String.IsNullOrEmpty(cmbCliente.SelectedValue.ToString());
            cmbCliente.Visible = clienteNoSeleccionado;
            lblCliente.Visible = !clienteNoSeleccionado;

            lblCliente.TitleText = cmbCliente.SelectedItem.ToString();

            pnlVenta.Visible = !clienteNoSeleccionado;

        }


    }
}