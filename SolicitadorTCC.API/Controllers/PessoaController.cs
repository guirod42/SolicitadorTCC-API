using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolicitadorTCC.API.Model;
using SolicitadorTCC.Data.Repository;
using SolicitadorTCC.Domain;
using SolicitadorTCC.Domain.Interfaces;

namespace SolicitadorTCC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaController(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;           
        }

        [HttpGet(Name = "BuscarPorId")]
        public IActionResult Get(int id)
        {

            return Ok(new PessoaViewModel());
        }
        // /pessoa/cadastrar
        [HttpPost(Name = "Cadastrar")]
        public IActionResult Post(PessoaCreateViewModel pessoaCreateViewModel)
        {
            _pessoaRepository.Cadastrar(_mapper.Map<Pessoa>(pessoaCreateViewModel));
            return Ok();
        }

        [HttpPost(Name = "Autenticar")]
        public IActionResult Post(PessoaAutenticacaoViewModel pessoaAutenticacaoViewModel)
        {
            //verificar no BD etc ]
            //return NotFound();

            return Ok();
        }
    }
}
