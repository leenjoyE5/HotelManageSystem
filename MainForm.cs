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
    public partial class MainForm : Form
    {

        public guke guke1;
        public UserControl1 f1;
        public UserControl2 f2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gukeButton_Click(object sender, EventArgs e)
        {
            guke1 = new guke();
            guke1.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(guke1);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
            DataSQL data=new DataSQL();
            guke1 = new guke();
            guke1.Show();
            
            panel2.Controls.Clear();
            panel2.Controls.Add(guke1);
           
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            f1 = new UserControl1();
            f1.Show();            
            panel2.Controls.Clear();
            panel2.Controls.Add(f1);
            Invalidate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void guyuanButton_Click(object sender, EventArgs e)
        {
            f2 = new UserControl2();
            f2.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(f2);
            Invalidate();
        }
    }
}
