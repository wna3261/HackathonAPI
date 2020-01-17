using AutoMapper;
using Hackathon_API.Models;
using Hackathon_API.ViewModels;

namespace Hackathon_API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Candidato, CandidatoViewModel>();
        }
    }
}
