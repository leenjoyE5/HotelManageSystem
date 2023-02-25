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
using System.Xml.Linq;

namespace HotelManageSystem
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        YuanGong yuangong = new YuanGong();

        Yfrom.AddForm AddForm=new Yfrom.AddForm();
        Yfrom.Form2 updateFrom=new Yfrom.Form2();
        private void UserControl2_Load(object sender, EventArgs e)
        {
            //YuanGong yuangong = new YuanGong();
            MySqlDataReader reader = yuangong.AllYuanGong();

            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = reader[0];
                this.dataGridView1.Rows[index].Cells[1].Value = reader[1];
                this.dataGridView1.Rows[index].Cells[2].Value = reader[2];
                this.dataGridView1.Rows[index].Cells[3].Value = reader[3];
                this.dataGridView1.Rows[index].Cells[4].Value = reader[4];
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm.ShowDialog();
            dataGridView1.Rows.Clear();
            UserControl2_Load(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           
            int a = dataGridView1.CurrentRow.Index;
            string str = dataGridView1.Rows[a].Cells[0].Value.ToString();
            
            
            if (yuangong.DeleteYuanGong(str) == true)
            {
                if(MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    //Invalidate();
                    dataGridView1.Rows.Clear();
                    UserControl2_Load(sender,e);
                }

            }
            else
            {
                MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;

            if (i >= 0)
            {
                YuanGong.temp[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                YuanGong.temp[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                YuanGong.temp[2] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                YuanGong.temp[3] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                YuanGong.temp[4] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                updateFrom.ShowDialog();
                dataGridView1.Rows.Clear();
                UserControl2_Load(sender, e);
            }
            else
            {
                MessageBox.Show("未选择", "提示", MessageBoxButtons.OK);
            }
            
            

        }
    }
}
