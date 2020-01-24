using System.Collections.Generic;

namespace Market.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<TreatFlavor> Flavors { get; set; }
      

    }
}
