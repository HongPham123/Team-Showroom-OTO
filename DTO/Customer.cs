using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    class Customer
    {
        private int id;
        private string identityCardNumber;
        private string name;
        private int sex;
        private DateTime birthDay;
        private string numberPhone;
        private string address;

        public int Id { get => id; set => id = value; }
        public string IdentityCardNumber { get => identityCardNumber; set => identityCardNumber = value; }
        public string Name { get => name; set => name = value; }
        public int Sex { get => sex; set => sex = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Address { get => address; set => address = value; }

        public Customer(DataRow row)
        {
            id = (int)row["id"];
            identityCardNumber = row["identityCardNumber"].ToString();
            name = row["name"].ToString();
            sex = (int)row["sex"];
            birthDay = (DateTime)row["birthday"];
            numberPhone = row["numberPhone"].ToString();
            address = row["address"].ToString();
        }

        public Customer() { }
    }
}
