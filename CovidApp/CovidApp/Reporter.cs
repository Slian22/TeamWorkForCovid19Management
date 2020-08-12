using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CovidApp
{
    class Reporter
    {
        static SqlConnection conn;
        public static void connection()
        {
            String connetStr = "server=DESKTOP-Q34EQV2;database=Covid_Management;Integrated Security=true;";//uid=sa;pwd=****
            conn = new SqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public static bool verify(string username, string password)
        {
            connection();
            string sql = "select * from  [user] where user_id=@para1 and password=@para2";//在sql语句中定义parameter，然后再给parameter赋值
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", username);
            cmd.Parameters.AddWithValue("para2", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())//如果用户名和密码正确则能查询到一条语句，即读取下一行返回true
            {
                close();
                return true;
            }
            close();
            return false;
        }

        public static LinkedList<string> queryOperator()//查看数据库中的用户
        {
            LinkedList<string> result = new LinkedList<string>();
            string sql = "select user_id from  [user]";
            connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.AddLast(reader.GetString(0));

            }
            close();
            return result;
        }



        public static int update(string sql, string[] paras)
        {
            int result = 0;
            connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (paras != null && paras.Length != 0)
            {
                for (int i = 0; i < paras.Length; i++)
                {
                    if (i != 3)
                    {
                        cmd.Parameters.AddWithValue("para" + i, paras[i]);
                    }
                    else
                        cmd.Parameters.AddWithValue("para" + i, Convert.ToDateTime(paras[i]));
                }
            }
            result = cmd.ExecuteNonQuery();
            close();
            return result;
        }




        public static void close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
