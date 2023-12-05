using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapContext>,IRentalDal
    {
        public List<RentalsDto> GetRentalDetails()
        {
            using (ReCapContext context= new ReCapContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join customer in context.Customers on rental.CustomerId equals customer.UserId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join user in context.Users on customer.UserId equals user.Id
                    join color in context.Colors on rental.ColorId equals color.ColorId
                    select new RentalsDto()
                    {
                        RentalsId = rental.Id,
                        BrandName = brand.BrandName,
                        FullName = $"{user.FirstName} {user.LastName}",
                        ColorName = color.ColorName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };
                return result.ToList();
            }
        }

        public RentalsDto GetRentalDetailById(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join customer in context.Customers on rental.CustomerId equals customer.UserId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join user in context.Users on customer.UserId equals user.Id
                    join color in context.Colors on rental.ColorId equals color.ColorId
                    where id == rental.CustomerId
                    select new RentalsDto()
                    {
                        RentalsId = rental.Id,
                        BrandName = brand.BrandName,
                        FullName = $"{user.FirstName} {user.LastName}",
                        ColorName = color.ColorName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };
                return result.ToList().FirstOrDefault();
            }
            
        }
    }
}
