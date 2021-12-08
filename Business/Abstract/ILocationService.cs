using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<Location> GetById(int LocationId);
        IDataResult<List<Location>> GetAll();
        IResult Add(Location location);
        IResult Update(Location location);
        IResult Delete(Location location);
    }
}
