using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManageSystem.Yfrom
{
    public partial class Form2 : Form
    {
        //UserControl2 userControl=new UserControl2();
  
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = YuanGong.temp[1];
            sexTextBox.Text = YuanGong.temp[2];
            cardTextBox.Text = YuanGong.temp[3];
            xinziTextBox.Text = YuanGong.temp[4];
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(YuanGong.temp[0]);
            string name = nameTextBox.Text.ToString();
            string sex = sexTextBox.Text.ToString();
            string card = cardTextBox.Text.ToString();
            string xinzi = xinziTextBox.Text.ToString();
            if (name.Equals("") || sex.Equals("") || card.Equals("") || xinzi.Equals(""))
            {
                MessageBox.Show("输入的数据不完整", "提示", MessageBoxButtons.OK);
            }

            YuanGong yuanGong = new YuanGong();
            if (yuanGong.UpdateYuanGong(id,name, sex, card, xinzi) == true)
            {
                if (MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    /*nameTextBox.Text = "";
                    sexTextBox.Text = "";
                    cardTextBox.Text = "";
                    xinziTextBox.Text = "";*/
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
