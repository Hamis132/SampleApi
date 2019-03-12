using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;

namespace SampleApi.Controllers
{
    public class FizzBuzzController : Controller
    {
        public FizzBuzzController()
        {

        }

        [HttpPost("/api/modulo35")]
        public async Task<IActionResult> ModuloResult([FromBody] ModuloModel model)
        {
            try
            {
                if (model.Number % 3 == 0 && model.Number % 5 == 0)
                {
                    return Ok(new ModuloResult { Answer = "fizzbuzz" });
                }
                else if (model.Number % 3 == 0)
                {
                    return Ok(new ModuloResult { Answer = "fizz" });
                }
                else if (model.Number % 5 == 0)
                {
                    return Ok(new ModuloResult { Answer = "buzz" });
                }
                else
                {
                    return Ok(model);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorModel { Error = ex.Message });
            }
        }
    }
}
