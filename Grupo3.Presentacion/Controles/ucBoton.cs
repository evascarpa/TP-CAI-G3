using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Presentacion.Controles
{
    public class ucBoton : Button
    {
        private int borde = 5;

        //Constructor
        public ucBoton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            float curva = radio * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curva, curva, 180, 90);
            path.AddArc(rect.Right - curva, rect.Y, curva, curva, 270, 90);
            path.AddArc(rect.Right - curva, rect.Bottom - curva, curva, curva, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curva, curva, curva, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle superficie = this.ClientRectangle;
            int smoothSize = 2;

            using (GraphicsPath pathSurface = GetFigurePath(superficie, borde))
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }
    }
}
