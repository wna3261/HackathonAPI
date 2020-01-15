using System;
using System.Collections.Generic;

namespace Hackathon_API.Models
{
    public class Concurso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroVagas { get; set; }
        public DateTime DataConcurso { get; set; }
        public IEnumerable<Candidato> Candidatos { get; set; }

        public Concurso()
        {
            Candidatos = new List<Candidato>();
        }
    }
}
