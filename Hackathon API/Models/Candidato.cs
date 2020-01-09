using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Hackathon_API.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3,ErrorMessage = "O campo nome deve ter no minimo 3 caracteres")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public double Nota { get; set; }
        public bool Situacao { get; set; }
    }
}