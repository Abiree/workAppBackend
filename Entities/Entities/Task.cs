using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
             
         // Navigation property for the join table
        public List<TaskTag> TaskTags { get; set; } 
       
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TimeSpent
        {
            get
            {
                return EndTime - StartTime;
            }
        }
    }
}
