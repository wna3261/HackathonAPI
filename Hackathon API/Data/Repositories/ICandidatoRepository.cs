using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Data.Repositories
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetCandidatos();
    }
}