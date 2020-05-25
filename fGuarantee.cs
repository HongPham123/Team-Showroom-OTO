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
    public partial class fGuarantee : Form
    {
        int selectIdInstance = 0;
        int selectIdCustomer = 0;
        int selectIdGuarantee = 0;

        public fGuarantee()
        {
            InitializeComponent();
        }

        private void fGuarantee_Load(object sender, EventArgs e)
        {
            LoadGuaranteeList(0);
            LoadInstanceOFCarList();
        }

        public void LoadGuaranteeList(int id)
        {
            dGVGuarantee.DataSource = GuaranteeDAO.Instance.GetGuaranteesList(id);

            dGVGuarantee.Columns[0].Width = 40;
            dGVGuarantee.Columns[4].Width = 120;
            dGVGuarantee.Columns[5].Visible = false;
        }

        public void LoadInstanceOFCarList( )
        {
            dGVInstanceOfCar.DataSource = InstanceOFCarDAO.Instance.GetInstanceOfCarsSoldList();
            dGVInstanceOfCar.Columns[0].Width = 25;
            dGVInstanceOfCar.Columns[2].Width = 60;
            dGVInstanceOfCar.Columns[3].Width = 60;
            dGVInstanceOfCar.Columns[5].Width = 25;

        }

        private void btnThembaohanh_Click(object sender, EventArgs e)
        {

            
            if (selectIdInstance == 0) return;

            

            GuaranteeDAO.Instance.AddGuarantee(selectIdCustomer, selectIdInstance, "");

            LoadGuaranteeList(selectIdInstance);
        }

        private void dGVInstanceOfCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                selectIdInstance = (int)dGVInstanceOfCar.SelectedCells[0].OwningRow.Cells["idcar"].Value;

                selectIdCustomer = (int)dGVInstanceOfCar.SelectedCells[0].OwningRow.Cells["id"].Value;
            }
            catch { }

            LoadGuaranteeList(selectIdInstance);
        }

        private void dGVGuarantee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcontent.Text = dGVGuarantee.SelectedCells[0].OwningRow.Cells[5].Value.ToString();

                selectIdGuarantee = (int)dGVGuarantee.SelectedCells[0].OwningRow.Cells[0].Value;
            }
            catch { }
        }


        private void btnAddContent_Click(object sender, EventArgs e)
        {
            GuaranteeDAO.Instance.UpdateContent(txtcontent.Text, selectIdGuarantee);

            LoadGuaranteeList(selectIdInstance);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            selectIdInstance = 0;

            LoadGuaranteeList(0);
        }
    }


}
