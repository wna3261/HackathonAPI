using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Services
{
    public interface ICandidatoService
    {
        IEnumerable<Candidato> GetCandidatos();
    }
}