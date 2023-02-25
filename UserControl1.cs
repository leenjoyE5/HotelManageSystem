using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManageSystem
{
    public partial class UserControl1 : UserControl
    {
        AddRoomForm addRoomForm=new AddRoomForm();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            MySqlDataReader reader = room.AllRoom();

            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = reader[0];
                this.dataGridView1.Rows[index].Cells[1].Value = reader[1];
                this.dataGridView1.Rows[index].Cells[2].Value = reader[2];
                this.dataGridView1.Rows[index].Cells[3].Value = reader[3];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string str = dataGridView1.Rows[a].Cells[3].Value.ToString();
            if (str.Equals("满"))
            {
                MessageBox.Show("此房间有客人入住，不能删除", "提示", MessageBoxButtons.OK);
            }
            else
            {
                string strid = dataGridView1.Rows[a].Cells[0].Value.ToString();
                Room room= new Room();
                room.DoRoomDel(strid);
                dataGridView1.Rows.Clear();
                UserControl1_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRoomForm.ShowDialog();
            dataGridView1.Rows.Clear();
            UserControl1_Load(sender, e);
        }

        public void syncF1()
        {
            dataGridView1.Refresh();
        }

    }
}
