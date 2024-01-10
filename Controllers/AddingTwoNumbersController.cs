
using AddTwoNumber.Services.MinichOne;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumber.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingTwoNumbersController : ControllerBase
    {
       private readonly IAddTwoNumbersService _AddTwoNumbersService ;

    public AddingTwoNumbersController(IAddTwoNumbersService AddTwoNumbersService)
    {
        
        _AddTwoNumbersService = AddTwoNumbersService;
    }
[HttpGet] 
    [Route("{firstNum}/{secondNum}")]
    public string Add(string firstNum, string secondNum)
    {
        
        return _AddTwoNumbersService.Add(firstNum, secondNum);
    }
    }
}
