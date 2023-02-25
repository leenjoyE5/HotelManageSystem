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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text.ToString());
            string roomclass = textBox2.Text.ToString();
            string price = textBox3.Text.ToString();
            
            if (id.Equals("") || roomclass.Equals("") || price.Equals(""))
            {
                MessageBox.Show("输入的数据不完整", "提示", MessageBoxButtons.OK);
            }

            Room room = new Room();
            if (room.DoRoomInto(id,roomclass,price) == true)
            {
                if (MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                   
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
