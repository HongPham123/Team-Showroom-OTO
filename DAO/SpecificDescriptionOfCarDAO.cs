
using PhanMemQuanLyShowroomXeHoi.DTO;
using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
  public  class SpecificDescriptionOfCarDAO
    {
        private static SpecificDescriptionOfCarDAO instance;

        public static SpecificDescriptionOfCarDAO Instance
        {
            get
            {
                if (instance == null) instance = new SpecificDescriptionOfCarDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public SpecificDescriptionOfCar GetSpecificDescriptionOfCarById(int idCar)
        {
            string query = @"EXEC StoreProc_GetInfoDetailsOfCarById @idCar";

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query,new object[] { idCar });

            if (dataTable.Rows.Count > 0)
            {
                return new SpecificDescriptionOfCar(dataTable.Rows[0]);
            }
            else
            {
                return new SpecificDescriptionOfCar(); ;
            }
        }

        public bool UpdateSpecificDescriptionOfCarById(SpecificDescriptionOfCar spec)
        {
            string query = @"EXEC dbo.StoreProc_UpdateSpecificDescriptionOfCarById @idSpec , @TypeOfCar , @NumberOfSeat , @TypeOfEngine  , @Gear , @CylinderCapacity , @MaxPower , @MaxMomen , @FuelSystem , @PetrolTankCapacity  , @UrbanConsumption , @NonurbanConsumption , @CombinationConsumption , @FrontBrake , @RearBrake , @Length , @Height , @Width , @Weight ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] {spec.ID,spec.TypeOfCar,spec.NumberOfSeat,spec.TypeOfEngine,
            spec.Gear,spec.CylinderCapacity,spec.MaxPower,spec.MaxMomen,spec.FuelSystem,spec.PetrolTankCapacity,spec.UrbanConsumption,
                spec.NonurbanConsumption,spec.CombinationConsumption,spec.FrontBrake,spec.RearBrake,spec.Length,spec.Height,spec.Width,
            spec.Weight}) > 0;

        }
    }
}
