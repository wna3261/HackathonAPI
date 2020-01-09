using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Hackathon_API.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O campo Nome deve ter no minimo 3 caracteres.")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Nota é obrigatório.")]
        public double Nota { get; set; }
        public bool Situacao { get; set; }
    }
}