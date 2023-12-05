using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int id)
        {
            var result=_carService.GetCarsByColorId(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            else
            return BadRequest(result);
        }

        [HttpGet("getbybrand")]
        public IActionResult GetByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
                return BadRequest(result);
           
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetCarDetailsById(int id)
        {
            var result = _carService.GetCarDetailsDtoById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getdetailsbybrand")]
        public IActionResult GetCarDetailsByBrandId(int id)
        {
            var result = _carService.GetCarDetailsDtoByBrandId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getdetailsbycolor")]
        public IActionResult GetCarDetailsByColorId(int id)
        {
            var result = _carService.GetCarDetailsDtoByColorId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getdetailsbybrandandcolor")]
        public IActionResult GetCarDetailByBrandAndColorId(int colorId,int brandId)
        {
            var result = _carService.GetCarDetailByBrandAndColorId(colorId, brandId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPut("delete")]
        public IActionResult Delete(Car car)
        {
            var result=_carService.Delete(car);
            if (result.Success==true)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
