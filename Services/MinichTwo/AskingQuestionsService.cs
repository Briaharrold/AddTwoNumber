using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddTwoNumber.Services.MinichTwo
{
    public class AskingQuestionsService : IAskingQuestionsService
    {
         public string WhoAreYou(string yourName, string timeYouWokeUp)
        {
        
        return $"hi {yourName}, you woke up at {timeYouWokeUp}";
            
        }
    }
}