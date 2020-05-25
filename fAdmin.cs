using PhanMemQuanLyShowroomXeHoi.DAO;
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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dTPFrom.Value = new DateTime(today.Year, today.Month, 1);
            dTPTo.Value = dTPFrom.Value.AddMonths(1).AddDays(-1);
        }

        int select = 0;

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (select)
            {
                case 0: LoadBill(dTPFrom.Value, dTPTo.Value); break;
                case 1: LoadSoldCar(dTPFrom.Value, dTPTo.Value); break;
                case 2: LoadEntryCar(dTPFrom.Value, dTPTo.Value); break;
                case 3: LoadInventoryCar(dTPFrom.Value, dTPTo.Value); break;
                case 4: LoadSoldAccessory(dTPFrom.Value, dTPTo.Value); break;
                case 5: LoadEntryAccessory(dTPFrom.Value, dTPTo.Value); break;
                case 6: LoadInventoryAccessory(); break;
            }
            decimal value = 0;
            foreach(DataGridViewRow row in dGV.Rows)
            {
                if (row.Index == dGV.Rows.Count - 1) break;
                value += (decimal) row.Cells[row.Cells.Count - 1].Value;
            }
            dGV.Rows[dGV.Rows.Count - 1].Cells[dGV.ColumnCount - 2].Value = "Tổng giá trị:";

            dGV.Rows[dGV.Rows.Count - 1].Cells[dGV.ColumnCount - 1].Value = value.ToString("c");
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadBill(dTPFrom.Value, dTPTo.Value);
        }

        public void LoadBill(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = BillDAO.Instance.GetBill(dateFrom, dateTo);
        }

        public void LoadSoldCar(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = CarDAO.Instance.GetSoldCar(dateFrom, dateTo);
        }

        public void LoadEntryCar(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = CarDAO.Instance.GetEntryCar(dateFrom, dateTo);
        }

        public void LoadInventoryCar(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = CarDAO.Instance.GetInventoryCar(dateFrom, dateTo);
        }

        public void LoadEntryAccessory(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = AccessoryOfCarDAO.Instance.GetEntryAccessory(dateFrom, dateTo);
        }

        public void LoadInventoryAccessory()
        {
            dGV.DataSource = AccessoryOfCarDAO.Instance.GetInventoryAccessory();
        }

        public void LoadSoldAccessory(DateTime dateFrom, DateTime dateTo)
        {
            dGV.DataSource = AccessoryOfCarDAO.Instance.GetSoldAccessory(dateFrom, dateTo);
        }

        

        private void rbtnSoldCar_CheckedChanged(object sender, EventArgs e)
        {
            select = 1;
        }

        private void rbtnEntryCar_CheckedChanged(object sender, EventArgs e)
        {
            select = 2;
        }

        private void rbtnInventoryCar_CheckedChanged(object sender, EventArgs e)
        {
            select = 3;
        }

        private void rbtnAccessorySold_CheckedChanged(object sender, EventArgs e)
        {
            select = 4;
        }

        private void rbtnAccessoryEntry_CheckedChanged(object sender, EventArgs e)
        {
            select = 5;
        }

        private void rbtnInventoryAccessory_CheckedChanged(object sender, EventArgs e)
        {
            select = 6;
        }

        private void rbtnBill_CheckedChanged(object sender, EventArgs e)
        {
            select = 0;
        }
    }
}
