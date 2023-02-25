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
    public partial class AddCustomerForm : Form
    {

        Customer customer=new Customer();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

            MySqlDataReader reader = customer.SearchNullRoom();

            comboBox1.Text = "";
            while (reader.Read())
            {
                if (reader[3].Equals("空"))
                {
                    comboBox1.Items.Add(reader[0]);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text.ToString();
            string sex = textBox2.Text.ToString();
            string card = textBox3.Text.ToString();
            int rid = Convert.ToInt32(comboBox1.Text.ToString());
            if (name.Equals("") || sex.Equals("") || card.Equals("")||rid.Equals(""))
            {
                MessageBox.Show("输入的数据不完整", "提示", MessageBoxButtons.OK);
            }

            Room room = new Room();
            if (customer.InsertCustomer(name,sex,card,rid) == true)
            {
                if (MessageBox.Show("入住成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Items.Clear();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("入住失败", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
