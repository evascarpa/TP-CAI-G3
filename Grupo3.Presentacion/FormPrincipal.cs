using Grupo3.Negocio;
using Grupo3.Presentacion.Proveedores;
using Grupo3.Presentacion.Reportes;
using Grupo3.Presentacion.Usuarios;
using Grupo3.Presentacion.Ventas;
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
    public partial class FormPrincipal : Form
    {
        ProductoNegocio ProductoNegocio = new ProductoNegocio();
        UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        public FormPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            ucTitulo1.TitleText += " " + UsuarioSesion.Nombre;
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;

            var idUsuarioLog = UsuarioSesion.Id;
            List<Usuario> listaUsuarios = UsuarioNegocio.Listar();
            Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.id == idUsuarioLog);
            var producto = ProductoNegocio.Listar().Where(x => x.stockBajo); //trae los prod que queda solo 1 unidad
            if (producto.Count() > 0 && usuarioEncontrado.host > 1)
            {
                ucAvisoStock.TitleText = $"Hay {producto.Count()} productos con stock bajo";
                ucAvisoStock.Visible = true;
                pictureBoxAlerta.Visible = true;
            }//supervisores y administradores

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
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormLogin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarioLista(this));
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


        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClienteLista(this));
        }


        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirFormulario(Form formulario)
        {
            if (this.pnlFormulario.Controls.Count > 0)
            {
                this.pnlFormulario.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(formulario);
            pnlFormulario.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVentaLista(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProductoLista(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProveedoresLista(this));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UsuarioSesion.Limpiar();
            this.Hide();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPerfil(this));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSelectorReportes(this));
        }
    }
}
