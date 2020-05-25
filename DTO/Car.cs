using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    public class Car
    {
        private int iD;
        private string carName;
        private int iDProducer;
        private string imageOfCar;

        public int ID { get => iD; set => iD = value; }
        public string CarName { get => carName; set => carName = value; }
        public int IDProducer { get => iDProducer; set => iDProducer = value; }
        public string ImageOfCar { get => imageOfCar; set => imageOfCar = value; }

        public Car()
        {
            iD = 0;
            carName = "Chưa có tên";
            iDProducer = 0;
            imageOfCar = "empty.png";
        }

        public Car(DataRow row)
        {
            ID = (int)row["ID"];
            CarName = row["CarName"].ToString();
            IDProducer = (int) row["IDProducer"];
            ImageOfCar = row["ImageOfCar"].ToString();
        }

        public Car(Car car)
        {
            this.ID = car.ID;
            this.CarName = car.CarName;
            this.IDProducer = car.IDProducer;
            this.ImageOfCar = car.ImageOfCar;
        }
    }
}
