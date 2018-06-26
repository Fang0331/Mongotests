
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongotest
{
    class connect
    {

        private const string connUrl = "mongodb://127.0.0.1:27017";

        private const string dbName = "biztest";

        public static IMongoClient _client;
        public static IMongoDatabase _database;
        
          public  void Load()
        {

            var url = new MongoUrl(connUrl);
            var settings = MongoClientSettings.FromUrl(url);

            //创建数据连接
            _client = new MongoClient();
            _database = _client.GetDatabase(dbName);
            Console.WriteLine("biztest connected");

        }
        public void createdatabase() { }
    }
}
