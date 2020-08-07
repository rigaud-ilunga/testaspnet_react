using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
 

namespace test_eteyelo.Models
{
    public class EtudiantModels
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        public DataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("BookstoreDb");
        }
        public IEnumerable<Etudiant> GetBooks()
        {
            return _db.GetCollection<Etudiant>("Etudiants").FindAll();
        }

        public Etudiant GetBook(ObjectId id)
        {
            var res = Query<Etudiant>.EQ(p => p.Id, id);
            return _db.GetCollection<Etudiant>("Etudiants").FindOne(res);
        }
        public Etudiant Create(Etudiant etu)
        {
            _db.GetCollection<Etudiant>("Etudiants").Save(p);
            return p;
        }
        public void Update(ObjectId id, Book p)
        {
            etu.Id = id;
            var res = Query<Etudiant>.EQ(etus => etus.Id, id);
            var operation = Update<Etudiant>.Replace(etu);
            _db.GetCollection<Etudiant>("Etudiants").Update(res, operation);
        }
        public void Remove(ObjectId id)
        {
            var res = Query<Etudiant>.EQ(e => e.Id, id);
            var operation = _db.GetCollection<Etudiant>("Etudiants").Remove(res);
        }
    }
}
    }
}