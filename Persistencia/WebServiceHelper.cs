using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class WebServiceHelper
    {
        string url;


        //me obliga a cerar construc vacio , sino en clienteNegocio y en UsuarioNegocio no me acepta el new WebServiceHelper
        public WebServiceHelper()
        {
        }

        public WebServiceHelper(string url)
        {
            this.url = url;
        }

       
    }
}
