using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? AvatarImg { get; set; }
        public DateTime? DateBirth { get; set; }
        public DateTime? StartDay { get; set; }
        public Guid? DesignationId { get; set; }
        public Designation? Designation { get; set; }

        public Guid? TeamId { get; set; }
        public Team? Team { get; set; }

        public string? ManagerId { get; set; }
        public User? Manager { get; set; }

    }
}
