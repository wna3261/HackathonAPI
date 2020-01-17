using System.Collections.Generic;
using Hackathon_API.Models;
using Hackathon_API.ViewModels;

namespace Hackathon_API.Services
{
    public interface ICandidatoService
    {
        IEnumerable<CandidatoViewModel> GetCandidatos();
        CandidatoViewModel PostCandidato(CandidatoViewModel candidatoViewModel);
        CandidatoViewModel GetCandidato(int idCandidato);
        void DeleteCandidato(int idCandidato);
        bool PutCandidato(CandidatoViewModel candidatoViewModel);
        void ExibirResultados(int numVagas);
    }
}