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
    public class ReverseIt : ControllerBase
    {
         private readonly ReverseItAlphaNumericalServices _reverseItAlphaNumericalServices;
        private readonly ReverseItNumbersOnlyServices _reverseItNumbersOnlyServices;
        public ReverseIt(ReverseItAlphaNumericalServices reverseItAlphanumericalServices, ReverseItNumbersOnlyServices reverseItNumbersOnlyServices){
            _reverseItAlphaNumericalServices = reverseItAlphanumericalServices;
            _reverseItNumbersOnlyServices = reverseItNumbersOnlyServices;
        }
        [HttpPost]
        [Route("reversedWord/{userInput}")]
         public List<string> ReversedWord(string userInput){
            return _reverseItAlphaNumericalServices.ReversedString(userInput);
         }
         [HttpPost]
        [Route("reversedNum/{userInput}")]
         public List<string> ReversedNum(string userInput){
            return _reverseItNumbersOnlyServices.ReversedNum(userInput);
         }
    }
}