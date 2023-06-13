using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain
{
    public class Tarefa
    {
        public Tarefa(int tarefaID, int projeto_ID, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, DateTime dataPrazo, int status)
        {
            TarefaID = tarefaID;
            Projeto_ID = projeto_ID;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataPrazo = dataPrazo;
            Status = status;
        }

        public int TarefaID { get; set; }
        public int Projeto_ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataPrazo { get; set; }
        public int Status { get; set; }
    }
}
