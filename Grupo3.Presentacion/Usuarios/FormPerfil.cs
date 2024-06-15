using Grupo3.Negocio;
using Grupo3.Presentacion.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion.Usuarios
{
    public partial class FormPerfil : Form
    {
        Validador validador = new Validador();
        private FormPrincipal FormPrincipal;
        public FormPerfil(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            lblNombreUsuario.TitleText = UsuarioSesion.Nombre;
            FormPrincipal = formPrincipal;
        }

        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRepetir.Text)
            {
                errorGeneral.Visible = true;
                errorGeneral.label1_set("◆Las contraseñas deben coincidir");
            }
            else
            {
                if (validar())
                {
                    errorGeneral.Visible = false;
                    try
                    {
                        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                        usuarioNegocio.CambiarPassword(UsuarioSesion.Nombre, txtActual.Text, txtRepetir.Text);

                        MessageBox.Show("◆La contraseña se modifico correctamente");

                        FormPrincipal.Hide();
                        FormPrincipal formPrincipal = new FormPrincipal();
                        formPrincipal.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    errorGeneral.label1_set("◆Complete las validaciones");
                    errorGeneral.Visible = true;
                }
            }
        }

        private bool validar()
        {
            bool resultado = true;

            resultado = validador.textoVacio(txtRepetir, errorRepetir) && resultado;
            resultado = validador.textoVacio(txtActual, errorActual) && resultado;
            resultado = validador.textoVacio(txtPassword, errorPassword) && resultado;

            return resultado;
        }

        private void txtActual_Leave(object sender, EventArgs e)
        {
            validador.textoVacio(txtActual, errorActual);
        }

        private void txtRepetir_Leave(object sender, EventArgs e)
        {
            validador.textoVacio(txtRepetir, errorRepetir);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            validador.textoVacio(txtPassword, errorPassword);
        }
    }
}
