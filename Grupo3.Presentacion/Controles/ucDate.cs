using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.PropertyGridInternal;

namespace Grupo3.Presentacion.Controles
{
    public partial class ucDate : DateTimePicker
    {
        private Colores colores = new Colores();

        private bool estaDesplegado = false;
        private Image icono = Resources.calendarDark;
        private RectangleF botonIcono;
        private const int iconoAncho = 24;

        //Constructor
        public ucDate()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Format = DateTimePickerFormat.Short;

            this.Size = new Size(250, 33);
            this.Font = new Font(this.Font.Name, 9.5F);
        }

        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            estaDesplegado = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            estaDesplegado = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(colores.bordeColor, colores.bordeTamano))
            using (SolidBrush skinBrush = new SolidBrush(colores.colorFondo))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(colores.colorTexto))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - iconoAncho, 0, iconoAncho, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                if (estaDesplegado == true)
                {
                    graphics.FillRectangle(openIconBrush, iconArea);
                }

                graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                graphics.DrawImage(icono, this.Width - icono.Width - 9, (this.Height - icono.Height) / 2);

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            botonIcono = new RectangleF(this.Width - iconoAncho, 0, iconoAncho, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (botonIcono.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }
    }
}
