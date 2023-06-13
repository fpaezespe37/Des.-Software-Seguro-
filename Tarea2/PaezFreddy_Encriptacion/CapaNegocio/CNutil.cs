using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class CNutil
    {
        CapaData.ClsUtil obj = new CapaData.ClsUtil();
        public DataTable ListarBD()
        {
            
            return obj.ListarBD();
        }
        public DataTable backup(string xbd, string xeti, byte tipo)
        {
            return obj.backup( xbd,  xeti, tipo);
        }
        public string restaura(string @bd, string @copia)
        {
            return obj.restaura(@bd, @copia);
        }
    }
}
