using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ArtMartial
    {
        public int Id { get; set; }

        public string Nom { get; set; }


        public List<Samurai>? Samurais { get; set; } = new List<Samurai>();

  //      public List<int>? SamuraisIds { get; set; } = new List<int>();

    }
}
