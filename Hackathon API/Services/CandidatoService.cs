using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Services
{
    public class CandidatoService : ICandidatoService
    {
        public IEnumerable<Candidato> GetCandidatos()
        {
            var candidatos = new List<Candidato>();
            return candidatos;
        }
    }
}