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
    public partial class fCustomer : Form
    {
        BindingSource customerSource = new BindingSource();

      public  fCurrentBills fcurrentBills;

        public fCustomer()
        {
            InitializeComponent();

            dGVCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GetSource();

            dGVCustomer.DataSource = customerSource;

            txtName.DataBindings.Add(new Binding("Text", customerSource, "name", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", customerSource, "IdentityCardNumber", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", customerSource, "numberphone", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", customerSource, "address", true, DataSourceUpdateMode.Never));
            dTP.DataBindings.Add(new Binding("Value", customerSource, "birthday", true, DataSourceUpdateMode.Never));
        }

        public void GetSource()
        {
            customerSource.DataSource = CustomerDAO.Instance.GetCustomerList();

        }

        private void dGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            int cmnd = 0;

            try
            {
                cmnd = int.Parse(txtCMND.Text);

                customer.IdentityCardNumber = txtCMND.Text;

                customer.Name = txtName.Text;

                customer.NumberPhone = txtSDT.Text;

                if (rbtnNam.Checked) customer.Sex = 1;
                else customer.Sex = 0;

                customer.Address = txtDiaChi.Text;

                customer.BirthDay = dTP.Value;
            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu không hợp lệ"); return;
            }

            if (cmnd < 100000000 || cmnd > 999999999)
            {
                MessageBox.Show("Định dạng dữ liệu không hợp lệ"); return;
            }

            if (CustomerDAO.Instance.InsertCustomer(customer))
            {
                MessageBox.Show("Thêm thành công");
                GetSource();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void dGVCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sex = (int)dGVCustomer.SelectedCells[0].OwningRow.Cells[3].Value;

            if (sex == 0)
            {
                rbtnNu.Checked = true;
            }
            else
            {
                rbtnNam.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            int cmnd = 0;

            try
            {
                customer.Id = (int)dGVCustomer.SelectedRows[0].Cells["id"].Value;

                cmnd = int.Parse(txtCMND.Text);

                customer.IdentityCardNumber = txtCMND.Text;

                customer.Name = txtName.Text;

                customer.NumberPhone = txtSDT.Text;

                if (rbtnNam.Checked) customer.Sex = 1;
                else customer.Sex = 0;

                customer.Address = txtDiaChi.Text;

                customer.BirthDay = dTP.Value;
            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu không hợp lệ"); return;
            }

            if (cmnd < 100000000 || cmnd > 999999999)
            {
                MessageBox.Show("Định dạng dữ liệu không hợp lệ"); return;
            }

            if (CustomerDAO.Instance.UpdateCustomer(customer))
            {
                MessageBox.Show("Sửa thành công");
                GetSource();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCustomer.SelectedRows[0].Cells["id"].Value;

            if (CustomerDAO.Instance.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa thành công");GetSource();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void dGVCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (fcurrentBills == null) return;

            BillDAO.Instance.InsertNewBill((int)dGVCustomer.SelectedRows[0].Cells["id"].Value);

            fcurrentBills.LoadCurrentBillList();

            Close();
        }
    }
}
