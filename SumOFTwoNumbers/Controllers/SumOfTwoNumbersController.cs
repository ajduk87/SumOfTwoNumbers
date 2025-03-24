using Microsoft.AspNetCore.Mvc;

namespace SumOFTwoNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumOfTwoNumbersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SumOfTwoNumbersController> _logger;

        public SumOfTwoNumbersController(ILogger<SumOfTwoNumbersController> logger)
        {
            _logger = logger;
        }

  


        [HttpGet(Name = "GetSumOfTwoNumbers")]
        public int GetSumOfTwoNumbers(int num1, int num2)
        {
            return num1 + num2  ;
        }
    }
}
