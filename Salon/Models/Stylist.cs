using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
    {
        public Stylist()
        {
            this.TestName = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Client> TestName { get; set; }
    }
}