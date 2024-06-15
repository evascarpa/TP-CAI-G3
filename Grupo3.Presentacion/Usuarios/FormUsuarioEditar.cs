//using Datos;
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
    public partial class FormUsuarioEditar : Form
    {
        private FormPrincipal  FormPrincipal;
     
        public FormUsuarioEditar()
        {
            InitializeComponent();
            BuscarDatosUsuario();
        }


        private void BuscarDatosUsuario()
        {
            Usuario usuario = new Usuario("nombre", "apellido", "email", DateTime.Now, DateTime.Now, "direccion", "telefono", 12345678, DateTime.Now, "usuairo", "12345", 1);

            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtDireccion.Text = usuario.direccion;
            txtTelefono.Text = usuario.telefono;
            txtEmail.Text = usuario.email;
            txtDni.Text = usuario.dni.ToString();
            txtUsuario.Text = usuario.nombreUsuario;
            datFechaNacimiento.Value = usuario.fechaNacimiento;
            txtContraseña.Text = usuario.contraseña;

            chbActivo.Checked = !usuario.fechaBaja.HasValue;

        }


        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
           

        }

       
    }
}
