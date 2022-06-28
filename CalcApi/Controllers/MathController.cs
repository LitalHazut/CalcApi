using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CalcApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {

        [HttpPost("add")]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        [HttpPost("substract")]
        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        [HttpPost("multiply")]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        [HttpPost("divide")]
        public int Divide(int value1, int value2)
        {
            if (value2 == 0)
            {
                return 0;
            }

            else
            {
                return value1 / value2;
            }
        }

        //[HttpGet]
        //public string Get()
        //{
        //    return "default";
        //}
    }
}

