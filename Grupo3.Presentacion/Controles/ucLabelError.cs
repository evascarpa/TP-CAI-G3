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
    public partial class ucLabelError : UserControl
    {
        public ucLabelError()
        {
            InitializeComponent();
        }

        public void label1_set(string a)
        {
            label1.Text = a;
        }
    }

}
