using SolicitadorTCC.Domain;
using SolicitadorTCC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Data.Repository
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {
        private readonly GestaoContext _context;
        public SolicitacaoRepository(GestaoContext context)
        {
            _context = context;
        }

        public Solicitacao Cadastrar(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }
    }
}
