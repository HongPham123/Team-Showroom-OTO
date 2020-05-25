using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using PhanMemQuanLyShowroomXeHoi.DTO;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool CheckLogin(string userName, string passWord)
        {
            string queryS = "EXEC StoreProc_Login @username , @password";

            return DataProvider.Instance.ExcuteQueryGetDataTable(queryS, new object[] { userName, passWord }).Rows.Count > 0;

        }

        public Account GetAccountByUserName(string userName)
        {
            string query = "EXEC StoreProc_GetAccountByUsername @userName";

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(query, new object[] { userName });

            if (dataTable.Rows.Count > 0)
            {
                return new Account(dataTable.Rows[0]);
            }

            return null;
        }

        public bool UpdateAccount( int idaccount, string displayName , string newPassword ="" )
        {
            

            if(newPassword == "")
            {
                string query = @" update account set displayname = @displayname where id = @idaccount " ;
                return DataProvider.Instance.ExcuteNonQuery(query, new object[] { displayName, idaccount }) > 0;
            }
            else
            {
                string query = @" update account set displayname = @displayname , password = @newpassword where id = @idaccount ";
                return DataProvider.Instance.ExcuteNonQuery(query, new object[] { displayName, newPassword ,idaccount }) > 0;
            }
        }
    }
}
