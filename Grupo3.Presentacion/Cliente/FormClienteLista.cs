using Grupo3.Negocio;
using Grupo3.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Grupo3.Presentacion
{
    public partial class FormClienteLista : Form
    {
        public FormPrincipal FormPrincipal;


        public FormClienteLista(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            cargarDatos();
        }


        private void cargarDatos()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            List<Cliente> lista = clienteNegocio.Listar();
            // Ordena la lista por nombre
            lista = lista.OrderBy(cliente => cliente.nombre).ToList();
            dgvLista.DataSource = lista;           
            dgvLista.Columns["id"].DisplayIndex = 0;
            dgvLista.Columns["nombre"].DisplayIndex = 1;
            dgvLista.Columns["apellido"].DisplayIndex = 2;            
            dgvLista.Columns["fechaBaja"].Visible = false;
            dgvLista.Columns["idUsuario"].Visible = false;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];
                string idCliente = row.Cells["id"].Value.ToString();
            }
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormAltaCliente(FormPrincipal));
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el cliente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvLista.CurrentRow;
                    string idValue = selectedRow.Cells["id"].Value.ToString();

                    ClienteService clienteService = new ClienteService();

                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormClienteEditar(FormPrincipal, Guid.Parse(idValue)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea dar de baja el cliente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvLista.CurrentRow;
                    object idValue = selectedRow.Cells["id"].Value;

                    ClienteService clienteService = new ClienteService();
                    clienteService.BorrarCliente(Guid.Parse(idValue.ToString()));
                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormClienteLista(FormPrincipal));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClienteLista_Load(object sender, EventArgs e)
        {

        }
    }

}
