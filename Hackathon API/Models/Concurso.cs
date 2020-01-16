using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hackathon_API.Models
{
    public class Concurso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "O numero de vagas não pode estar vazio")]
        public int NumeroVagas { get; set; }
        public DateTime DataConcurso { get; set; }
        public IEnumerable<Candidato> Candidatos { get; set; }

        public Concurso()
        {
            Candidatos = new List<Candidato>();
        }
    }
}
