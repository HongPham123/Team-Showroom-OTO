using PhanMemQuanLyShowroomXeHoi.DAO;
using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyShowroomXeHoi
{
    public partial class fAccountInfo : Form
    {
        Account acc;

        public fAccountInfo(Account acc)
        {
            InitializeComponent();

            this.acc = acc;
        }

        private void fAccountInfo_Load(object sender, EventArgs e)
        {
            txtTendn.Text = acc.UserName;

            txtTennd.Text = acc.DisplayName;


        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!txtmk.Text.Equals(acc.PassWord))
            {
                MessageBox.Show("Sai mật khẩu");return;
            }

            if (!txtremk.Text.Equals(txtnewmk.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp");return;
            }

            if (AccountDAO.Instance.UpdateAccount(acc.Id, txtTennd.Text, txtnewmk.Text))
            {
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }
    }
}
