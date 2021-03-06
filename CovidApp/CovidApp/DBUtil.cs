﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CovidApp
{
    class DBUtil
    {
        static SqlConnection conn;
        public static void connection()
        {
            String connetStr = "server=DESKTOP-Q34EQV2;database=Covid_Management;Integrated Security=true;";//uid=sa;pwd=***
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
            string sql = "select * from manager where manger_ID=@para1 and password=@para2";//在sql语句中定义parameter，然后再给parameter赋值
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

        public static void BindDataGridView(DataGridView dgv, string sql)//绑定数据到datagridview；
        {
            try
            {
                connection();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//创建数据适配器对象
                DataSet ds = new DataSet();//创建数据集对象
                sda.Fill(ds);//填充数据集
                dgv.DataSource = ds.Tables[0];//绑定到数据表
                ds.Dispose();//释放资源
                close();
            }
            catch (Exception e)
            {

            }
        }
        public static LinkedList<string> queryOperator()//查看数据库中的用户
        {
            LinkedList<string> result = new LinkedList<string>();
            string sql = "select manger_ID from manager";
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
        public static bool query(string sql, string[] paras, out LinkedList<string[]> result)
        {
            string[] row = new string[12];
            result = new LinkedList<string[]>();
            connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (paras != null && paras.Length != 0)
            {
                for (int i = 0; i < paras.Length; i++)
                {
                    cmd.Parameters.AddWithValue("para" + i, paras[i]);
                }
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())//如果用户名和密码正确则能查询到一条语句，即读取下一行返回true
            {
                row[0] = Convert.ToString(reader.GetString(0));
                row[1] = Convert.ToString(reader.GetString(1));
                row[2] = Convert.ToString(reader.GetString(2));
                row[3] = Convert.ToString(reader.GetDateTime(3));
                row[4] = Convert.ToString(reader.GetString(4));
                row[5]= Convert.ToString(reader.GetInt32(5));
                row[6] = Convert.ToString(reader.GetInt32(6));
                row[7] = Convert.ToString(reader.GetInt32(7));
                row[8] = Convert.ToString(reader.GetInt32(8));
                row[9] = Convert.ToString(reader.GetInt32(9));
                row[10] = Convert.ToString(reader.GetString(10));
                result.AddLast(row);
                close();
                return true;
            }
            close();
            return false;

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
