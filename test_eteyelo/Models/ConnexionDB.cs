using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;

namespace test_eteyelo.Models
{
    public class ConnexionDB
    {        
        public MongoClient Client;
        public IMongoDatabase Db;
        public ConnexionDB(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }
    }
}