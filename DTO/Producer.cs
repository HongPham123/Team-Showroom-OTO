using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMemQuanLyShowroomXeHoi.DAO;

namespace PhanMemQuanLyShowroomXeHoi.DTO
{
    public class Producer
    {
        private int iD;
        private string producerName;
        private string logo;

        public int ID { get => iD; set => iD = value; }
        public string ProducerName { get => producerName; set => producerName = value; }
        public string Logo { get => logo; set => logo = value; }

        public Producer(DataRow row)
        {
            ID = (int)row["ID"];
            ProducerName = row["ProducerName"].ToString();
            logo = row["Logo"].ToString();
        }

        public Producer() { }

        
    }
}
