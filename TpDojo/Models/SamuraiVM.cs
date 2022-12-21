#nullable disable
using BO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace TPDojo.Models
{
    public class SamuraiVM
    {
        public Samurai Samurai { get; set; }

        public SelectList? ArmesSelect { get; set; }

        [DisplayName("Art Martiaux pratiqués")]
        public List<int>? IdsArtsMartiaux { get; set; } = new List<int>();

        public SelectList? ArtsMartiauxSelect { get; set; }
    }
}
