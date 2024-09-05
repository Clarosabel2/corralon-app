using BDE;
using DAL;
using System.Data;
using System.Data.SqlClient;

internal static class DAL_ClienteHelpers
{
    public static BE_Cliente VerificarCliente(string dni)
    {
        var cnn = new DAL_Conexion();
        var cmd = new SqlCommand();
        cmd.Connection = cnn.OpenConnection();
        cmd.CommandText = "sp_GetClientByDNI";
        cmd.Parameters.AddWithValue("@p_dni_client", dni);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            return new BE_Cliente(dr);
        }
        return null;
    }
}