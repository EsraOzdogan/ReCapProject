using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager: IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal carDal)
        {
            _brandDal = carDal;
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        [SecuredOperation("brand.add,moderator,admin")]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }

        [SecuredOperation("brand.delete,moderator,admin")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);

        }

        [SecuredOperation("brand.update,moderator,admin")]
        public IResult Update(Brand brand)
        {
             _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);


        }

      
    }
}
