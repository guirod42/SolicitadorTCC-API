using System.ComponentModel.DataAnnotations;
using SolicitadorTCC.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace SolicitadorTCC.API.Model
{
    public class ProjetoViewModel
    {
        [SwaggerSchema(ReadOnly = true)]
        public int ProjetoID { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public int AlunoSolicitante_ID { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public int ProfessorOrientador_ID { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public int Curso_ID { get; set; }

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
        public EnumSituacaoProjeto Status { get; set; }
    }
}