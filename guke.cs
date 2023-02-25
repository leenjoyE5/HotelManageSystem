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
    public partial class guke : UserControl
    {
        AddCustomerForm addCustomerForm=new AddCustomerForm();
        Customer customer=new Customer();
        public guke()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guke_Load(object sender, EventArgs e)
        {
           
            DataSQL dataSQL = new DataSQL();
            string selectUser = "select * from customer";
            MySqlDataReader reader = dataSQL.read(selectUser);
            

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

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomerForm.ShowDialog();
            dataGridView1.Rows.Clear();
            guke_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            int str = Convert.ToInt32(dataGridView1.Rows[a].Cells[0].Value.ToString());
            int strid= Convert.ToInt32(dataGridView1.Rows[a].Cells[4].Value.ToString());

            if (customer.DelCustomer(str,strid) == true)
            {
                if (MessageBox.Show("退房成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    //Invalidate();
                    dataGridView1.Rows.Clear();
                    guke_Load(sender, e);
                }

            }
            else
            {
                MessageBox.Show("退房失败", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
