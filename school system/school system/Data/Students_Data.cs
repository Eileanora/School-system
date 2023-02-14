using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system.Data
{
    internal class Students_Data
    {
        public DataTable dt = new DataTable();
        public void select(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = s;

            cls_serverconnection.cn.Open();
            dt.Load(cmd.ExecuteReader());
            cls_serverconnection.cn.Close();
        }

        public void select_ViewStudents(string s, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = s;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cls_serverconnection.cn.Open();
            dt.Load(cmd.ExecuteReader());
            cls_serverconnection.cn.Close();
        }

        public void insert_students(string name, string ph, int g_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_student";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar, 11).Value = ph;
            cmd.Parameters.Add("@g_id", SqlDbType.Int).Value = g_id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();  
        }

        public void delete_students(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_student";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();  
        }


        public void update_students(string name, string ph, int id, int g_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_student";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar, 11).Value = ph;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@g_id", SqlDbType.Int).Value = g_id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();  
        }
    }
}
