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
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IMapper _mapper;

        public ProjetoController(IProjetoRepository projetoRepository, IMapper mapper)
        {
            _projetoRepository = projetoRepository;
            _mapper = mapper;
        }

        [Route("Cadastrar")]
        // /projeto/cadastrar
        [HttpPost]
        public IActionResult Post(ProjetoViewModel projetoCreateViewModel)
        {
            _projetoRepository.Cadastrar(_mapper.Map<Projeto>(projetoCreateViewModel));
            return Ok();
        }

        [Route("BuscarPorId")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(new ProjetoViewModel());
        }
    }
}
