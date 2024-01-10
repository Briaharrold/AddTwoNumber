
using AddTwoNumber.Services.MinichThree;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumber.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanOrLessThanController : ControllerBase
    {
     
        private readonly IGreaterThanOrLessThanService _greaterOrLessThanService;

    public GreaterThanOrLessThanController(IGreaterThanOrLessThanService greaterOrLessThanService)
    {
        _greaterOrLessThanService = greaterOrLessThanService;
    }
    [HttpGet]
    [Route("Greater/{F\firstNumber}/{secondNumber}")]

    public string Greater(string firstNumber, string secondNumber)
    {
        return _greaterOrLessThanService.Greater(firstNumber, secondNumber);
        
    }

        }
    