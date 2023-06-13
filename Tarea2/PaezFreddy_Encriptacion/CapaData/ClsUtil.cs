using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaData
{
    public class ClsUtil
    {
        SqlConnection cn = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable backup(string xbd, string xeti, byte tipo)
        {            
            cn.ConnectionString = ClsConexion.cnx;
            SqlDataAdapter da = new SqlDataAdapter("usp_backup '" + xbd + "','" + xeti + "',"+tipo, cn);
            da.Fill(dt);
            return dt;
        }
        public DataTable ListarBD()
        {            
            cn.ConnectionString = ClsConexion.cnx;
            SqlDataAdapter da = new SqlDataAdapter("select dbid, name, crdate from master.dbo.sysdatabases where dbid>=7;", cn);
            da.Fill(dt);
            return dt;
        }
        public string restaura (string @bd, string @copia)
        {
            cn.ConnectionString = ClsConexion.cnx;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("usp_restore '" + @bd + "','" + @copia + "'", cn);
                return "Restauración satisfactoria, ...";
            } catch(Exception ex)
            {
                return "Restauración fallida, ....";
            }
            

        }
    }
}
