using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ArtMartial : Entite
    {
        public List<Samurai>? Samurais { get; set; } = new List<Samurai>();

  //      public List<int>? SamuraisIds { get; set; } = new List<int>();

    }
}
