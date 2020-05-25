using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    public class AccessoryOfCarDAO
    {
        private static AccessoryOfCarDAO instance;

        public static AccessoryOfCarDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccessoryOfCarDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<AccessoryOfCar> GetAccessoryListByIdCar(int idCar)
        {
            string query = @" EXEC dbo.StoreProc_GetAccessoryByCarId @idCar = " + idCar;

            List<AccessoryOfCar> list = new List<AccessoryOfCar>();

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

            foreach (DataRow row in dataTable.Rows)
            {
                AccessoryOfCar accessory = new AccessoryOfCar(row);
                list.Add(accessory);
            }

            return list;
        }

        public bool UpdateAccessoryOfCarById(AccessoryOfCar accessory)
        {
            string query = @" Update ACcessoryOfCar set AccessoryName = @name , Image = @image , UnitPrice = @unitprice where ID = @id ";

            return DataProvider.Instance.ExcuteNonQuery(query,new object[] { accessory.AccessoryName,accessory.Image,
                accessory.UnitPrice,accessory.ID }) > 0;
        }

        public bool InsertAccessoryByIdCar(Car car, AccessoryOfCar accessory, decimal entryAmount , int amount )
        {
            string query = @" EXEC Store_ProcInsertAccessoryAndInventoryOfAccessory @iDCar , @accessoryName , @image , @unitPrice , @entryUnitPrice , @amount ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { car.ID, accessory.AccessoryName, accessory.Image, accessory.UnitPrice , entryAmount , amount }) > 0 ;
            
        }

        public bool DeleteAccessoryById(int id)
        {
            string query = @" exec StoreProc_DeleteAccessoryById @id ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { id}) > 0;
        }

        public bool IncreaseAmountForAccessory(AccessoryOfCar accessory, decimal price, int amount )
        {
            string query = @" INSERT dbo.InventoryOfAccessory( IDAccessory , WarehousingDate , EntryUnitPrice , Amount ) VALUES ( @iDAccessory ,  GETDATE() , @entryUnitPrice , @amount ) ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { accessory.ID, price,amount } ) > 0;
        }

        public DataTable GetEntryAccessory(DateTime from, DateTime to)
        {
            string query = @" SELECT WarehousingDate,AccessoryOfCar.ID,AccessoryName,InventoryOfAccessory.Amount,EntryUnitPrice FROM dbo.AccessoryOfCar,dbo.InventoryOfAccessory WHERE AccessoryOfCar.ID = IDAccessory AND WarehousingDate BETWEEN @from AND @to  ";
            return DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { from, to });
        }

        public DataTable GetInventoryAccessory()
        {
            string query = @" SELECT AccessoryOfCar.ID,AccessoryName,Amount,UnitPrice FROM dbo.AccessoryOfCar  ";
            return DataProvider.Instance.ExcuteQueryGetDataTable(query);
        }

        public DataTable GetSoldAccessory(DateTime from, DateTime to)
        {
            string query = @" SELECT CreateDate,AccessoryOfCar.ID AS N'ID phụ tùng',AccessoryOfCar.AccessoryName,BillInfoDetails.Amount,Name,NumberPhone,ValueOfPrice FROM dbo.Bill,dbo.BillInfoDetails,dbo.AccessoryOfCar,dbo.CustomerInfo WHERE Bill.ID = IDBill AND IDCustomer = CustomerInfo.ID AND IDAccessoryOfCar = AccessoryOfCar.ID and CreateDate between @from and @to  ";
            return DataProvider.Instance.ExcuteQueryGetDataTable(query,new object[] { from, to });
        }
       
    }
}
