using AutoMapper;
using Hackathon_API.Models;
using Hackathon_API.ViewModels;

namespace Hackathon_API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CandidatoViewModel, Candidato>();
        }
    }
}
