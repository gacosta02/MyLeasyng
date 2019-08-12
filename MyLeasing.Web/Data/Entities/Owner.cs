

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<Property> properties { get; set; }
        public ICollection<Contract> contracts { get; set; }
    }
}
