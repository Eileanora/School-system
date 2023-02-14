using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system
{
    internal class cls_serverconnection
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        
        static string databaseName = "school.mdf";
        static string filePath = Path.Combine(path, databaseName); 
        //public static SqlConnection cn = new SqlConnection(@"Data Source=.\;Initial Catalog=""C:\USERS\AL BADR\SOURCE\REPOS\NEWPROJ\SCHOOL SYSTEM\BIN\DEBUG\SCHOOL.MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    
       // public static SqlConnection cn = new SqlConnection(@"Data Source=.\;AttachDbFilename=" + filePath + ";Integrated Security=True");
        public static SqlConnection cn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{filePath}\";Integrated Security=True;Connect Timeout=30");
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\New folder\school.mdf";Integrated Security=True;Connect Timeout=30

    }
}
