using System;
using System.Windows.Forms;
using PhanMemQuanLyShowroomXeHoi.DAO;
using PhanMemQuanLyShowroomXeHoi.DTO;

namespace PhanMemQuanLyShowroomXeHoi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.CheckLogin(userName, passWord);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txbUserName.Text, txbPassWord.Text))
            {
                Account acc = AccountDAO.Instance.GetAccountByUserName(txbUserName.Text);
               fSell frmSell = new fSell(acc);
                this.Hide();
                frmSell.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên tài khoản!");
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
