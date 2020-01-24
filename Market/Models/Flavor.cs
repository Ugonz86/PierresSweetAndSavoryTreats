using System.Collections.Generic;

namespace Market.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        public string Description { get; set; }

        public ICollection<TreatFlavor> Treats { get; }

        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }
    }
}
