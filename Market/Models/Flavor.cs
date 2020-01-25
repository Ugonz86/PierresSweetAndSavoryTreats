using System.Collections.Generic;

namespace Market.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }

        public int FlavorId { get; set; }
        public string Description { get; set; }
        public int TreatId { get; set; } 
        public virtual Treat Treat { get; set; }
        public virtual ApplicationUser User { get; set; } 

        public ICollection<TreatFlavor> Treats { get;}
    }
}