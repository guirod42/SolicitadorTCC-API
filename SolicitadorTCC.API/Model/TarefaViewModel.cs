using System.ComponentModel.DataAnnotations;
using SolicitadorTCC.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace SolicitadorTCC.API.Model
{
    public class TarefaViewModel
    {
        [SwaggerSchema(ReadOnly = true)]
        public int TarefaID { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public int Projeto_ID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataPrazo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Status { get; set; }
    }
}