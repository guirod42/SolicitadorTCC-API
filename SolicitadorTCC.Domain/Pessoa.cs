using SolicitadorTCC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain
{
    public class Pessoa
    {
        protected Pessoa()
        {

        }
        public Pessoa(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public Pessoa(string Nome, string Email, string Usuario, string Senha, EnumTipoPessoa TipoPessoa_ID, DateTime dataCadastro)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.TipoPessoa_ID = TipoPessoa_ID;
        }

        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Status { get; set; }
        public EnumTipoPessoa TipoPessoa_ID { get; set; }
    }
}
