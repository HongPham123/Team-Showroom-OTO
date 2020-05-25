using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    class BillInfoDetailsDAO
    {
        private static BillInfoDetailsDAO instance;

        public static BillInfoDetailsDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDetailsDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<BillInfoDetails> GetBillInfoDetailsList(int idBill)
        {
            List<BillInfoDetails> list = new List<BillInfoDetails>();

            string query = @" select * from billinfodetails where idbill = " + idBill;

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

            foreach(DataRow row in dataTable.Rows)
            {
                list.Add(new BillInfoDetails(row));
            }

            return list;
        }

        public void AddCarForBill(int idCar , string carName ,decimal price, int idBill , int idCustomer)
        {
            string query = @" exec StoreProc_AddCarForBill @idCar , @carName , @price , @idBill , @idCustomer ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idCar, carName,price, idBill , idCustomer });
        }

        public void AddAccessoryForBill(int idAccessory, string accessoryName, decimal unitprice, int amount, int idBill)
        {
            string query = @" exec StoreProc_AddAccessoryForBill @idAccessory , @accessoryName , @unitprice , @amount , @idBill ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idAccessory, accessoryName, unitprice , amount, idBill });
        }
    }
}
