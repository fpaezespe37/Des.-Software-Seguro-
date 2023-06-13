using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{
    public class ClsCliente
    {
        SqlConnection cn = new SqlConnection();
        public DataTable ListarCli()
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_ListarCli", cn);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarCli(string xape)
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_BuscarCli '" + xape + "'", cn);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarCliId(int xid)
        {
            cn.ConnectionString = ClsConexion.cnx;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_BuscarCliId '" + xid + "'", cn);
            da.Fill(tb);
            return tb;
        }

        public string IngCli(string xnom, string xape, int xdis, decimal deuda)
        {
            cn.ConnectionString = ClsConexion.cnx;
            SqlCommand cmd = new SqlCommand("usp_ingCli", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nomcli", SqlDbType.VarChar, 20).Value = xnom;
            cmd.Parameters.Add("@apecli", SqlDbType.VarChar, 20).Value = xape;
            cmd.Parameters.Add("@iddis", SqlDbType.Int).Value = xdis;
            cmd.Parameters.Add("@deuda", SqlDbType.SmallMoney).Value = deuda;

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

        public string ModCli(int xid, string xnom, string xape, 
                    int xdis, decimal deuda, string xes)
        {
            cn.ConnectionString = ClsConexion.cnx;
            SqlCommand cmd = new SqlCommand("usp_modCli", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idcli", SqlDbType.Int).Value = xid;
            cmd.Parameters.Add("@nomcli", SqlDbType.VarChar, 20).Value = xnom;
            cmd.Parameters.Add("@apecli", SqlDbType.VarChar, 20).Value = xape;
            cmd.Parameters.Add("@iddis", SqlDbType.Int).Value = xdis;
            cmd.Parameters.Add("@deuda", SqlDbType.SmallMoney).Value = deuda;
            cmd.Parameters.Add("@estcli", SqlDbType.Char, 1).Value = xes;

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
