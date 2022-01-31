using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/auto")]
    public class MuestraSuma: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Calculo>> Get()
        {
            return new List<Calculo>()
            {
                new Calculo() {num1 = 1, num2 = 2},
                new Calculo() { num1 = 2, num2 = 3},
            };
        }
    }
}
