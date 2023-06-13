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
    public class SolicitacaoController : ControllerBase
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;
        private readonly IMapper _mapper;

        public SolicitacaoController(ISolicitacaoRepository solicitacaoRepository, IMapper mapper)
        {
            _solicitacaoRepository = solicitacaoRepository;
            _mapper = mapper;
        }

        [Route("Cadastrar")]
        // /solicitacao/cadastrar
        [HttpPost]
        public IActionResult Post(SolicitacaoViewModel solicitacaoCreateViewModel)
        {
            _solicitacaoRepository.Cadastrar(_mapper.Map<Solicitacao>(solicitacaoCreateViewModel));
            return Ok();
        }

        [Route("BuscarPorId")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(new SolicitacaoViewModel());
        }
    }
}
