using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManageSystem
{
    internal class User
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public User() 
        {
            
        }

        public User(string name,string pwd)
        {
            UserName = name;
            Password = pwd;
        }


        public bool IsUser(string name,string pwd)
        {
            DataSQL data = new DataSQL();
            

            string selectUser = "select * from user";
            MySqlDataReader reader = data.read(selectUser);

            while (reader.Read())
            {
                if (reader[0].Equals(name) && reader[1].Equals(pwd))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
