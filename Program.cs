using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mongotest
{
    class Program
    {

        static void Main(string[] args)
        {
            connect mydb = new connect();
            mydb.Load();
            IAsyncCursor<BsonDocument> mycursor= connect._database.ListCollections();
            IMongoCollection<BsonDocument> mycollection=connect._database.GetCollection<BsonDocument> ("newscollection");
            IFindFluent<BsonDocument,BsonProjection> myresult =mycollection.Find<BsonDocument>()
            
           // Console.Write(mycursor);
            Console.Read();

        }








    }
}
