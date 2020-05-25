using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
   public class Bill
    {
        private int id;
        private DateTime createDate;
        private int idCustomer;
        private string customerName;
        private int idStaff;
        private decimal valueOfBill;
        private int status;

        public int Id { get => id; set => id = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
        public decimal ValueOfBill { get => valueOfBill; set => valueOfBill = value; }
        public int Status { get => status; set => status = value; }
        

        public Bill()
        {

        }

        public Bill(DataRow row)
        {
            id = (int)row["id"];
            createDate = (DateTime)(row["CreateDate"]);
            idCustomer = (int)row["idcustomer"];
            customerName = row["name"].ToString();
            idStaff = (int)row["idstaff"];
            valueOfBill = (decimal)row["valueofbill"];
            status = (int)row["status"];
        }
    }
}
