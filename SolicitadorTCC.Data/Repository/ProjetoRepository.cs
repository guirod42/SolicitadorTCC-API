using SolicitadorTCC.Domain;
using SolicitadorTCC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Data.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly GestaoContext _context;
        public ProjetoRepository(GestaoContext context)
        {
            _context = context;
        }

        public Projeto Cadastrar(Projeto projeto)
        {
            throw new NotImplementedException();
        }
    }
}
