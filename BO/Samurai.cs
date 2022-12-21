using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Samurai
    {
        public int Id { get; set; }
        
        [Required]
        public string Nom { get; set; }

        [Required]
        public int Force { get; set; }

        public Arme? Arme { get; set; }

        public int? ArmeId { get; set; }

        public List<ArtMartial>? ArtMartiaux { get; set; } = new List<ArtMartial>();

   //     public List<int>? ArtMartiauxIds { get; set; } = new List<int>();
    }
}
