using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add2NumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
        [HttpGet("add")]
        public string AddNumbers([FromQuery] int num1, [FromQuery] int num2)
        {
            return $"The sum of {num1} and {num2} is {num1 + num2}.";
        }
    }
}