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
  
        internal ConnexionDB _repo = new ConnexionDB("mongodb://127.0.0.1:27017", "Saas");
        private const string _collectionName = "Etudiants";
        //Contains all documents inside the collection
        public IMongoCollection<EtudiantModels> Collection;

        //Constructor
        public EtudiantModels()
        {
            this.Collection = _repo.Db.GetCollection<EtudiantModels>(_collectionName);
        }
        public IEnumerable<Etudiant> GetEtudiants()
        {
            return _db.GetCollection<Etudiant>("Etudiants").FindAll();
        }

        public Etudiant GetEtudiantByPromotion(ObjectId  IdPromotion)
        {
            var res = Query<Etudiant>.EQ(et => et.Id, IdPromotion);
            return _db.GetCollection<Etudiant>("Etudiants").FindOne(res);
        }

        public Etudiant GetEtudiantByName(string  nom)
        {
            var res = Query<Etudiant>.EQ(et => et.Id, nom);
            return _db.GetCollection<Etudiant>("Etudiants").FindOne(res);
        }
        public Etudiant Get(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Create(Etudiant etu)
        {
            this.Collection.InsertOneAsync(etu);
        }
        public void Update(ObjectId id, Etudiant etu)
        {
            etu.Id = id;
            var res = Query<Etudiant>.EQ(etus => etus.Id, id);
            var operation = Update<Etudiant>.Replace(etu);
            _db.GetCollection<Etudiant>("Etudiants").Update(res, operation);
        }

        public Etudiant getAllEtudiant(){
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
        public void Remove(ObjectId id)
        {
            var res = Query<Etudiant>.EQ(etu => etu.Id, id);
            var operation = _db.GetCollection<Etudiant>("Etudiants").Remove(res);
        }
    }
}