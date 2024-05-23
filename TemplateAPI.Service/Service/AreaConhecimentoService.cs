using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateAPI.Domain.Service;
using TemplateAPI.Service.Dto;
using TemplateAPI.Service.Interfaces;

namespace TemplateAPI.Service.Service
{
    public class AreaConhecimentoService : IAreaConhecimentoService
    {
        private readonly IAreaConhecimentoRepository _areaConhecimentoRepository;
        private readonly IMapper _mapper;

        public AreaConhecimentoService(IAreaConhecimentoRepository areaConhecimentoRepository, IMapper mapper)
        {
            this._areaConhecimentoRepository = areaConhecimentoRepository;
            this._mapper = mapper;
        }


        public  List<AreaConhecimentoDto> BuscarTodos()
        {
            return _mapper.Map<List<AreaConhecimentoDto>>(_areaConhecimentoRepository.BuscarTodos());
        }
    }
}
