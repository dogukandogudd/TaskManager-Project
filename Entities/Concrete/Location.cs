using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location:IEntity
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
