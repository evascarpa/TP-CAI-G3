using Grupo3.Entidades;
using Grupo3.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion
{
    public partial class FormClienteEditar : Form
    {
        private FormPrincipal FormPrincipal;
        private Guid IdCliente;
        Validador validador = new Validador();


        public FormClienteEditar(FormPrincipal formPrincipal, Guid idCliente)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            IdCliente = idCliente;
        }

        private void FormClienteEditar_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            var cliente = clienteNegocio.buscarUnCliente(IdCliente);

            //txtIdCliente.Text = cliente.id.ToString();    //>>esto no se tiene que poder editar
            txtDireccion.Text = cliente.direccion.ToString();
            txtEmail.Text = cliente.email.ToString();
            txtTelefono.Text = cliente.telefono.ToString();
        }

        private void txtIdCliente__TextChanged(object sender, EventArgs e)
        {

        }

        private void ucTexto4_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (validador.textoVacio(txtDireccion) || validador.validarEmail(txtEmail) || validador.textoVacio(txtTelefono))
                {
                    errorEditar.Show();
                    errorEditar.label1_set("◆Hay campos incorrectos");

                }

                else
                {
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteNegocio.modificarCliente(IdCliente, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                    MessageBox.Show("Cliente modificado exitosamente");
                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormClienteLista(FormPrincipal));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtEmail, validador.validarEmail, errorEmail, "◆El Email debe ser valido");
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumerosTel, txtTelefono, errorTelefono, "◆Solo Numeros o -");
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveLongitud(txtTelefono, 8, 12, validador.longitudCampo, errorTelefono, "◆Debe contener entre 8 y 12 caracteres");
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtDireccion, validador.textoVacio, errorDireccion, "◆La Direccion no puede estar vacia");
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormClienteLista(FormPrincipal));
        }
    }
}
