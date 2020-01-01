using Microsoft.AspNetCore.Mvc;

namespace Hackathon_API.Controllers
{
    [ApiController]
    [Route("candidatos")]
    public class CandidatosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCandidatos()
        {
            return Ok();
        }

        [HttpGet("{idCandidato}")]
        public IActionResult GetCandidatos(int idCandidato)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult RegisterCandidato()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCandidato()
        {
            return Ok();
        }

        [HttpDelete("{idCandidato}")]
        public IActionResult DeleteCandidatos(int idCandidato)
        {
            return Ok();
        }
    }
}