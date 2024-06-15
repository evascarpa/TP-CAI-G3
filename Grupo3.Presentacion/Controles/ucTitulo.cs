using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3.Presentacion.Controles
{
    public partial class ucTitulo : UserControl
    {
        public ucTitulo()
        {
            InitializeComponent();
        }
        public string TitleText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
