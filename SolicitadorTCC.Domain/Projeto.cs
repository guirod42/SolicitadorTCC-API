using SolicitadorTCC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain
{
    public class Projeto
    {
        public Projeto(int projetoID, int alunoSolicitante_ID, int professorOrientador_ID, int curso_ID, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, DateTime dataPrazo, EnumSituacaoProjeto status)
        {
            ProjetoID = projetoID;
            AlunoSolicitante_ID = alunoSolicitante_ID;
            ProfessorOrientador_ID = professorOrientador_ID;
            Curso_ID = curso_ID;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataPrazo = dataPrazo;
            Status = status;
        }

        public int ProjetoID { get; set; }
        public int AlunoSolicitante_ID { get; set; }
        public int ProfessorOrientador_ID { get; set; }
        public int Curso_ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataPrazo { get; set; }
        public EnumSituacaoProjeto Status { get; set; }
    }
}
