using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManageSystem
{
    internal class YuanGong
    {
        public static string[] temp = new string[5];
        public string? guyuanid { get; set; }
        public string? guyaunsex { get; set; }
        public string? guyuancard { get; set; }
        public string? guyuanxinzi { get; set; }
        public YuanGong() { }

        public MySqlDataReader AllYuanGong()
        {
            DataSQL data = new DataSQL();


            string selectUser = "select * from guyuan";
            MySqlDataReader reader = data.read(selectUser);




            return reader;
        }

        public bool InsertYuanGong(string name,string sex,string card,string xinzi)
        {
            string insertSql = "insert into guyuan(guyuanname,guyaunsex,guyuancard,guyuanxinzi) values(" + "'" +name+ "'" +","+ "'" +sex+ "'" +","+card+","+xinzi+");";
            DataSQL data = new DataSQL();
            if (data.insert(insertSql) == true)
            {
                return true;
            }
            return false;
        }


        public bool DeleteYuanGong(string id)
        {
            string sql = "delete from guyuan where guyuanid="+id+";"+" alter table guyuan AUTO_INCREMENT = 1;" ;
            DataSQL data = new DataSQL();
            if (data.delete(sql) == true)
            {
                return true;
            }
            return false;
        }


        public bool UpdateYuanGong(int id,string name, string sex, string card, string xinzi)
        {
            string sql = "update guyuan set guyuanname =  "+name + ", guyaunsex=" + sex+", guyuancard="+card+", guyuanxinzi="+xinzi+" where guyuanid = "+id;
            DataSQL data = new DataSQL();
            if (data.update(sql) == true)
            {
                return true;
            }
            return false;
        }

    }
}
