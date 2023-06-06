using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolicitadorTCC.Domain.Models;

namespace SolicitadorTCC.Domain.Interfaces
{
    public class IPessoaRepository
    {
        public Pessoa Autenticar(Pessoa pessoa);
    }
}
