using System.ComponentModel.DataAnnotations;

namespace SolicitadorTCC.API.Model
{
    public class PessoaAutenticacaoViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }
    }
}
