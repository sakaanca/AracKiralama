using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
           _cars = new List<Car> {
        new Car(){CarId=1,ColorId=1,BrandId=1,DailyPrice=1000},
        new Car(){CarId=2,ColorId=1,BrandId=2,DailyPrice=250},
        new Car(){CarId=3,ColorId=2,BrandId=3,DailyPrice=120},
        new Car(){CarId=4,ColorId=3,BrandId=4,DailyPrice=90},

        };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.CarId == carId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsDtoByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsDtoByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailsDtoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailByBrandAndColorId(int colorId, int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsDtoByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
