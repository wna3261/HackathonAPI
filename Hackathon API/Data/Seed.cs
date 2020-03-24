using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon_API.Models;

namespace Hackathon_API.Data
{
    public class Seed
    {
        public static void SeedConcurso(DataContext context)
        {
            if (!context.Concursos.Any())
            {
                var concurso = new Concurso
                {
                    Id = 0,
                    Nome = "Enem",
                    NumeroVagas = 15
                };
                context.Concursos.Add(concurso);

                context.SaveChanges();
            }
        }
    }
}

