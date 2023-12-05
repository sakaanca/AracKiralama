using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals carImage.CarId
                    select new CarDetailDto
                    {
                        CarId = car.CarId,
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        DailyPrice = car.DailyPrice,
                        CarImage = carImage.ImagePath
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsDtoByBrandId(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals carImage.CarId
                    where brand.BrandId == id
                    select new CarDetailDto()
                    {
                        CarId = car.CarId,
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                       CarImage = carImage.ImagePath,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsDtoByColorId(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals carImage.CarId
                    where color.ColorId == id
                    select new CarDetailDto()
                    {
                        CarId = car.CarId,
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        CarImage = carImage.ImagePath,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailsDtoById(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals carImage.CarId
                    where car.CarId == id
                    select new CarDetailDto()
                    {
                        CarId = car.CarId,
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        CarImage = carImage.ImagePath,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList().SingleOrDefault();
            }
        }

        public List<CarDetailDto> GetCarDetailByBrandAndColorId(int colorId, int brandId)
        {
           
                using (ReCapContext context = new ReCapContext())
                {
                    var result = from car in context.Cars
                        join Color in context.Colors on car.ColorId equals Color.ColorId
                        join brand in context.Brands on car.BrandId equals brand.BrandId
                        join carImage in context.CarImages on car.CarId equals carImage.CarId
                        where car.ColorId == colorId & car.BrandId == brandId
                        select new CarDetailDto()
                        {
                            CarId = car.CarId,
                            CarName = car.CarName,
                            ColorName = Color.ColorName,
                            BrandName = brand.BrandName,
                            CarImage = carImage.ImagePath,
                            DailyPrice = car.DailyPrice
                        };
                    return result.ToList();

                }
            
        }
    }
}
