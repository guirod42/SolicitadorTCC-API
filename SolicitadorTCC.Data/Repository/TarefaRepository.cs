﻿using SolicitadorTCC.Domain;
using SolicitadorTCC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Data.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly GestaoTarefaContext _context;
        public TarefaRepository(GestaoTarefaContext context)
        {
            _context = context;
        }

        public Tarefa Cadastrar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}
