using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Data.Repositories.Interfaces
{
    public interface IConcursoRepository
    {
        IEnumerable<Concurso> GetConcursos();
        Concurso PostConcurso(Concurso concurso);
        Concurso GetConcurso(int idConcurso);
        void DeleteConcurso(int idConcurso);
        Concurso PutConcurso(Concurso concurso);
        IEnumerable<Candidato> GetCandidatosConcurso();
    }
}
