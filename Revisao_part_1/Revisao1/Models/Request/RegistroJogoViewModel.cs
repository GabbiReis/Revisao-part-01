using Revisao1.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Revisao1.Models.Request
{
    public class RegistroJogoViewModel
    {
        [Required(ErrorMessage = "O Nome é obrigatória.")]
        [MinLength(3, ErrorMessage = "O Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [CpfValidation(ErrorMessage = "CPF inválido.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int PrimeiroNumero { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int SegundoNumero { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int TerceiroNumero { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int QuartoNumero { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int QuintoNumero { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [Range(1, 60, ErrorMessage = "O Número deve ser entre 1 e 60.")]
        public int SextoNumero { get; set; }

        [JsonIgnore]
        public DateTime DataJogo { get; set; }
    }
}
