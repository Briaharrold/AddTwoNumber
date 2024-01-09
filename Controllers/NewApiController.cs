using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumber.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
        [HttpGet]
        [Route("Add/{firstNum}{secondNum}")]
        public string Add(int firstNum int secondNum int sum)
        {
            return  firstNum + secondNum = sum
        }
    }
}