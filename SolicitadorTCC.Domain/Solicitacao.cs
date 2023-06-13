using SolicitadorTCC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitadorTCC.Domain
{
    public class Solicitacao
    {
        public Solicitacao(int solicitacaoID, int alunoSolicitante_ID, int professorOrientador_ID, int curso_ID, string titulo, string descricao, DateTime dataSolicitacao, DateTime dataResposta, string justificativa, int status)
        {
            SolicitacaoID = solicitacaoID;
            AlunoSolicitante_ID = alunoSolicitante_ID;
            ProfessorOrientador_ID = professorOrientador_ID;
            Curso_ID = curso_ID;
            Titulo = titulo;
            Descricao = descricao;
            DataSolicitacao = dataSolicitacao;
            DataResposta = dataResposta;
            Justificativa = justificativa;
            Status = status;
        }

        public int SolicitacaoID { get; set; }
        public int AlunoSolicitante_ID { get; set; }
        public int ProfessorOrientador_ID { get; set; }
        public int Curso_ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataResposta { get; set; }
        public string Justificativa { get; set; }
        public int Status { get; set; }
    }
}
