using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class CarManager : ICarService
    {
        ICarDal _carDal;
        private object p;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(object p)
        {
            this.p = p;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
