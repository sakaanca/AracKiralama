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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             //from c in context.Cars
                             join User in context.Users
                             on c.UserId equals User.Id
                             //join Color in context.Colors
                             //on c.ColorId equals Color.ColorId
                             //join Rental in context.Rentals
                             //on c.RentalId equals Rental.RentalId


                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 DailyPrice = (short)c.DailyPrice,
                                 FirstName = User.FirstName,
                                 LastName = User.LastName,
                                 //ColorName = Color.ColorName,
                                 //RentalId = Rental.RentalId,
                                 //Email = User.Email





                             };
                return result.ToList();
            }
        }
        //public List<CarDetailDto> GetCarDetails()
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from car in context.Cars
        //            join color in context.Colors on car.ColorId equals color.ColorId
        //            join brand in context.Brands on car.BrandId equals brand.BrandId
        //            join carImage in context.CarImages on car.CarId equals carImage.CarId
        //            select new CarDetailDto
        //            {
        //                CarId = car.CarId,
        //                CarName = car.CarName,
        //                ColorName = color.ColorName,
        //                BrandName = brand.BrandName,
        //                DailyPrice = (int)car.DailyPrice,
        //                CarImage = carImage.ImagePath
        //            };
        //        return result.ToList();
        //    }
        //}

        public List<CarDetailDto> GetCarDetailsDtoByBrandId(int id)
        {
            using (RentACarContext context = new RentACarContext())
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
                        DailyPrice = (int)car.DailyPrice
                        
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsDtoByColorId(int id)
        {
            using (RentACarContext context = new RentACarContext())
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
                        DailyPrice = (int)car.DailyPrice
                    };
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailsDtoById(int id)
        {
            using (RentACarContext context = new RentACarContext())
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
                        DailyPrice = (int)car.DailyPrice
                    };
                return result.ToList().SingleOrDefault();
            }
        }

        public List<CarDetailDto> GetCarDetailByBrandAndColorId(int colorId, int brandId )
        {
           
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from car in context.Cars
                        join Color in context.Colors on car.ColorId equals Color.ColorId
                        join brand in context.Brands on car.BrandId equals brand.BrandId
                        join carImage in context.CarImages on car.CarId equals carImage.CarId
                        join Customer in context.Customers on car.CustomerId equals Customer.CustomerId
                        where car.ColorId == colorId & car.BrandId == brandId
                        select new CarDetailDto()
                        {
                            CarId = car.CarId,
                            CarName = car.CarName,
                            ColorName = Color.ColorName,
                            BrandName = brand.BrandName,
                            CarImage = carImage.ImagePath,
                            DailyPrice = (int)car.DailyPrice,
                            CustomerId = Customer.CustomerId

                            
                        };
                    return result.ToList();

                }
            
        }

        public List<CarDetailDto> GetCarDetailsDtoByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
