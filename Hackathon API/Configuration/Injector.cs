using FluentValidation;
using Hackathon_API.Data;
using Hackathon_API.Data.Repositories;
using Hackathon_API.Data.Repositories.Interfaces;
using Hackathon_API.FluentValidation;
using Hackathon_API.Services;
using Hackathon_API.Services.Interfaces;
using Hackathon_API.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Hackathon_API.Configuration
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            services.AddTransient<IValidator<CandidatoViewModel>, CandidatoValidator>();

            // services
            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddScoped<IConcursoService, ConcursoService>();

            // repositories
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();
            services.AddScoped<IConcursoRepository, ConcursoRepository>();
        }
    }
}