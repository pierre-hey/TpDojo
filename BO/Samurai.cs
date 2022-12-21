using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Samurai : Entite
    {
        [Required]
        public int Force { get; set; }

        public Arme? Arme { get; set; }

        [DisplayName("Arme")]
        public int? ArmeId { get; set; }

        public List<ArtMartial>? ArtMartiaux { get; set; } = new List<ArtMartial>();


        public int Potentiel
        {
            get
            {
                int p = Force;
                if (ArmeId != null)
                {
                    p += Arme.Degat;
                }
                if (ArtMartiaux != null && ArtMartiaux.Any())
                {
                    p *= ArtMartiaux.Count + 1;
                }
                return p;
            }
        }
     
    }
}
