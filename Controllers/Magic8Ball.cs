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
    public class Magic8Ball : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8Ball(Magic8BallServices magic8BallServices){
            _magic8BallServices = magic8BallServices;
        }
    [HttpPost]
    [Route("magic8/userInput")]
    public List<string> YourQuestion(string userInput)
        {
            return _magic8BallServices.YourQuestion(userInput);
        }
    }
}