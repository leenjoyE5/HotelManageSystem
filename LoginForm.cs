namespace HotelManageSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User userDao = new User();
            string name=UserNameTextBox.Text.ToString();
            string pwd=PassWordTextBox.Text.ToString();
            if (userDao.IsUser(name,pwd))
            {
                MainForm mainForm= new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("�û��������벻��ȷ","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}