using Grupo3.Entidades;
using Grupo3.Entidades.Venta;
using Grupo3.Negocio;
using Grupo3.Persistencia;
using Grupo3.Presentacion.Logs;
using System.Data;
using System.Windows.Forms;

namespace Grupo3.Presentacion.Ventas
{
    public partial class FormVentaLista : Form
    {
        private FormPrincipal FormPrincipal;
        private List<Comprobante> Comprobantes;

        public FormVentaLista(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            ComprobanteLog comprobanteLog = new ComprobanteLog();

            Comprobantes = comprobanteLog.RecuperarRegistros();

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            List<Item> items = clienteNegocio.Listar()
                .Select(x => new Item(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new Item("", "Seleccione"));

            cmbCliente.DisplayMember = "Valor";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = items;
            FormPrincipal = formPrincipal;

            btnBaja.Enabled = false;

            OcultarFilasVacias(dgvVentas);
            OcultarColumnasVacias(dgvVentas);

        }

        private void DescargarArchivo(string path)
        {
            // Implementa la lógica para descargar el archivo del path
            // Esto puede variar dependiendo de dónde se almacenan los archivos y cómo se deben descargar
            // Aquí tienes un ejemplo simple de cómo abrir el archivo en la ubicación del path

            if (System.IO.File.Exists(path))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("El archivo no se encontró.");
            }
        }


        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVentas.Columns["Descargar"].Index && e.RowIndex >= 0)
            {
                // Obtener el Id del comprobante seleccionado
                int id = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["Id"].Value);

                // Obtener el comprobante de la lista original usando el Id
                var comprobante = Comprobantes.FirstOrDefault(c => c.Id == id);
                if (comprobante != null)
                {
                    string path = comprobante.Path;
                    // Lógica para descargar el archivo en 'path'
                    DescargarArchivo(path);
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormVentaAlta(FormPrincipal));
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
                        //ventaNegocio.Baja(Guid.Parse(idValue.ToString()), UsuarioSesion.Id);
                        ComprobanteLog comprobante = new ComprobanteLog();
                        comprobante.Eliminar((int)idValue);
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
        private void OcultarFilasVacias(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool filaVacia = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        filaVacia = false;
                        break;
                    }
                }
                row.Visible = !filaVacia;
            }
        }
        private void OcultarColumnasVacias(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                bool columnaVacia = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null &&
                        !string.IsNullOrWhiteSpace(row.Cells[column.Index].Value.ToString()))
                    {
                        columnaVacia = false;
                        break;
                    }
                }
                column.Visible = !columnaVacia;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var seleccion = cmbCliente.SelectedValue.ToString();
            if (!String.IsNullOrEmpty(seleccion))
            {
                var lista = Comprobantes.Where(x => x.IdCliente == Guid.Parse(seleccion));
                dgvVentas.DataSource = lista.Select(c => new
                {
                    c.Id,
                    c.Cliente,
                    c.FechaAlta
                }).OrderBy(x => x.Id).ToList();

                if (dgvVentas.Columns["Descargar"] == null)
                {
                    DataGridViewButtonColumn btnColumnaDescarga = new DataGridViewButtonColumn();
                    btnColumnaDescarga.Name = "Descargar";
                    btnColumnaDescarga.Text = "Descargar";
                    btnColumnaDescarga.UseColumnTextForButtonValue = true;
                    dgvVentas.Columns.Add(btnColumnaDescarga);
                    dgvVentas.CellClick += new DataGridViewCellEventHandler(dgvVentas_CellClick);
                }
                btnBaja.Enabled = lista.Any();
            }
            else
            {
                MessageBox.Show("Seleccione un valor válido");
            }
        }

        private void cmbCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
