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
    public class AddingTwoNumbers : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;
        public AddingTwoNumbers(AddingTwoNumbersServices addingTwoNumbersServices){
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }
        [HttpPost]
        [Route("addNumber/{numberOne}/{numberTwo}")]
        public List<string> AddNumbers(string numberOne, string numberTwo){
            return _addingTwoNumbersServices.AddNumbers(numberOne, numberTwo);
        }
    }
}