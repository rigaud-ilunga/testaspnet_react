using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace test_eteyelo.Models{

    public class Etudiant{
        [BonID]
        [BsonRepresentation(BsonType.ObjectID)]

        public string EtuId{get; set;}

        public string EtuNom{set; get;}

        public string EtuPrenom{set; get;}

        [BsonElement("IdPromotion")]
        public ObjectId IdPromotion{set; get;}
    }
}