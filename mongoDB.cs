using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test
{
    class DatabaseAnalysis
    {
        public static int[] GetGraphData(String sensor, String node)
        {
            int[] data24 = new int[24];

            var client = new MongoClient("mongodb+srv://sWallMaster:QafWEwWvpYdRsdrY@swall-data-spnqi.mongodb.net/test?retryWrites=true&w=majority");
            Console.WriteLine("Database Connected");

            var db = client.GetDatabase("SensorData");
            var collection = db.GetCollection<BsonDocument>(node);

            var temps = collection.Find(new BsonDocument("Sensor", sensor)).Sort(Builders<BsonDocument>.Sort.Descending("_id")).Limit(8640).ToList();

            int count = 0;

            for (int i = 0; i < 8640; i++)
            {
                if (i == 0)
                {
                    data24[count] = System.Convert.ToInt32(temps[i].GetElement("Value").Value);
                    count += 1;
                }
                else if (i % 360 == 0)
                {
                    data24[count] = System.Convert.ToInt32(temps[i].GetElement("Value").Value);
                    count += 1;
                }
            }
            return data24;
        }
    }
}