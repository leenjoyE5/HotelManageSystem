using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManageSystem
{
    internal class Room
    {
        public string? roomid { get; set; }
        public string? roomclass { get; set; }
        public string? roomprice { get; set; }
        public string? roomstate { get; set; }


        public Room() { }

        public MySqlDataReader AllRoom()
        {
            DataSQL data = new DataSQL();


            string selectUser = "select * from room";
            MySqlDataReader reader = data.read(selectUser);


           

            return reader; 
        }


        public bool DoRoomInto(int roomid, string roomclass, string roomprice)
        {
            string insertSql = "insert into room(id,class,price,tai) values(" + roomid + "," + "'" +roomclass + "'" + "," + roomprice + ","+"'空'"+ ");";
            DataSQL data = new DataSQL();
            if (data.insert(insertSql) == true)
            {
                return true;
            }
            return false;

       
        }

        public bool DoRoomDel(string id)
        {
            string sql = "delete from room where id=" + id + ";";
            DataSQL data = new DataSQL();
            if (data.delete(sql) == true)
            {
                return true;
            }
            return false;
        }

    }
}
