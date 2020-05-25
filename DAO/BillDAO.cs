using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public void InsertNewBill(int idCustomer)
        {
            string query = @" INSERT dbo.Bill ( CreateDate , IDCustomer , IDStaff , ValueOfBill ) VALUES  ( GETDATE() , @iDCustomer , @iDStaff , @valueOfBill ) ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idCustomer, 0, 0 });
        }

        public List<Bill> GetCurrentBillList()
        {
            List<Bill> billsList = new List<Bill>();

            string query = @" SELECT Bill.ID,CreateDate,IDCustomer,IDStaff,Name,ValueOfBill,status FROM dbo.Bill,dbo.CustomerInfo WHERE bill.IDCustomer = dbo.CustomerInfo.ID AND status = 1 ";

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

            foreach(DataRow row in dataTable.Rows)
            {
                billsList.Add(new Bill(row));
            }

            return billsList;
        }

        public bool DeleteBill(int id)
        {
            string query = @" delete bill where id = " + id;

           return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public void UpdateBillToPay(int idBill , int idStaff)
        {
            string query = @" exec StoreProc_PayTheBill @idBill , @idStaff ";

            DataProvider.Instance.ExcuteNonQuery(query,new object[] { idBill,idStaff });
        }

        public DataTable GetBill(DateTime from,DateTime to)
        {
            string query = @" SELECT CreateDate AS N'Ngày bán',CustomerInfo.ID,Name,NumberPhone,Account.ID,DisplayName,ValueOfBill FROM dbo.Bill,dbo.CustomerInfo,dbo.Account WHERE IDCustomer = CustomerInfo.ID AND IDStaff = Account.ID and  CreateDate BETWEEN  @from AND @to and status = 0 ";

            return DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { from, to });
        }
    }
}
