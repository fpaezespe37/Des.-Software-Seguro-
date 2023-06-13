using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocio
{
    public class CNgeneral
    {
        CapaData.ClsGeneral obj = new CapaData.ClsGeneral();
        public DataTable ListarDis()
        {
            return obj.ListarDis();
        }
    }
}
