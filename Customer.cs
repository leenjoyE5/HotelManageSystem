using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManageSystem
{
    internal class Customer
    {

        public int? cid { get; set; }
        public string? csex { get; set; }
        public string? ccard { get; set; }
        public string? cname { get; set; }
        public int? rid { get; set; }
        
        DataSQL data = new DataSQL();
        public Customer() { }

        public MySqlDataReader SearchNullRoom()
        {            
            string selectUser = "select * from room where tai="+"'"+"空"+"'"+";";
            MySqlDataReader reader = data.read(selectUser);
            return reader;
        }

        public bool InsertCustomer(string name,string sex,string card,int rid) 
        {
            string insertSql = "insert into customer(gukename,gukesex,gukecard,roomid) values(" + "'" + name + "'" + "," + "'" + sex + "'" + "," + card + "," + rid + ");" + "update room set tai=" +"'满'" + " where id=" + rid;
            DataSQL data = new DataSQL();
            if (data.insert(insertSql) == true)
            {
                return true;
            }
            return false;
        }


        public bool DelCustomer(int id,int rid)
        {
            string sql = "delete from customer where gukeid=" + id + ";" + " alter table customer AUTO_INCREMENT = 1;" + "update room set tai=" + "'空'" + " where id=" + rid; ;
            DataSQL data = new DataSQL();
            if (data.delete(sql) == true)
            {
                return true;
            }
            return false;
        }

    }
}
