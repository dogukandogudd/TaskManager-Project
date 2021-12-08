using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Task:IEntity
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public int LocationId { get; set; }
        public Boolean TaskCheck { get; set; }
        public int StatusId { get; set; }
        public string TaskDescription { get; set; }


    }
}
