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
        }
    }
}
