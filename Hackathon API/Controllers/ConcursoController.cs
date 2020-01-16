using System;
using Hackathon_API.Models;
using Hackathon_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConcursoController : ControllerBase
    {
        private readonly IConcursoService _concursoService;

        public ConcursoController(IConcursoService concursoService)
        {
            _concursoService = concursoService;
        }

        [HttpGet]
        public IActionResult GetConcursos()
        {
            try
            {
                return Ok(_concursoService.GetConcursos());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{idConcurso}")]
        public IActionResult GetConcurso(int idConcurso)
        {
            try
            {
                var concurso = _concursoService.GetConcurso(idConcurso);
                return Ok(concurso);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult PostConcurso([FromBody]Concurso concurso)
        {
            try
            {
                var result = _concursoService.PostConcurso(concurso);
                if (result != null)
                {
                    return Created("/candidatos", result);
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public IActionResult PutConcurso([FromBody]Concurso concurso)
        {
            try
            {
                var result = _concursoService.PutConcurso(concurso);
                if (result != null)
                    return NoContent();

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{idConcurso}")]
        public IActionResult DeleteConcurso(int idConcurso)
        {
            try
            {
                _concursoService.DeleteConcurso(idConcurso);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("candidatosConcurso")]
        public IActionResult CandidatosConcurso()
        {
            try
            {
                return Ok(_concursoService.GetCandidatosConcurso());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPatch("{numVagas}")]
        public IActionResult UpdateVagas(int numVagas)
        {
            try
            {
                _concursoService.UpdateVagas(numVagas);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
