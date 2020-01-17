using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Hackathon_API.Data.Repositories;
using Hackathon_API.Models;
using Hackathon_API.Services.Interfaces;
using Hackathon_API.ViewModels;

namespace Hackathon_API.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IConcursoService _concursoService;
        private readonly IMapper _mapper;

        public CandidatoService(ICandidatoRepository candidatoRepository, IConcursoService concursoService, IMapper mapper)
        {
            _candidatoRepository = candidatoRepository;
            _concursoService = concursoService;
            _mapper = mapper;
        }

        public IEnumerable<CandidatoViewModel> GetCandidatos()
        {
            var concursos = _concursoService.GetConcursos();
            ExibirResultados(concursos.ElementAt(0).NumeroVagas);
            var candidatos = _candidatoRepository.GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            var candidatosVm = _mapper.Map<IEnumerable<CandidatoViewModel>>(candidatos).ToList();
            return candidatosVm;
        }

        public CandidatoViewModel PostCandidato(CandidatoViewModel candidatoViewModel)
        {
            var candidato = _mapper.Map<Candidato>(candidatoViewModel);
            if (candidato == null) return null;
            if (candidato.Nota >= 0 && candidato.Nota <= 100 && !candidato.Nome.Contains("  ") && !candidato.Cidade.Contains("  "))
            {
                candidato = _candidatoRepository.PostCandidato(candidato);
                candidatoViewModel = _mapper.Map<CandidatoViewModel>(candidato);
                return candidatoViewModel;
            }
            return null;
        }

        public CandidatoViewModel GetCandidato(int idCandidato)
        {
            var candidato = _candidatoRepository.GetCandidato(idCandidato);
            var candidatoViewModel = _mapper.Map<CandidatoViewModel>(candidato);

            return candidatoViewModel;
        }

        public void DeleteCandidato(int idCandidato)
        {
            _candidatoRepository.DeleteCandidato(idCandidato);
        }

        public bool PutCandidato(CandidatoViewModel candidatoViewModel)
        {
            var candidato = _mapper.Map<Candidato>(candidatoViewModel);
            candidato.ConcursoId = _concursoService.GetConcursos().FirstOrDefault()?.Id;
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