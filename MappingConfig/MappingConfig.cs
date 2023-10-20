using AutoMapper;
using MagicVilla.Modelos;
using MagicVilla.Modelos.DTOs;

namespace MagicVilla.MappingConfig
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTOs>();
            CreateMap<VillaDTOs, Villa>();

            CreateMap<Villa, VillaCreacionDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<NumeroVilla, NumeroVillaDto>();
            CreateMap<NumeroVilla, NumeroVillaCreateDto>().ReverseMap();
            CreateMap<NumeroVilla, NumeroVillaUpdateDto>().ReverseMap();
        }
    }
}
