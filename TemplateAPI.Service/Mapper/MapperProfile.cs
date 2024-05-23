using AutoMapper;
using TemplateAPI.Domain.Entity;
using TemplateAPI.Service.Dto;

namespace TemplateAPI.Service.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            this.CreateMap<AreaConhecimento, AreaConhecimentoDto>();
            this.CreateMap<AreaConhecimentoDto, AreaConhecimento>();
        }
    }
}
