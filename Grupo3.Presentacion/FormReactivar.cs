using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class FormReactivar : Form
    {
        Validador validador = new Validador();
        private FormPrincipal FormPrincipal;
        private string Contraseña;
        private string Nombre;
        public FormReactivar(string contraseña, string nombre)
        {
            InitializeComponent();
            Contraseña = contraseña;
            Nombre = nombre;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtContraseña, validador.contieneMayusculaoNumero, errorContraseña, "◆Debe contener al menos una mayuscula y un numero");
            validador.validadorLeaveLongitud(txtContraseña, 8, 15, validador.longitudCampo, errorContraseña2, "◆Debe contener entre 8 y 15 caracteres");
        }
        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text != txtContraseña.Text)
            {
                errorConfirmar.Show();
                errorConfirmar.label1_set("◆Las contraseñas deben coincidir");
            }
            else
            {
                errorConfirmar.Hide();
            }
        }

        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            InactivosArchivoLog archivo = new InactivosArchivoLog();
            if (validador.contieneMayusculaoNumero(txtContraseña) || validador.longitudCampo(txtContraseña, 8, 15))
            {
                errorActivar.Show();
                errorActivar.label1_set("◆Ingrese una contraseña valida");
            }
            else
            {
                errorActivar.Hide();                
                Guid idUsuario = new Guid ("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
                string nuevaContraseña = txtContraseña.Text;
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                string id = archivo.ObtenerId(Nombre, Contraseña);
                usuarioNegocio.ActivarUsuario(Guid.Parse(id), idUsuario);
                usuarioNegocio.CambiarPassword(Nombre, Contraseña, nuevaContraseña);
                MessageBox.Show("Contraseña Actualizada");                
                UsuarioSesion.Id = Guid.Parse(id);
                UsuarioSesion.Nombre = Nombre;
                this.Hide();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
