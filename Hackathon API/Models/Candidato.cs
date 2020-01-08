using System;
using System.ComponentModel.DataAnnotations;

namespace Hackathon_API.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public double Nota { get; set; }
        public bool Situacao { get; set; }
    }
}