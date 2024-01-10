
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumber.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
    
        [HttpPost]
        [Route("Add/{firstNum}/{secondNum}")]
       private readonly ISumService _sumService;

    public SumController(ISumService sumService)
    {
        _sumService = sumService;
    }

    public string Numbers(string NumberOne, string NumberTwo)
    {
        return _sumService.Numbers(NumberOne, NumberTwo);
    }
}
