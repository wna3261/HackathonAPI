using System.Collections.Generic;
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
            var candidatos = _candidatoRepository.GetCandidatos().ToList();
            return candidatos;
        }

        public Candidato PostCandidato(Candidato candidato)
        {
            var candidatoDb = _candidatoRepository.PostCandidato(candidato);

            return candidatoDb;
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
    }
}