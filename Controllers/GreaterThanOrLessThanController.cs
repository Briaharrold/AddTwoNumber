
using AddTwoNumber.Services.MinichThree;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumber.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class GreaterThanOrLessThanController : ControllerBase
    {
        private readonly IGreaterThanOrLessThanService _greaterThanOrLessThanService;
     public GreaterThanOrLessThanController(IGreaterThanOrLessThanService greaterThanOrLessThanService)
     {
            _greaterThanOrLessThanService = greaterThanOrLessThanService;
        
     }
     [HttpGet]
     [Route("GreaterThan/{firstNumber}/{secondNumber}")]
     public string Greater(string firstNumber, string secondNumber)
     {
        return _greaterThanOrLessThanService.Greater(firstNumber,secondNumber);
     }

        }
    