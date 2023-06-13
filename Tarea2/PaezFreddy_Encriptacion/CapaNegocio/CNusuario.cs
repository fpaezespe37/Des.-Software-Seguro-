using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocio
{
    public class CNusuario
    {
        CapaData.ClsUsuario obj = new CapaData.ClsUsuario();
        public DataTable buscarUsu(string xnom, string xcon)
        {
            return obj.buscarUsu(xnom, xcon);
        }
        public DataTable listarUsu()
        {
            return obj.listarUsu();
        }
    }
}
