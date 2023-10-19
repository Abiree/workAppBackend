using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Leaves
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
      
        public User User { get; set; }

        public string? ManagerId { get; set; }
  
        public User? Manager { get; set; }

        public Guid TypeId { get; set; }
        public TypeLeaves Type { get; set; }

        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }

        public int? Days { get; set; }

        public Guid StatutId { get; set; }
        public Statut Statut { get; set; }

        public String? Desc { get; set; }







    }
}
