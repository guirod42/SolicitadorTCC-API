using SolicitadorTCC.Domain;
using SolicitadorTCC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Data.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly GestaoContext _context;
        public PessoaRepository(GestaoContext context)
        {
            _context = context;
        }
        public Pessoa Autenticar(Pessoa pessoa)
        {
            var buscaUsuario = _context.Pessoa.Where(p => p.Usuario == pessoa.Usuario
                                               && p.Senha == pessoa.Senha).FirstOrDefault();
            if (buscaUsuario != null) return new Pessoa(pessoa.Nome, pessoa.Email, pessoa.Usuario, pessoa.Senha, pessoa.TipoPessoa_ID);
            return _context.Pessoa.Where(p => p.Usuario == pessoa.Usuario
                && p.Senha == pessoa.Senha).FirstOrDefault();

            /*public Pessoa(string Nome, string Email, string Usuario, string Senha, EnumTipoPessoa TipoPessoa_ID)*/
        }

        public Pessoa Cadastrar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
