using AddTwoNumber.Services.MinichTwo;
using Microsoft.AspNetCore.Mvc;


namespace AddTwoNumber.Services.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{

    private readonly IAskingQuestionsService _askingQuestionsService;

    public  AskingQuestionsController(IAskingQuestionsService AskingQuestionsService) 
    {
        _askingQuestionsService = AskingQuestionsService;
    }


    [HttpGet] 
    [Route("Name/{yourName}/{timeYouWokeUp}")]
    public string AskinQs(string yourName, string timeYouWokeUp)
    {
        return _askingQuestionsService.AskinQs(yourName, timeYouWokeUp);
    }
}
