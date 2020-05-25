using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    public class InstanceOfCar
    {
        private int iD;
        private int iDCar;
        private DateTime wareHousingDate;
        private string color;
        private string imageOfInstance;
        private string chassisNumber;
        private string machineNumber;
        private decimal entryPrice;
        private decimal price;
        private int status;
        private int idOwnedCustomer;

        public int ID { get => iD; set => iD = value; }
        public int IDCar { get => iDCar; set => iDCar = value; }
        public DateTime WareHousingDate { get => wareHousingDate; set => wareHousingDate = value; }
        public string Color { get => color; set => color = value; }
        public string ImageOfInstance { get => imageOfInstance; set => imageOfInstance = value; }
        public string ChassisNumber { get => chassisNumber; set => chassisNumber = value; }
        public string MachineNumber { get => machineNumber; set => machineNumber = value; }
        public decimal EntryPrice { get => entryPrice; set => entryPrice = value; }
        public decimal Price { get => price; set => price = value; }
        public int Status { get => status; set => status = value; }
        public int IdOwnedCustomer { get => idOwnedCustomer; set => idOwnedCustomer = value; }

        public InstanceOfCar()
        {
            iD = 0;
            iDCar = 0;
            wareHousingDate = DateTime.Now;
            color = "";
            imageOfInstance = "";
            chassisNumber = "";
            machineNumber = "";
            entryPrice = 0;
            price = 0;
            status = 1;
            idOwnedCustomer = 0;
        }

        public InstanceOfCar( DataRow row)
        {
            ID =(int) row["ID"];
            IDCar = (int)row["IDCar"];
            WareHousingDate = (DateTime)row["WarehousingDate"];
            Color = row["Color"].ToString();
            ImageOfInstance = row["ImageOfInstance"].ToString();
            ChassisNumber = row["ChassisNumber"].ToString();
            MachineNumber = row["MachineNumber"].ToString();
            EntryPrice = (decimal)row["EntryPrice"];
            Price = (decimal)row["Price"];
            Status = (int)row["status"];
            IdOwnedCustomer = (int)row["IdOwnedCustomer"];
        }

        public InstanceOfCar(InstanceOfCar car)
        {
            ID = car.ID;
            IDCar = car.IDCar;
            WareHousingDate = car.WareHousingDate;
            Color = car.Color;
            ImageOfInstance = car.ImageOfInstance;
            ChassisNumber = car.ChassisNumber;
            MachineNumber = car.MachineNumber;
            EntryPrice = car.EntryPrice;
            Price = car.Price;
            Status = car.Status;
            IdOwnedCustomer = car.IdOwnedCustomer;
        }
    }
}
