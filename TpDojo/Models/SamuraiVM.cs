using Microsoft.AspNetCore.Mvc.Rendering;

namespace TPDojo.Models
{
    public class SamuraiVM
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Force { get; set; }

        public int? ArmeId { get; set; }

        public SelectList ArmesSelect { get; set; }
    }
}
