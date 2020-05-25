using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    public class Account
    {
        int id;
        string userName;
        string displayName;
        string passWord;
        int type;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }

        public Account(int id, string userName, string displayName, string passWord, int type)
        {
            this.Id = id;
            this.UserName = userName;
            this.DisplayName = displayName;
            this.PassWord = passWord;
            this.Type = type;
        }

        public Account(string userName, string displayName, string passWord, int type)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.PassWord = passWord;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.Type = (int)row["type"];
        }
    }
}
