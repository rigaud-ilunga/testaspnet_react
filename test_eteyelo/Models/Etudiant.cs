namespace test_eteyelo.Models
{
    public class Etudiant
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string IdPromotion { get; set; }
    }
}