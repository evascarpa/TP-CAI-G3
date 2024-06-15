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
    public partial class FormProductoEditar : Form
    {
        private FormPrincipal FormPrincipal;
        private Guid IdProducto;
        private string Nombre;
        private string Stock;
        Validador validador = new Validador();


        public FormProductoEditar(FormPrincipal formPrincipal, Guid idproducto, string nombre, string stock)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            IdProducto = idproducto;
            Nombre = nombre;
            Stock = stock;
            txtId.TitleText = idproducto.ToString();
            txtNombre.TitleText = nombre.ToString();

        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                int resta = Int32.Parse(Stock) - Math.Abs(Int32.Parse(txtCantidad.Text));
                if (validador.mayorAm(txtPrecio) || !Int32.TryParse(txtCantidad.Text, out n)
                    || (Int32.Parse(txtCantidad.Text) < 0 && resta < 0))
                {
                    errorEditar.Show();
                    errorEditar.label1_set("◆Hay campos incorrectos");

                }

                else
                {
                    ProductoNegocio productoNegocio = new ProductoNegocio();
                    productoNegocio.modificarProducto(IdProducto, UsuarioSesion.Id, Int32.Parse(txtPrecio.Text), Int32.Parse(txtCantidad.Text));
                    MessageBox.Show("Producto modificado exitosamente");
                    this.Hide();
                    FormPrincipal.AbrirFormulario(new FormProductoLista(FormPrincipal));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtPrecio, errorPrecio, "◆Solo Numeros");
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtPrecio, validador.mayorAm, errorPrecio, "◆Solo Numeros");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumerosTel, txtCantidad, errorStock, "◆Solo Numeros o -");
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            int n = 0;
            int resta = Int32.Parse(Stock) - Math.Abs(Int32.Parse(txtCantidad.Text));
            if (!Int32.TryParse(txtCantidad.Text, out n))
            {
                errorStock.Show();
                errorStock.label1_set("◆Ingrese un numero positivo o negativo");
            }
            else if (Int32.Parse(txtCantidad.Text) < 0 && resta < 0)
            {
                errorStock.Show();
                errorStock.label1_set("◆El stock no puede ser menor a cero");
            }
            else
            {
                errorStock.Hide();
            }
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormProductoLista(FormPrincipal));
        }
    }
}

