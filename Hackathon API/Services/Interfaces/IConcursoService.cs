using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Services.Interfaces
{
    public interface IConcursoService
    {
        IEnumerable<Concurso> GetConcursos();
        Concurso PostConcurso(Concurso concurso);
        Concurso GetConcurso(int idConcurso);
        void DeleteConcurso(int idConcurso);
        Concurso PutConcurso(Concurso concurso);
        IEnumerable<Candidato> GetCandidatosConcurso();
    }
}
