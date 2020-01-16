using System.Collections.Generic;
using System.Linq;
using Hackathon_API.Data.Repositories.Interfaces;
using Hackathon_API.Models;
using Hackathon_API.Services.Interfaces;

namespace Hackathon_API.Services
{
    public class ConcursoService : IConcursoService
    {
        private readonly IConcursoRepository _concursoRepository;

        public ConcursoService(IConcursoRepository concursoRepository)
        {
            _concursoRepository = concursoRepository;
        }

        public IEnumerable<Concurso> GetConcursos()
        {
            var concursos = _concursoRepository.GetConcursos().ToList();
            return concursos;
        }

        public Concurso GetConcurso(int idConcurso)
        {
            var concurso = _concursoRepository.GetConcurso(idConcurso);
            return concurso;
        }

        public Concurso PostConcurso(Concurso concurso)
        {
            if (concurso == null) return null;
            var concursoResult = _concursoRepository.PostConcurso(concurso);
            return concursoResult;

        }

        public void DeleteConcurso(int idConcurso)
        {
            _concursoRepository.DeleteConcurso(idConcurso);
        }

        public Concurso PutConcurso(Concurso concurso)
        {
            if (concurso == null) return null;
            _concursoRepository.PutConcurso(concurso);
            return concurso;
        }

        public IEnumerable<Candidato> GetCandidatosConcurso()
        {
            var candidatos = _concursoRepository.GetCandidatosConcurso().ToList();
            return candidatos;
        }

        public void UpdateVagas(int numVagas)
        {
            _concursoRepository.UpdateVagas(numVagas);
        }
    }
}
