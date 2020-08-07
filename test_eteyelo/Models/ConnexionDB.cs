using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;

namespace test_eteyelo.Models
{
    public class ConnexionDB
    {
        nnection to the server and define the database of project:
using MongoDB.Driver;


    public class MongoDbRepo
    {
        //The client that manage the connection
        public MongoClient Client;
        //The interface that manage the database
        public IMongoDatabase Db;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">Mongo server url</param>
        /// <param name="database">Database name</param>
        public MongoDbRepo(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }
    }
}
    }
}