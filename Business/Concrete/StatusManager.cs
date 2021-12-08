using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StatusManager : IStatusService
    {
        IStatusDal _statusDal;
        public StatusManager(IStatusDal statusDal)
        {
                _statusDal=statusDal;
        }
        public IResult Add(Status status)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Status status)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Status>> GetAll()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetAll(), "durumlar listelendi");
        }

        public IDataResult<Status> GetById(int StatusId)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(t => t.StatusId == StatusId));
        }

        public IResult Update(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
