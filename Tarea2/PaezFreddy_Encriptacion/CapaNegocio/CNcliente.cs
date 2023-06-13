using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocio
{
    public class CNcliente
    {
        CapaData.ClsCliente obj = new CapaData.ClsCliente();
        public DataTable ListarCli()
        {
            return obj.ListarCli();
        }

        public DataTable BuscarCli(string xape)
        {
            return obj.BuscarCli(xape);
        }
        public DataTable BuscarCliId(int xid)
        {
            return obj.BuscarCliId(xid);
        }
        public string IngCli(string xnom, string xape, int xdis, decimal deuda)
        {
            return obj.IngCli(xnom, xape, xdis, deuda);
        }

        public string ModCli(int xid, string xnom, string xape,
                    int xdis, decimal deuda, string xes)
        {
            return obj.ModCli(xid, xnom, xape, xdis, deuda, xes);
        }

    }
}
