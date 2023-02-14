using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace school_system
{
    internal class cls_data
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

        public void insert_grade(string grade)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_grade";
            cmd.Parameters.Add("@grade", SqlDbType.VarChar, 10).Value = grade;


            cls_serverconnection.cn.Open();
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();
        }

        public void delete_grade(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_grade";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close(); 
        }

        public void update_grade(string grade, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_grade";
            cmd.Parameters.Add("@grade", SqlDbType.VarChar, 50).Value = grade;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close(); 
        }



        public void insert_teacher(string name, string ph)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_teacher";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar, 11).Value = ph;


            cls_serverconnection.cn.Open(); 
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close(); 
        }

        public void delete_teacher(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_teacher";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open(); 
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();  
        }


        public void update_teacher(string name, string ph, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_teacher";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar, 11).Value = ph;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();
        }
        public void insert_course(string name, int g_id , int t_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_course";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@g_id", SqlDbType.Int).Value = g_id;
            cmd.Parameters.Add("@t_id", SqlDbType.Int).Value = t_id;


            cls_serverconnection.cn.Open(); 
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close(); 
        }

        public void delete_course(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_course";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();  
        }
        public void update_course(string name, int id , int g_id, int t_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_course";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = name;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@g_id", SqlDbType.Int).Value = g_id;
            cmd.Parameters.Add("@t_id", SqlDbType.Int).Value = t_id;


            cls_serverconnection.cn.Open();  
            cmd.ExecuteNonQuery();
            cls_serverconnection.cn.Close();

        }


        public string verify_user(string username)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cls_serverconnection.cn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "verify_user";
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            cls_serverconnection.cn.Open();
            string password = cmd.ExecuteScalar().ToString();
            cls_serverconnection.cn.Close();

            return password;
        }

    }
}
