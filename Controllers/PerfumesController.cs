using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Perfume.Data;
using Perfume.Dtos;
using Perfume.Models;

namespace Perfume.Controller
{
    //api/comandos
    [Route("api/[controller]")] //Route serve para definir como chegar nos endpoints da controller
    //Usar [controller] permite que, se o nome da classe mudar, a rota muda junto
    //Poderia ser api/[perfumes], mas se a classe mudasse o nome, a rota não mudaria junto
    [ApiController] //Para que a controller adote os comportamentos de um Controller
    public class PerfumesController : ControllerBase //Herança da ControllerBase da lib MVC da Microsoft, pois não temos uma camada de View
    {
        private readonly IPerfumeRepo _repository;
        private readonly IMapper _mapper;

        //Injeção de dependência no construtor
        public PerfumesController(IPerfumeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockPerfumeRepo _repository = new MockPerfumeRepo();
        
        //Action result se baseia no verbo que estamos chamando (get, post, put etc)
        //Aqui, no caso, está retornando uma lista de PerfumeModel
        //GET api/perfumes
        [HttpGet]
        public ActionResult <IEnumerable<PerfumeReadDto>> GetAllPerfumes()
        {
            var perfumeItems = _repository.GetAllPerfumes();
            
            //Retornando o tipo DTO, fazendo mapeamento do perfumeItem
            //Isso para transformar o retorno do nosso repositório
            //em um retorno do DTO para o cliente
            return Ok(_mapper.Map<IEnumerable<PerfumeReadDto>>(perfumeItems));
        }

        //GET api/perfumes/{id}
        [HttpGet("{id}", Name="GetPerfumeById")]
        public ActionResult <PerfumeReadDto> GetPerfumeById(int id)
        {
            var perfumeItem = _repository.GetPerfumeById(id);

            if (perfumeItem != null)
            {
                //Retornando o tipo DTO, fazendo mapeamento do perfumeItem
                //Isso para transformar o retorno do nosso repositório
                //em um retorno do DTO para o cliente
                return Ok(_mapper.Map<PerfumeReadDto>(perfumeItem));
            }

            return NotFound();
        }

        //POST api/perfumes
        [HttpPost]
        public ActionResult <PerfumeReadDto> CreatePerfume(PerfumeCreateDto perfumeCreateDto)
        {
            var perfumeModel = _mapper.Map<PerfumeModel>(perfumeCreateDto);
            _repository.CreatePerfume(perfumeModel);
            _repository.SaveChanges(); //Cria de fato o objeto no BD

            var perfumeReadDto = _mapper.Map<PerfumeReadDto>(perfumeModel);

            //RouteName, RouteValues, Content do body
            return CreatedAtRoute(nameof(GetPerfumeById), new {Id = perfumeReadDto.Id}, perfumeReadDto);
        }
    }
}