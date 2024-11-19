using AutoMapper;
using Persona.Domain.Dto;
using Persona.Domain.Entities.Persona;

namespace Persona.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Entities.Persona.Persona,PostCreatePersonaRequest>().ReverseMap();
        }
    }
}
