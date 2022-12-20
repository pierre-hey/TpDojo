#nullable disable
using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Arme
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        public int Degat { get; set; }

    }
}