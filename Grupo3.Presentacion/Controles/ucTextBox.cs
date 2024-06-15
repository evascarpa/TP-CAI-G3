using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grupo3.Presentacion.Controles
{
    [DefaultEvent("_TextChanged")]
    public partial class ucTextBox : UserControl
    {
        private Colores colores = new Colores();
        private bool estaSeleccionado = false;
        public ucTextBox()
        {
            InitializeComponent();
            this.Font = colores.fuente;
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                this.Invalidate();
            }
        }

        public bool TieneError { get; set; } = false;
        public bool EsPassword { get; set; } = false;

        public event EventHandler _TextChanged;
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int altura = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, altura);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grafico = e.Graphics;
            using (Pen penBorde = new Pen(colores.bordeColor, colores.bordeTamano))
            {
                penBorde.Alignment = PenAlignment.Inset;
                if (estaSeleccionado)
                {
                    penBorde.Color = colores.bordeFocoColor;
                }
                if(TieneError)
                {
                    penBorde.Color = colores.colorError;
                }
                grafico.DrawRectangle(penBorde, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();

            if (EsPassword)
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            estaSeleccionado = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            estaSeleccionado = false;
            this.Invalidate();
        }
    }
}
