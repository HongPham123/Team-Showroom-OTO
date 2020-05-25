using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMemQuanLyShowroomXeHoi.DTO;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;

        public static CarDAO Instance
        {
            get
            {
                if (instance == null) instance = new CarDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Car> LoadCarList()
        {
            List<Car> carList = new List<Car>();

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(" SELECT * FROM dbo.Car ");

            foreach (DataRow row in dataTable.Rows)
            {
                Car car = new Car(row);
                carList.Add(car);
            }

            return carList;
        }

        public bool DeleteCarById(int idCar)
        {
            string query = @" exec Store_ProcDeleteCarById " + idCar;

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;

        }

        public bool UpdateCarByID(Car car)
        {
            string query = @" EXEC dbo.StoreProc_UpdateCarById @iD , @carName , @iDProducer , @imageOfCar ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { car.ID, car.CarName, car.IDProducer, car.ImageOfCar }) > 0;
        }

        public Car InsertNewCar()
        {
            string query = @" INSERT dbo.Car( CarName, IDProducer, ImageOfCar ) VALUES ( N'Chưa có tên',1,'empty.png') ";

            DataProvider.Instance.ExcuteNonQuery(query);

            string query2 = @" SELECT MAX(ID) FROM dbo.Car  ";

            int maxID = (int)DataProvider.Instance.ExcuteScalar(query2);

            string query3 = @" exec Store_ProcInsertNewSpec @idCar ";

            DataProvider.Instance.ExcuteNonQuery(query3, new object[] { maxID });

            return new Car(DataProvider.Instance.ExcuteQueryGetDataTable("select * from car where id = " + maxID).Rows[0]);
        }

        public DataTable GetSoldCar(DateTime from, DateTime to)
        {
            string query = @" SELECT CreateDate AS N'Ngày bán',dbo.InstanceOfCar.ID AS N'ID Xe',BillInfoDetails.CarName AS N'Tên xe',ProducerName AS N'Tên hãng',Name,NumberPhone,ValueOfPrice AS N'Giá bán' FROM dbo.Car,dbo.Bill,dbo.BillInfoDetails,dbo.Producer,dbo.CustomerInfo,dbo.InstanceOfCar WHERE Car.ID = IDInstanceOfCar AND Bill.ID = IDBill AND IDProducer = Producer.ID AND dbo.InstanceOfCar.ID = IDInstanceOfCar AND CreateDate BETWEEN @from AND @to AND IDOwnedCustomer = CustomerInfo.ID ";

            return DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { from, to });
        }

        public DataTable GetEntryCar(DateTime from, DateTime to)
        {
            string query = @" SELECT WarehousingDate, InstanceOfCar.ID,CarName,dbo.Producer.ProducerName,EntryPrice FROM dbo.Car,dbo.InstanceOfCar,dbo.Producer WHERE Car.ID = IDCar AND IDProducer = Producer.ID AND WarehousingDate BETWEEN @from AND @to  ";

            return DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { from, to });
        }

        public DataTable GetInventoryCar(DateTime from, DateTime to)
        {
            string query = @" SELECT WarehousingDate, InstanceOfCar.ID,CarName,dbo.Producer.ProducerName,EntryPrice FROM dbo.Car,dbo.InstanceOfCar,dbo.Producer WHERE Car.ID = IDCar AND IDProducer = Producer.ID AND WarehousingDate BETWEEN @from AND @to AND Status = 1 ";
            return DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { from, to });
        }
    }
}
