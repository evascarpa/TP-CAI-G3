using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Grupo3.Presentacion
{
    public partial class FormLogin : Form
    {
        Validador validador = new Validador();
        public FormLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;

        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlContenedor.Region = region;
            this.Invalidate();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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


        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            ArchivoLog archivo = new ArchivoLog();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            if (validador.textoVacio(txtUsuario) || validador.textoVacio(txtPassword))
            {
                errorLogin.Show();
                errorLogin.label1_set("◆Por favor ingrese sus credenciales");
            }
            else
            {
                errorLogin.Hide();
                try
                {
                    bool tieneReintentos = archivo.TieneReintentos(txtUsuario.Text);

                    if (!tieneReintentos)
                    {
                        MessageBox.Show("El usuario supero los reintentos. Ha sido bloqueado");
                        return;
                    }

                    Guid idUsuario = usuarioNegocio.LogIn(txtUsuario.Text, txtPassword.Text);

                    UsuarioSesion.Id = idUsuario;
                    UsuarioSesion.Nombre = txtUsuario.Text;
                    archivo.ActualizarLogin(txtUsuario.Text);
                    this.Hide();
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show(); 
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Cuenta inactiva")
                    {
                        string contraseña = txtPassword.Text;
                        string nombre = txtUsuario.Text;
                        this.Hide();
                        FormReactivar formReactivar = new FormReactivar(contraseña, nombre);
                        formReactivar.Show();
                    }
                    else
                    {
                        bool usuarioHabilitado = archivo.GuardarLoginFallido(txtUsuario.Text);

                        if (!usuarioHabilitado)
                        {
                            MessageBox.Show("El usuario supero los reintentos. Ha sido bloqueado");
                            return;
                        }

                        MessageBox.Show(ex.Message);
                    }                   
                }
            }
        }

        private void ucTitulo1_Load(object sender, EventArgs e)
        {

        }
    }
}
