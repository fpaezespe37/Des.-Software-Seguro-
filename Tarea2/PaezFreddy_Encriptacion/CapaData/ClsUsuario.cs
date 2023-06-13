using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{    
    public class ClsUsuario
    {
        SqlConnection cn = new SqlConnection();
        public DataTable buscarUsu (string xnom, string xcon)
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_buscarUsu '" + xnom + "','" + xcon+"'", cn);
            //da.Fill(dt);
            return dt;
        }
        public DataTable listarUsu()
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_listarUsu", cn);
            da.Fill(dt);
            return dt;
        }
    }

}
