using SolicitadorTCC.Domain;
using SolicitadorTCC.API.Model;
using AutoMapper;

namespace SolicitadorTCC.API.Mapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Projeto, ProjetoViewModel>();
            CreateMap<Solicitacao, SolicitacaoViewModel>();
            CreateMap<Tarefa, TarefaViewModel>();
        }
    }
}
