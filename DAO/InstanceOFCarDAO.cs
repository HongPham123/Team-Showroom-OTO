using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    public class InstanceOFCarDAO
    {
        private static InstanceOFCarDAO instance;

        public static InstanceOFCarDAO Instance
        {
            get
            {
                if (instance == null) instance = new InstanceOFCarDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<InstanceOfCar> GetInstanceOfCarsByIdCar(Car car)
        {
            List<InstanceOfCar> instanceOfCarsList = new List<InstanceOfCar>();

            string query = " SELECT * FROM dbo.InstanceOfCar WHERE IDCar = @idCar ";

            DataTable data = DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { car.ID });

            foreach(DataRow row in data.Rows)
            {
                instanceOfCarsList.Add(new InstanceOfCar(row));
            }

            return instanceOfCarsList;
        }

        public bool UpdateInstanceOfCarById(InstanceOfCar instance)
        {
            string query = @" EXEC dbo.StoreProc_UpdateInstanceOfCarById @iD , @iDCar , @warehousingDate , @color , @imageOfInstance , @chassisNumber , @machineNumber , @entryPrice , @price , @status , @idOwnedCustomer ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { instance.ID,instance.IDCar,instance.WareHousingDate,instance.Color,
            instance.ImageOfInstance, instance.ChassisNumber, instance.MachineNumber, instance.EntryPrice, instance.Price, instance.Status , instance.IdOwnedCustomer}) > 0;
           
        }

        public bool DeleteInstanceOfCarById(InstanceOfCar instance)
        {
            string query = @" delete from InstanceOfCar where id = @id ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { instance.ID }) > 0;
        }

        public bool InsertInstanceOfCar(InstanceOfCar instance)
        {
            string query = @" exec StoreProc_InsertInstanceOfCar @iDCar , @color , @imageOfInstance , @chassisNumber , @machineNumber , @entryPrice , @price ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { instance.IDCar,instance.Color,instance.ImageOfInstance,instance.ChassisNumber,instance.MachineNumber,instance.EntryPrice,instance.Price}) > 0;
        }

        public DataTable GetInstanceOfCarsSoldList()
        {

            string query = @" select CustomerInfo.ID,Name,IdentityCardNumber,NumberPhone,CarName,InstanceOfCar.ID as IdCar, ChassisNumber, MachineNumber from instanceofcar , dbo.CustomerInfo , dbo.Car  WHERE status = 0 AND IDOwnedCustomer = CustomerInfo.ID  AND Car.ID = IDCar ";

            return DataProvider.Instance.ExcuteQueryGetDataTable(query);

        }
    }
}
