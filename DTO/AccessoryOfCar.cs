using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    public class AccessoryOfCar
    {
        private int iD;
        private string accessoryName;
        private string image;
        private decimal unitPrice;
        private int sumAmount;

        public int ID { get => iD; set => iD = value; }
        public string AccessoryName { get => accessoryName; set => accessoryName = value; }
        public string Image { get => image; set => image = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int SumAmount { get => sumAmount; set => sumAmount = value; }

        public AccessoryOfCar(DataRow row)
        {
            ID = (int)row["ID"];
            AccessoryName = row["AccessoryName"].ToString();
            Image = row["Image"].ToString();
            UnitPrice = (decimal)row["UnitPrice"];
            SumAmount = (int)row["SumAmount"];
        }

        public AccessoryOfCar()
        {
            iD = 0;
            accessoryName = "Chưa có tên";
            image = "empty.png";
            unitPrice = 0;
            sumAmount = 0;
        }
    }
}
