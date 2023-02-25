using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManageSystem
{
    internal class DataSQL
    {

        //打开数据库
        public MySqlConnection Connect()
        {
            MySqlConnectionStringBuilder mySqlConnectionString = new MySqlConnectionStringBuilder();
            mySqlConnectionString.UserID = "root";
            mySqlConnectionString.Password = "root";
            mySqlConnectionString.Server = "localhost";
            mySqlConnectionString.Database = "hotelsystem";
            mySqlConnectionString.CharacterSet = "utf8";
            //mySqlConnectionString.Port = 3306;

            MySqlConnection con = new MySqlConnection(mySqlConnectionString.ConnectionString);
            con.Open();


            return con; 
        }


        //执行语句的数据库方法
        public MySqlCommand command(string sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, Connect());
            return cmd;

        }

        //返回查询结果的方法
        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public bool insert(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connect());
            int i=Convert.ToInt32(cmd.ExecuteScalar());
            if (i < 0)
            {
                return false;
            }
            return true;
        }

        public bool delete(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connect());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i < 0)
            {
                return false;
            }
            return true;
        }


        public bool update(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connect());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i < 0)
            {
                return false;
            }
            return true;
        }
    }
}
