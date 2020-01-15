using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon_API.Data.Repositories.Interfaces;
using Hackathon_API.Models;

namespace Hackathon_API.Data.Repositories
{
    public class ConcursoRepository : IConcursoRepository
    {
        private readonly DataContext _dbcontext;

        public ConcursoRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Concurso> GetConcursos()
        {
            return _dbcontext.Concursos;
        }

        public Concurso GetConcurso(int idConcurso)
        {
            var concurso = _dbcontext.Concursos.FirstOrDefault(x => x.Id == idConcurso);
            return concurso;
        }

        public Concurso PostConcurso(Concurso concurso)
        {
            _dbcontext.Concursos.Add(concurso);
            _dbcontext.SaveChanges();
            return concurso;
        }

        public void DeleteConcurso(int idConcurso)
        {
            var concurso = _dbcontext.Concursos.FirstOrDefault(x => x.Id == idConcurso);
            if (concurso == null) return;
            _dbcontext.Concursos.Remove(concurso);
            _dbcontext.SaveChanges();
        }

        public Concurso PutConcurso(Concurso concurso)
        {
            _dbcontext.Concursos.Update(concurso);
            _dbcontext.SaveChanges();

            return concurso;
        }

        public IEnumerable<Candidato> GetCandidatosConcurso()
        {
            return _dbcontext.Candidatos.Where(x => x.ConcursoId == 1);
        }
    }
}
