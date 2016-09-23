using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for sqlPublic
/// </summary>
public class sqlPublic
{
    static string _ConnectString = "Data Source=GIAMSAT2;Initial Catalog=FamilyStore;User ID=sa; Password=runtoyou";
    public static string ConnectionString
    {
        set
        {
            _ConnectString = value;
        }
        get
        {
            return _ConnectString;
        }
    }
    static SqlConnection GetConnection()
    {
        SqlConnection con = new SqlConnection(_ConnectString);
        con.Open();
        return con;
    }
    public static void ExecuteNoneQuery(SqlCommand cmd)
    {
        if(cmd.Connection != null)
        {
            cmd.ExecuteNonQuery();
        }
        else
        {
            using (SqlConnection con = GetConnection())
            {
                cmd.Connection = GetConnection();
                cmd.ExecuteNonQuery();
            }
            
        }
    }

    public static DataTable GetData(SqlCommand cmd)
    {
        if(cmd.Connection != null)
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }
        else
        {
            using (SqlConnection con = GetConnection())
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }
    }


}