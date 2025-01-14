using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne_API.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class AskingQuestions : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestions(AskingQuestionsServices askingQuestionsServices){
            _askingQuestionsServices = askingQuestionsServices;
        }
        [HttpPost]
        [Route("AskingQuestions/{name}/{time}")]
        public List<string> Question(string name, string time){
            return _askingQuestionsServices.FinalQuestion(name, time);
        }
    }
}