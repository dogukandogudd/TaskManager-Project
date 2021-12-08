using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITaskService
    {
        IDataResult<List<Entities.Concrete.Task>> GetAll();
        IDataResult<List<Entities.Concrete.Task>> GetAllByLocation(int LocationId);
        IDataResult<List<Entities.Concrete.Task>> GetAllByStatus(int StatusId);
        IDataResult<Entities.Concrete.Task> GetById(int StatusId);
        IResult Add(Entities.Concrete.Task task);
        IResult Update(Entities.Concrete.Task task);
        IResult Delete(Entities.Concrete.Task task);

    }
}
