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

        static int dataPoints_Day = 1440;
        static int graphDataPoints = 24;

        public static List<BsonDocument> getDailyData(String sensor, String node)
        {
            var client = new MongoClient("mongodb+srv://sWallMaster:QafWEwWvpYdRsdrY@swall-data-spnqi.mongodb.net/test?retryWrites=true&w=majority");
            Console.WriteLine("Database Connected");

            var db = client.GetDatabase("SensorData");
            var collection = db.GetCollection<BsonDocument>(node);

            var filter = Builders<BsonDocument>.Filter.Eq("Sensor", sensor);
            var projection = Builders<BsonDocument>.Projection.Exclude("Time");
            var sort = Builders<BsonDocument>.Sort.Descending("_id");

            return collection.Find(filter).Project(projection).Sort(sort).Limit(dataPoints_Day).ToList();
        }

        public static int[] getGraphData(List<BsonDocument> data)
        {
            int[] graphArray = new int[graphDataPoints];

            int count = 0;

            for (int i = 0; i < dataPoints_Day; i++)
            {
                if (i == 0)
                {
                    graphArray[count] = System.Convert.ToInt32(data[i].GetElement("Value").Value);
                    count += 1;
                }
                else if (i % (dataPoints_Day / graphDataPoints) == 0)
                {
                    graphArray[count] = System.Convert.ToInt32(data[i].GetElement("Value").Value);
                    count += 1;
                }
            }
            return graphArray;
        }

        public static double getDailyAverage(List<BsonDocument> data)
        {

            double sum = 0;

            for (int i = 0; i < dataPoints_Day; i++)
            {
                sum += System.Convert.ToInt32(data[i].GetElement("Value").Value);
            }

            return Math.Round(sum / dataPoints_Day);
        }

        public static double getDailyHigh(List<BsonDocument> data)
        {
            double high = 0;

            high = System.Convert.ToDouble(data[0].GetElement("Value").Value);

            for (int i = 1; i < dataPoints_Day; i++)
            {
                if (high < System.Convert.ToDouble(data[i].GetElement("Value").Value))
                {
                    high = System.Convert.ToDouble(data[i].GetElement("Value").Value);
                }
            }
            return high;
        }

        public static double getDailyLow(List<BsonDocument> data)
        {
            double low = 0;

            low = System.Convert.ToDouble(data[0].GetElement("Value").Value);

            for (int i = 1; i < dataPoints_Day; i++)
            {
                if (low > System.Convert.ToDouble(data[i].GetElement("Value").Value))
                {
                    low = System.Convert.ToDouble(data[i].GetElement("Value").Value);
                }
            }
            return low;
        }

    }
}
