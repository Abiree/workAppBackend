using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime Date { get; set; }

        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public TimeSpan WorkTime { get; set; }
        public TimeSpan BreakTime { get; set; }
        public TimeSpan OverTime { get; set; }
        public Guid statutId { get; set; }
        public Statut Statut { get; set; }

    }
}
