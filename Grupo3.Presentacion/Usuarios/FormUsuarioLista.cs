using Grupo3.Negocio;
using System;
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
    public partial class FormUsuarioLista : Form
    {
        public FormPrincipal FormPrincipal;
        public FormUsuarioLista(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            cargarDatos();
            FormPrincipal = formPrincipal;
        }

        private void cargarDatos()
        {

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            List<Usuario> lista = usuarioNegocio.Listar();
            lista = lista.OrderBy(Usuario => Usuario.nombre).ToList();

            dgvUsuario.DataSource = lista;
            dgvUsuario.Columns["id"].DisplayIndex = 0;
            dgvUsuario.Columns["nombre"].DisplayIndex = 1;
            dgvUsuario.Columns["apellido"].DisplayIndex = 2;
            dgvUsuario.Columns["direccion"].Visible = false;
            dgvUsuario.Columns["telefono"].Visible = false;
            dgvUsuario.Columns["email"].Visible = false;
            dgvUsuario.Columns["fechaAlta"].Visible = false;
            dgvUsuario.Columns["fechaNacimiento"].Visible = false;
            dgvUsuario.Columns["fechaBaja"].Visible = false;
            dgvUsuario.Columns["contraseña"].Visible = false;
        }


        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormUsuarioAlta(FormPrincipal));
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea borrar el usuario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvUsuario.CurrentRow;
                        object idValue = selectedRow.Cells["id"].Value;
                        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                        usuarioNegocio.eliminarUsuario(Guid.Parse(idValue.ToString()), UsuarioSesion.Id);
                    }
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para borrarlo");
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

    }
}

