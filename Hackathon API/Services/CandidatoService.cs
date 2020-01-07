using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Hackathon_API.Data.Repositories;
using Hackathon_API.Models;

namespace Hackathon_API.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            var candidatos = _candidatoRepository.GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            return candidatos;
        }

        public Candidato PostCandidato(Candidato candidato)
        {
            if (candidato != null)
            {
                if (candidato.Nota >= 0 && candidato.Nota <= 100
                    && !candidato.Nome.Any(char.IsDigit) && !candidato.Cidade.Any(char.IsDigit))
                {
                    var candidatoDb = _candidatoRepository.PostCandidato(candidato);

                    return candidatoDb;
                }
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

        public void PutCandidato(Candidato candidato)
        {
            if (candidato == null) return;
            if (candidato.Nota >= 0 && candidato.Nota <= 100 
                && !candidato.Nome.Any(char.IsDigit) && !candidato.Cidade.Any(char.IsDigit))
            {
                _candidatoRepository.PutCandidato(candidato);
            }
        }

        private void PutCandidatos(IEnumerable<Candidato> candidatos)
        {
            _candidatoRepository.PutCandidatos(candidatos);
        }

        public void ExibirResultados(int numVagas)
        {
            var candidatos = GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            foreach (var candidato in candidatos)
            {
                if (candidato.Nota > 0 && numVagas > 0)
                {
                    candidato.Situacao = true;
                    numVagas--;
                }
                else if (numVagas == 0)
                {
                    candidato.Situacao = false;
                }
                // PutCandidato(candidato);
            }

            PutCandidatos(candidatos);
        }
    }
}