﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        public Tarefa Cadastrar(Tarefa tarefa);
    }
}
