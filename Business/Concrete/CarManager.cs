using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
                public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _CarDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _CarDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _CarDal.GetAll(c => c.BrandId == colorId);
        }

        public void Update(Car car)
        {
            _CarDal.Delete(car);
        }
    }
}
