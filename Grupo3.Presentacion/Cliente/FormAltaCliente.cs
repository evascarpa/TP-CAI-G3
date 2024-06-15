using Grupo3.Entidades.Cliente;
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
    public partial class FormAltaCliente : Form
    {
        Validador validador = new Validador();


        private FormPrincipal FormPrincipal;
        public FormAltaCliente(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
        }


        private bool Validar()
        {
            bool esValido = true;

            esValido = validador.textoVacio(txtNombre, errorNombre) && esValido;
            esValido = validador.textoVacio(txtApellido, errorApellido) && esValido;
            esValido = validador.textoVacio(txtDireccion, errorDireccion) && esValido;
            esValido = validador.longitudCampo(txtTelefono, 8, 12) && esValido;
            esValido = validador.longitudCampo(txtDni, 8, 8) && esValido;
            esValido = validador.validarEmail(txtEmail) && esValido;
            esValido = validador.fechaLimite(datFechaNacimiento) && esValido;

            return esValido;
        }

        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    errorGuardar.Show();
                    errorGuardar.label1_set("◆Todos los campos deben estar completos");
                }

                else
                {
                    string Host = "Grupo 3";
                    errorGuardar.Hide();
                    ClientePost cliente = new ClientePost(UsuarioSesion.Id, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtDireccion.Text, txtTelefono.Text, txtEmail.Text, datFechaNacimiento.Value, Host);
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteNegocio.agregar(cliente);
                    MessageBox.Show("Cliente agregado exitosamente");
                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormClienteLista(FormPrincipal));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloLetras, txtNombre, errorNombre, "◆Solo Letras");
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloLetras, txtNombre, errorNombre, "◆Solo Letras");
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumerosTel, txtTelefono, errorTelefono, "◆Solo Numeros o -");
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveLongitud(txtDni, 8, 8, validador.longitudCampo, errorDNI, "◆El DNI debe contener 8 caracteres");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtDni, errorDNI, "◆Solo Numeros");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtEmail, validador.validarEmail, errorEmail, "◆El Email debe ser valido");
        }

        private void datFechaNacimiento_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveFecha(datFechaNacimiento, validador.fechaLimite, errorNacimiento, "◆La fecha debe ser superior a 1955 e inferior a 2006");
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveLongitud(txtTelefono, 8, 12, validador.longitudCampo, errorTelefono, "◆El teléfono debe contener hasta 12 caracteres");
        }



        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormClienteLista(FormPrincipal));
        }

     
    }
}
