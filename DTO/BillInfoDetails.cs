using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    class BillInfoDetails
    {
        private int id;
        private int idBill;
        private int idInstanceCar;
        private string carName;
        private int idAccessoryCar;
        private string accessoryName;
        private decimal unitPrice;
        private int amount;
        private decimal valueOfPrice;

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdInstanceCar { get => idInstanceCar; set => idInstanceCar = value; }
        public string CarName { get => carName; set => carName = value; }
        public int IdAccessoryCar { get => idAccessoryCar; set => idAccessoryCar = value; }
        public string AccessoryName { get => accessoryName; set => accessoryName = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Amount { get => amount; set => amount = value; }
        public decimal ValueOfPrice { get => valueOfPrice; set => valueOfPrice = value; }

        public BillInfoDetails(DataRow row)
        {
            Id = (int)row["id"];
            IdBill = (int)row["idbill"];
            try
            { IdInstanceCar = (int)row["IDInstanceOfCar"]; }
            catch
            {
                IdInstanceCar = 0;
            }
            carName = row["carName"].ToString();

            try
            { IdAccessoryCar = (int)row["IDAccessoryOfCar"]; }
            catch
            {
                IdAccessoryCar = 0;
            }
            accessoryName = row["accessoryName"].ToString();

            UnitPrice = (decimal)row["unitprice"];
            Amount = (int)row["amount"];
            ValueOfPrice = (decimal)row["valueofprice"];
        }

       
    }
}
