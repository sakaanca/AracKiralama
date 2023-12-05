using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalsDto:IDto
    {
        public int RentalsId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string FullName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
