using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class CNservicio
    {
        CapaData.ClsServicio obj = new CapaData.ClsServicio();
        public DataTable ListarSer()
        {
            return obj.ListarSer();
        }
        public DataTable BuscarSer(string xnom)
        {
            return obj.BuscarSer(xnom);
        }
        public string IngSer(string xnom, decimal xtar)
        {
            return obj.IngSer(xnom, xtar);
        }
        public string ModSer(int xid, string xnom, decimal xtar, string xes)
        {
            return obj.ModSer(xid, xnom, xtar, xes);
        }
        public string EliSer(int xid)
        {
            return obj.EliSer(xid);
        }
    }
}
