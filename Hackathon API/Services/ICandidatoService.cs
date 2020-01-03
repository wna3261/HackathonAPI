using System.Collections.Generic;
using Hackathon_API.Models;

namespace Hackathon_API.Services
{
    public interface ICandidatoService
    {
        IEnumerable<Candidato> GetCandidatos();
        Candidato PostCandidato(Candidato candidato);
        Candidato GetCandidato(int idCandidato);
        void DeleteCandidato(int idCandidato);
        void PutCandidato(Candidato candidato);
        void ExibirResultados(int numVagas);
    }
}