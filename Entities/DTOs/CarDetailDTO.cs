using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        //public int CarId { get; set; }
        //public string CarName { get; set; }
        //public string BrandName { get; set; }
        //public string ColorName { get; set; }
        //public int DailyPrice { get; set; }
        //public string CarImage { get; set; }
        //public int CustomerId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int RentalId { get; set; }
        //public string Email { get; set; }


        //******************
        public int CarId { get; set; }
        public string? CarName { get; set; }
        public string? BrandName { get; set; }

        public string? ColorName { get; set; }
        public int DailyPrice { get; set; }

        public int ColorId { get; set; }
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string ModelName { get; set; }
        public int RentalId { get; set; }
        public string Email { get; set; }
        //public int DailyPrice { get; set; }
        public string CarImage { get; set; }
        public int CustomerId { get; set; }

    }
}
