using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalcApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        private int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        private int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        private int Divide(int value1, int value2)
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

        [HttpPost("Calculate")]
        public int Calculate(int value1, int value2)
        {
            var calculateAction = Request.Headers["X-CalculateAction"].ToString();

            switch (calculateAction)
            {
                case "add":
                    return Add(value1, value2);

                case "substract":
                    return Substract(value1, value2);

                case "multiply":
                    return Multiply(value1, value2);

                case "divide":
                    return Divide(value1, value2);

                default: throw new Exception("Invalid Calculate");

            }
        }
    }
}

