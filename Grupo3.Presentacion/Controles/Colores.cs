using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3.Presentacion.Controles
{
    public class Colores
    {
        public readonly Color bordeColor = Color.FromArgb(222, 226, 230);
        public readonly Color bordeFocoColor = Color.FromArgb(10, 88, 202);
        public readonly Color colorFondo = Color.White;
        public readonly Color colorTexto = Color.Black;
        public readonly Color colorIcono = Color.MediumSlateBlue;
        public readonly Color colorListaFondo = Color.FromArgb(230, 228, 245);
        public readonly Color colorListaTexto = Color.DimGray;
        public readonly Color colorError = Color.FromArgb(170, 75, 74);
        public readonly int bordeTamano = 2;
        public readonly Font fuente = new Font("Arial", 12, FontStyle.Bold);
    }
}
