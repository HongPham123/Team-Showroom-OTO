using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
   public class GuaranteeDAO
    {
        private static GuaranteeDAO instance;

        public static GuaranteeDAO Instance
        {
            get
            {
                if (instance == null) instance = new GuaranteeDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Guarantee> GetGuaranteesList(int idInstanceOfCar = 0)
        {
            List<Guarantee> list = new List<Guarantee>();

            if(idInstanceOfCar == 0)
            {
                string query = @" SELECT Guarantee.ID, IDCustomer, Name as customername , IDInstanceOfCar , ChassisNumber, MachineNumber , GuaranteeDate , ContentOfGuarantee FROM dbo.Guarantee , dbo.CustomerInfo , dbo.InstanceOfCar WHERE CustomerInfo.ID  = IDCustomer AND IDInstanceOfCar = InstanceOfCar.ID ";

                DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

                foreach(DataRow row in dataTable.Rows)
                {
                    list.Add(new Guarantee(row));
                }

            }
            else
            {
                string query = @" SELECT Guarantee.ID, IDCustomer, Name as customername , IDInstanceOfCar , ChassisNumber, MachineNumber , GuaranteeDate , ContentOfGuarantee FROM dbo.Guarantee , dbo.CustomerInfo , dbo.InstanceOfCar WHERE CustomerInfo.ID  = IDCustomer AND IDInstanceOfCar = InstanceOfCar.ID and IDInstanceOfCar = " + idInstanceOfCar;

                DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    list.Add(new Guarantee(row));
                }
            }

            return list;
        }

        public void AddGuarantee(int idcus, int idins, string content)
        {
            string query = @" INSERT dbo.Guarantee  ( IDCustomer ,  IDInstanceOfCar , ContentOfGuarantee )VALUES  ( @iDCustomer , @IDInstanceOfCar , @ContentOfGuarantee ) ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idcus, idins, content });
        }

        public void UpdateContent(string content , int id)
        {
            string query = @" update guarantee set contentofguarantee = @content where id = @id ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { content, id });
        }
    }
}
