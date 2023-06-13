using SolicitadorTCC.Domain;
using SolicitadorTCC.API.Model;
using AutoMapper;

namespace SolicitadorTCC.API.Mapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {
            CreateMap<PessoaViewModel, Pessoa>()
                .ConstructUsing(f => new Pessoa(f.Nome, f.Email, f.Usuario, f.Senha, f.TipoPessoa_ID));
            CreateMap<PessoaCreateViewModel, Pessoa>()
               .ConstructUsing(f => new Pessoa(f.Nome, f.Email, f.Usuario, f.Senha, f.TipoPessoa_ID));

            CreateMap<ProjetoViewModel, Projeto>()
                .ConstructUsing(f => new Projeto(f.ProjetoID,f.AlunoSolicitante_ID, f.ProfessorOrientador_ID, f.Curso_ID, f.Titulo, f.Descricao, f.DataInicio, f.DataFim, f.DataPrazo, f.Status));

            CreateMap<SolicitacaoViewModel, Solicitacao>()
                .ConstructUsing(f => new Solicitacao(f.SolicitacaoID, f.AlunoSolicitante_ID, f.ProfessorOrientador_ID, f.Curso_ID, f.Titulo, f.Descricao, f.DataSolicitacao, f.DataResposta, f.Justificativa, f.Status ));

            CreateMap<TarefaViewModel, Tarefa>()
                .ConstructUsing(f => new Tarefa(f.TarefaID, f.Projeto_ID, f.Titulo, f.Descricao, f.DataInicio, f.DataFim, f.DataPrazo, f.Status));
        }
    }
}
