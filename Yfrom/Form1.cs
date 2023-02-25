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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.ToString();
            string sex=sexTextBox.Text.ToString();
            string card=cardTextBox.Text.ToString();
            string xinzi=xinziTextBox.Text.ToString();

            if (name.Equals("") || sex.Equals("") || card.Equals("") || xinzi.Equals(""))
            {
                MessageBox.Show("输入的数据不完整", "提示", MessageBoxButtons.OK);
            }

            YuanGong yuanGong = new YuanGong();
            if (yuanGong.InsertYuanGong(name, sex, card, xinzi) == true)
            {
                if(MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    nameTextBox.Text = "";
                    sexTextBox.Text = "";
                    cardTextBox.Text = "";
                    xinziTextBox.Text = "";
                    this.Hide();
                    
                }
            }
            else
            {
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK);
            }

            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
