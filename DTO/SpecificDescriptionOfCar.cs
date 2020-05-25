using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
  public  class SpecificDescriptionOfCar
    {
        private int iD;
        private int iDCar;
        private string typeOfCar;
        private int numberOfSeat;
        private string typeOfEngine;
        private string gear;
        private string cylinderCapacity;
        private string maxPower;
        private string maxMomen;
        private string fuelSystem;
        private string petrolTankCapacity;
        private string urbanConsumption;
        private string nonurbanConsumption;
        private string combinationConsumption;
        private string frontBrake;
        private string rearBrake;
        private string length;
        private string height;
        private string width;
        private string weight;

        public int IDCar { get => iDCar; set => iDCar = value; }
        public string TypeOfCar { get => typeOfCar; set => typeOfCar = value; }
        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public string TypeOfEngine { get => typeOfEngine; set => typeOfEngine = value; }
        public string Gear { get => gear; set => gear = value; }
        public string CylinderCapacity { get => cylinderCapacity; set => cylinderCapacity = value; }
        public string MaxPower { get => maxPower; set => maxPower = value; }
        public string MaxMomen { get => maxMomen; set => maxMomen = value; }
        public string FuelSystem { get => fuelSystem; set => fuelSystem = value; }
        public string PetrolTankCapacity { get => petrolTankCapacity; set => petrolTankCapacity = value; }
        public string UrbanConsumption { get => urbanConsumption; set => urbanConsumption = value; }
        public string NonurbanConsumption { get => nonurbanConsumption; set => nonurbanConsumption = value; }
        public string CombinationConsumption { get => combinationConsumption; set => combinationConsumption = value; }
        public string FrontBrake { get => frontBrake; set => frontBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake = value; }
        public string Length { get => length; set => length = value; }
        public string Height { get => height; set => height = value; }
        public string Width { get => width; set => width = value; }
        public string Weight { get => weight; set => weight = value; }
        public int ID { get => iD; set => iD = value; }

        public SpecificDescriptionOfCar()
        {

        }

        public SpecificDescriptionOfCar(DataRow row)
        {
            ID = (int)row["ID"];
            IDCar = (int)row["IDCar"];
            TypeOfCar = row["TypeOfCar"].ToString();
            NumberOfSeat = (int)row["NumberOfSeat"];
            TypeOfEngine = row["TypeOfEngine"].ToString();
            Gear = row["Gear"].ToString();
            CylinderCapacity = row["CylinderCapacity"].ToString();
            MaxPower = row["MaxPower"].ToString();
            MaxMomen = row["MaxMomen"].ToString();
            FuelSystem = row["FuelSystem"].ToString();
            PetrolTankCapacity = row["PetrolTankCapacity"].ToString();
            UrbanConsumption = row["UrbanConsumption"].ToString();
            NonurbanConsumption = row["NonurbanConsumption"].ToString();
            CombinationConsumption = row["CombinationConsumption"].ToString();
            FrontBrake = row["FrontBrake"].ToString();
            RearBrake = row["RearBrake"].ToString();
            Length = row["Length"].ToString();
            Height = row["Height"].ToString();
            Width = row["Width"].ToString();
            Weight = row["Weight"].ToString();
        }
    }
}
