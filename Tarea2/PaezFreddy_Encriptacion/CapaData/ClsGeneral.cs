using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
     
namespace CapaData
{
    public class ClsGeneral
    {
        SqlConnection cn = new SqlConnection();
        public DataTable ListarDis()
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id_dis, nom_dis from distrito", cn);
            da.Fill(tb);
            return tb;
        }
    }
}
