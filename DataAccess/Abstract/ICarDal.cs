using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        public List<CarDetailDto> GetCarDetails();
        public List<CarDetailDto> GetCarDetailsDtoByBrandId(int id);
        public List<CarDetailDto> GetCarDetailsDtoByColorId(int id);
        public List<CarDetailDto> GetCarDetailsDtoByUserId(int id);
        public CarDetailDto GetCarDetailsDtoById(int id);
        public List<CarDetailDto> GetCarDetailByBrandAndColorId(int colorId, int brandId);
    }
}
