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
    public partial class fCurrentBills : Form
    {
        public fCarDetails fcarDetails;

        public Bill selectBill;

        Account acc;
        
        fCustomer fCustomer;

        public int selectIdBill;

        public int selectIdCustomer;

        decimal valueOfBill = 0;

        public fCurrentBills(Account acc)
        {
            InitializeComponent();

            this.acc = acc;
        }


        private void fCurrentBills_Load(object sender, EventArgs e)
        {
            LoadCurrentBillList();

            dGVBill.Columns["idstaff"].Visible = false;

            dGVBill.Columns["status"].Visible = false;

            dGVBill.Columns["id"].Width = 40;

            dGVBill.Columns["idcustomer"].Width = 40;

            dGVBill.Columns["createdate"].Width = 140;

            dGVBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadCurrentBillList()
        {
            dGVBill.DataSource = BillDAO.Instance.GetCurrentBillList();

            try
            {
                selectIdBill = (int)dGVBill.Rows[0].Cells[0].Value;

                selectIdCustomer = (int)dGVBill.Rows[0].Cells[2].Value;
            }
            catch { }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            fCustomer = new fCustomer();

            fCustomer.fcurrentBills = this;

            fCustomer.ShowDialog();
        }

        private void fCurrentBills_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(fcarDetails != null)
            fcarDetails.isOpen = false;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (BillDAO.Instance.DeleteBill(selectIdBill))
            {
                LoadCurrentBillList();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dGVBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectIdBill = (int)dGVBill.SelectedCells[0].OwningRow.Cells["id"].Value;

                selectIdCustomer = (int)dGVBill.SelectedCells[0].OwningRow.Cells["idcustomer"].Value;

                valueOfBill = (decimal)dGVBill.SelectedCells[0].OwningRow.Cells["valueofbill"].Value;
            }
            catch { }
            LoadBillDetails();

            dGVBillDetails.Columns["id"].Width = 40;

            dGVBillDetails.Columns["idbill"].Width = 40;

            dGVBillDetails.Columns["amount"].Width = 55;
            
        }

        private void dGVBill_SelectionChanged(object sender, EventArgs e)
        {

        }

        public void LoadBillDetails()
        {
            dGVBillDetails.DataSource = BillInfoDetailsDAO.Instance.GetBillInfoDetailsList(selectIdBill);

            dGVBillDetails.Columns["idInstanceCar"].Visible = false;
            dGVBillDetails.Columns["idAccessoryCar"].Visible = false;


        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (valueOfBill == 0) return;

            if (MessageBox.Show(string.Format("Thanh toán hóa đơn ({0}) với giá trị {1} ? ", new object[] { selectIdBill, valueOfBill }), "Thông báo",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                BillDAO.Instance.UpdateBillToPay(selectIdBill, acc.Id);

                LoadCurrentBillList();

                LoadBillDetails();
            }
        }

        public void ResetValueOfBill(decimal value)
        {
            foreach(DataGridViewRow row in dGVBill.Rows)
            {
                if((int)row.Cells["id"].Value == selectIdBill)
                {
                    row.Cells["valueofbill"].Value = ((decimal)row.Cells["valueofbill"].Value) + value;

                    break;


                }
            }
        }
    }
}
