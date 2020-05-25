using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
   public class Guarantee
    {
        private int id;
        private int idCustomer;
        private string customerName;
        private int idInstanceOfCar;
        private DateTime guaranteeDate;
        private string contentOfGuarantee;

        public int Id { get => id; set => id = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public int IdInstanceOfCar { get => idInstanceOfCar; set => idInstanceOfCar = value; }
        public DateTime GuaranteeDate { get => guaranteeDate; set => guaranteeDate = value; }
        public string ContentOfGuarantee { get => contentOfGuarantee; set => contentOfGuarantee = value; }
        

        public Guarantee(DataRow row)
        {
            id = (int)row["id"];
            IdCustomer = (int)row["idcustomer"];
            customerName = row["customername"].ToString();
            idInstanceOfCar = (int)row["idInstanceOfCar"];
            guaranteeDate = (DateTime)row["guaranteeDate"];
            contentOfGuarantee = row["contentOfGuarantee"].ToString();
        }
    }
}
