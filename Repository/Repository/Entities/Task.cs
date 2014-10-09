using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Entities
{
    public class Task
    {
        public int id { get; set; }
        public DateTime CreatedStamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DoneStamp { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int? CarId { get; set; }
        public virtual Car Car { get; private set; }
    }
}
