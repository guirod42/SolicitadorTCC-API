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

        [Route("Cadastrar")]
        // /pessoa/cadastrar
        [HttpPost]
        public IActionResult Post(PessoaCreateViewModel pessoaCreateViewModel)
        {
            _pessoaRepository.Cadastrar(_mapper.Map<Pessoa>(pessoaCreateViewModel));
            return Ok();
        }

        [Route("BuscarPorId")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(new PessoaViewModel());
        }

        [Route("Autenticar")]
        [HttpPost]
        public IActionResult Post(PessoaAutenticacaoViewModel pessoaAutenticacaoViewModel)
        {
            //verificar no BD etc
            //return NotFound();

            return Ok();
        }
    }
}
