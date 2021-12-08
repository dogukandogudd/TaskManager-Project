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
    public class LocationManager:ILocationService
    {
        ILocationDal _locationDal;
        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IResult Add(Location location)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Location location)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll(),"lokasyonlar listelendi");
        }

        public IDataResult<Location> GetById(int LocationId)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(t => t.LocationId == LocationId));
        }

        public IResult Update(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
