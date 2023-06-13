using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{
    public class ClsServicio
    {
        SqlConnection cn = new SqlConnection();
        public DataTable ListarSer()
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_ListaSer", cn);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarSer(string xnom)
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_BuscarSer '" + xnom +"'", cn);
            da.Fill(tb);
            return tb;
        }

        public string IngSer (string xnom, decimal xtar)
        {
            cn.ConnectionString = ClsConexion.cnx;
            SqlCommand cmd = new SqlCommand("usp_IngSer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nomser", SqlDbType.VarChar, 25).Value = xnom;
            cmd.Parameters.Add("@tarser", SqlDbType.SmallMoney).Value = xtar;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return "Ok, se grabó satisfactoriamente";
            }
            catch (Exception ex)
            {
                cn.Close();
                return ex.Message;

            }
            
        }

        public string ModSer(int xid, string xnom, decimal xtar, string xes)
        {
            cn.ConnectionString = ClsConexion.cnx;
            SqlCommand cmd = new SqlCommand("usp_modSer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idser", SqlDbType.Int).Value = xid;
            cmd.Parameters.Add("@nomser", SqlDbType.VarChar, 25).Value = xnom;
            cmd.Parameters.Add("@tarser", SqlDbType.SmallMoney).Value = xtar;
            cmd.Parameters.Add("@estser", SqlDbType.Char,1).Value = xes;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return "Ok, se actualizó satisfactoriamente";
            }
            catch (Exception ex)
            {
                cn.Close();
                return ex.Message;

            }
        }

        public string EliSer(int xid)
        {
            cn.ConnectionString = ClsConexion.cnx;
            SqlCommand cmd = new SqlCommand("usp_eliSer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idser", SqlDbType.Int).Value = xid;
            
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return "Ok, se actualizó satisfactoriamente";
            }
            catch (Exception ex)
            {
                cn.Close();
                return ex.Message;

            }
        }

    }
}
