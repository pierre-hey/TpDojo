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
    }
}
