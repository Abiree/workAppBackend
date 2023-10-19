using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entities.Entities
{
    public class TaskTag
    {
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
