using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,CategoryId=1,CarName="Toyota",BrandId=1,ColorId=1,DailyPrice=200,
            Descriptions="otomatikDizel",ModelYear=2019},
            new Car{CarId=2,CategoryId=2,CarName="Ferrari",BrandId=2,ColorId=2,DailyPrice=2000,
            Descriptions="otomatik",ModelYear=2020
            },
            new Car{CarId=3,CategoryId=3,CarName="Bmw",BrandId=3,ColorId=3,DailyPrice=350,
            Descriptions="Manuel",ModelYear=2009
            }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = 
           _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void update(Car car)
        {
            Car carToUpdate =
           _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToUpdate);
        }

       
    }
}
