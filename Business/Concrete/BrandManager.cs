using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager: IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal carDal)
        {
            _brandDal = carDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllByBrandId(int ıd)
        {
            return _brandDal.GetAll(b => b.Id == ıd);
        }

        
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
        public void Update(Brand brand)
        {
             _brandDal.Update(brand);

        }
    }
}
