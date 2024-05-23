using TemplateAPI.Domain.Entity;
using TemplateAPI.Domain.Service;
using TemplateAPI.Repository.ContextConfig;
using TemplateAPI.Repository.Repository.Base;

namespace TemplateAPI.Repository.Repository
{
    public class AreaConhecimentoRepository : RepositoryBase<AreaConhecimento>, IAreaConhecimentoRepository
    {
        public AreaConhecimentoRepository(TemplateDbContext options) : base(options)
        {

        }

        public List<AreaConhecimento> BuscarTodos()
        {
            try
            {
                return this._dbSet.ToList();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
