using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Customer> GetCustomerList()
        {
            List<Customer> customersList = new List<Customer>();

            string query = @" select * from customerinfo where id > 0 ";

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query);

            foreach(DataRow row in dataTable.Rows)
            {
                customersList.Add(new Customer(row));
            }

            return customersList;
        }

        public bool InsertCustomer( Customer customer )
        {
            string query = @" INSERT dbo.CustomerInfo ( IdentityCardNumber ,name,  Sex , Birthday ,NumberPhone ,Address ) VALUES  ( @identityCardNumber , @surname , @sex , @birthday , @numberPhone , @address ) ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { customer.IdentityCardNumber,customer.Name,customer.Sex,customer.BirthDay,customer.NumberPhone,customer.Address }) > 0;
        }

        public bool UpdateCustomer(Customer customer)
        {
            string query = @" UPDATE dbo.CustomerInfo SET IdentityCardNumber = @IdentityCardNumber , Name = @name , Sex = @sex , Birthday = @birthday , NumberPhone = @numberphone , Address = @address WHERE ID = @id  ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { customer.IdentityCardNumber, customer.Name, customer.Sex, customer.BirthDay, customer.NumberPhone, customer.Address , customer.Id }) > 0;
        }

        public bool DeleteCustomer( int id)
        {
            string query = @" delete customerinfo WHERE ID = @id  ";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { id }) > 0;
        }
    }

}
