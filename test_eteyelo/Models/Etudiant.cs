namespace test_eteyelo.Models
{
    public class Etudiant
    {
        [BsonId]
        public string Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string IdPromotion { get; set; }
    }
}