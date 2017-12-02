using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Model
{
    public class Film
    {
        public Film() { }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AdDuration { get; set; } //Duration of Advertisement that is obligatory
        public string Distributor { get; set; }
        public int MinimumAge { get; set; }

    }

}
