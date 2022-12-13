using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Crud_Web_App
{
    public class UserDal
    {
        private static SqlConnection conn = new SqlConnection(Dalc.sqlConnectionString);


        public static DataView GetData()
        {
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT  * FROM table_registr;", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            return ds.Tables[0].DefaultView;
        }


        public static void DeleteRow(string UserID)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM table_registr WHERE ID=@UserID", conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateRow(string UserID, string Username, string Password, string Email)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE table_registr SET Username=@Username, Password=@Password, Email=@Email WHERE ID=@UserID", conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}