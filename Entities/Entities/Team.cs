using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Team {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
