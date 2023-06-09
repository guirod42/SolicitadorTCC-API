﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        public Pessoa Autenticar(Pessoa pessoa);
        public void Cadastrar(Pessoa pessoa);
        public void Atualizar(Pessoa pessoa);
        public Pessoa BuscarPessoaID(int PessoaID);
    }
}
