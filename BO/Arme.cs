#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Arme : Entite
    {
        [DisplayName ("Dégats")]
        public int Degat { get; set; }

        [DisplayName("Propriétaire")]
        public Samurai Samurai { get; set; }

    }
}