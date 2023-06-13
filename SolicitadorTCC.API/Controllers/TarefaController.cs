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
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public TarefaController(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        [Route("Cadastrar")]
        // /tarefa/cadastrar
        [HttpPost]
        public IActionResult Post(TarefaViewModel tarefaCreateViewModel)
        {
            _tarefaRepository.Cadastrar(_mapper.Map<Tarefa>(tarefaCreateViewModel));
            return Ok();
        }

        [Route("BuscarPorId")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(new TarefaViewModel());
        }
    }
}
