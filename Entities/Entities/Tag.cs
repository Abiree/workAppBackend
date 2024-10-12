using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task = Entities.Entities.Task;

namespace Entities.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public List<TaskTag> TaskTags { get; set; }
        // Navigation property for the join table
                                                    }
    }
