using TemplateAPI.Domain.Entity;
using TemplateAPI.Service.Dto;

namespace TemplateAPI.Service.Interfaces
{
    public interface IAreaConhecimentoService
    {
        List<AreaConhecimentoDto> BuscarTodos();
    }
}
