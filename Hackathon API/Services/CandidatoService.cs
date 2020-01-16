using System.Collections.Generic;
using System.Linq;
using Hackathon_API.Data.Repositories;
using Hackathon_API.Data.Repositories.Interfaces;
using Hackathon_API.Models;
using Hackathon_API.Services.Interfaces;

namespace Hackathon_API.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IConcursoService _concursoService;

        public CandidatoService(ICandidatoRepository candidatoRepository, IConcursoService concursoService)
        {
            _candidatoRepository = candidatoRepository;
            _concursoService = concursoService;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            var concursos = _concursoService.GetConcursos();
            ExibirResultados(concursos.ElementAt(0).NumeroVagas);
            var candidatos = _candidatoRepository.GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            return candidatos;
        }

        public Candidato PostCandidato(Candidato candidato)
        {
            if (candidato == null) return null;
            if (candidato.Nota >= 0 && candidato.Nota <= 100 && !candidato.Nome.Contains("  ") && !candidato.Cidade.Contains("  "))
            {
                var candidatoDb = _candidatoRepository.PostCandidato(candidato);

                return candidatoDb;
            }
            return null;
        }

        public Candidato GetCandidato(int idCandidato)
        {
            var candidato = _candidatoRepository.GetCandidato(idCandidato);

            return candidato;
        }

        public void DeleteCandidato(int idCandidato)
        {
            _candidatoRepository.DeleteCandidato(idCandidato);
        }

        public bool PutCandidato(Candidato candidato)
        {
            if (candidato == null) return false;
            if (candidato.Nota >= 0 && candidato.Nota <= 100 && !candidato.Nome.Contains("  ") && !candidato.Cidade.Contains("  "))
            {
                _candidatoRepository.PutCandidato(candidato);
                return true;
            }

            return false;
        }

        private void PutCandidatos(IEnumerable<Candidato> candidatos)
        {
            _candidatoRepository.PutCandidatos(candidatos);
        }

        public void ExibirResultados(int numVagas)
        {
            var candidatos = _candidatoRepository.GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            //var candidatos = GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            foreach (var candidato in candidatos)
            {
                if (candidato.Nota > 0 && numVagas > 0)
                {
                    candidato.Situacao = true;
                    numVagas--;
                }
                else if (numVagas == 0 || candidato.Nota.Equals(0.0))
                {
                    candidato.Situacao = false;
                }
            }
            PutCandidatos(candidatos);
        }
    }
}