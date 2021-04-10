using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal carDal)
        {
            _colorDal = carDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetAllByBrandId(int ıd)
        {
            return _colorDal.GetAll(c => c.Id == ıd);
        }


        public void Add(Color color)
        {
            _colorDal.Add(color);
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);

        }
    }
}
