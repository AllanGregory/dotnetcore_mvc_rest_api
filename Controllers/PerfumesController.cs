using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Perfume.Data;
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

        //Injeção de dependência no construtor
        public PerfumesController(IPerfumeRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockPerfumeRepo _repository = new MockPerfumeRepo();
        
        //Action result se baseia no verbo que estamos chamando (get, post, put etc)
        //Aqui, no caso, está retornando uma lista de PerfumeModel
        //GET api/perfumes
        [HttpGet]
        public ActionResult <IEnumerable<PerfumeModel>> GetAllPerfumes()
        {
            var perfumeItems = _repository.GetAllPerfumes();
            
            return Ok(perfumeItems);
        }

        //GET api/perfumes/{id}
        [HttpGet("{id}")]
        public ActionResult <PerfumeModel> GetPerfumeById(int id)
        {
            var perfumeItem = _repository.GetPerfumeById(id);

            return Ok(perfumeItem);
        }
    }
}