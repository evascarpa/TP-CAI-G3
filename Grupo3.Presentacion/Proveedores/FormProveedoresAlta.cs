using Grupo3.Entidades;
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

namespace Grupo3.Presentacion.Proveedores
{
    public partial class FormProveedoresAlta : Form
    {
        private ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        Validador validador = new Validador();
        private FormPrincipal FormPrincipal;



        public FormProveedoresAlta(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
        }

      
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validador.textoVacio(txtNombre) || validador.textoVacio(txtApellido) || validador.textoVacio(txtEmail) || validador.textoVacio(txtCuit))
                {
                    errorGuardar.Show();
                    errorGuardar.label1_set("◆Todos los campos deben estar completos");
                }
                else
                {
                    errorGuardar.Hide();
                    string idUsuario = UsuarioSesion.Id.ToString();
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string email = txtEmail.Text;
                    string cuit = txtCuit.Text;
                    proveedorNegocio.agregarProveedor(idUsuario, nombre, apellido, email, cuit);
                    MessageBox.Show("Proveedor agregado exitosamente");
                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormProveedoresLista(FormPrincipal));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormProveedoresLista(FormPrincipal));
        }
    }
}
