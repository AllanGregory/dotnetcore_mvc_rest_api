using AutoMapper;
using Perfume.Dtos;
using Perfume.Models;

namespace Perfume.Profiles
{
    public class PerfumesProfile : Profile
    {
        public PerfumesProfile()
        {
            //Criando mapeamento de uma model para o DTO
            //CreateMap<FROM, TO>
            CreateMap<PerfumeModel, PerfumeReadDto>();
        }
    }
}