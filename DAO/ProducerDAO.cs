using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemQuanLyShowroomXeHoi.DTO;
using System.Data;

namespace PhanMemQuanLyShowroomXeHoi.DAO
{
    public class ProducerDAO
    {
        private static ProducerDAO instance;

        public static ProducerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProducerDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public List<Producer> LoadProducerList()
        {
            List<Producer> producerList = new List<Producer>();

            DataTable dataTable = DataProvider.Instance.ExcuteQueryGetDataTable(" SELECT * FROM dbo.Producer ");

            foreach (DataRow row in dataTable.Rows)
            {
                Producer producer = new Producer(row);
                producerList.Add(producer);
            }

            return producerList;
        }

        public void UpdateProducerById(Producer producer)
        {
            string query = @" UPDATE dbo.Producer SET Logo =  @logo WHERE ID = @iD ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { producer.Logo, producer.ID });
        }

        public Producer InsertNewProducer(string name)
        {
            string query = @" INSERT dbo.Producer (ProducerName,Logo) VALUES ( @name , 'empty.png') ";

            DataProvider.Instance.ExcuteNonQuery(query,new object[] { name });

            query = @"SELECT MAX(id) FROM dbo.Producer";

            int maxID = (int)DataProvider.Instance.ExcuteScalar(query);

            query = @" select * from producer where id = " + maxID;

            return new Producer(DataProvider.Instance.ExcuteQueryGetDataTable(query).Rows[0]);
        }

        public bool DeleteProducerById(Producer producer)
        {
            string query = @" delete from producer where id = " + producer.ID;

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
    }
}
