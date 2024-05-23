using TemplateAPI.Domain.Entity;

namespace TemplateAPI.Domain.Service
{
    public interface IAreaConhecimentoRepository
    {
        List<AreaConhecimento> BuscarTodos();
    }
}
