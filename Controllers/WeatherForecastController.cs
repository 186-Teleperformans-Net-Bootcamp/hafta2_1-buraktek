using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] Student_ student)
        {
            if (!ReqiredControl.Dogrula(student))
            {
                throw new Exception("Öğrenci bilgileri doğrulamadan geçemedi!");
            }

            if (!TableControl.Dogrula(student))
            {
                throw new Exception("Öğrenci bilgileri doğrulamadan geçemedi!");
            }

            return Ok();
        }

        [HttpPost]
        [Route("[controller]s/Date")]
        public IActionResult DateTime([FromBody] DateTime dateTime)
        {
            return Ok(dateTime.Ago(dateTime));
        }
    }
}