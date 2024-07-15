using Microsoft.EntityFrameworkCore;
using TemplateAPI.Domain.Interface.Entity;

namespace TemplateAPI.Repository.Repository.Base
{
    public class RepositoryBase<TEntity> where TEntity : class, IEntityBase
    {

        //private readonly MeuDbContext context;
        public DbSet<TEntity> _dbSet;

        //public RepositoryBase(MeuDbContext context)
        //{
        //   // this.context = context;
        //    _dbSet = context.Set<TEntity>();
        //}


        public void Save()
        {
           // context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            try
            {
                //var existingEntity = _dbSet.Find(entity.Id);

                //if (existingEntity != null)
                //{
                //    //context.Entry(existingEntity).CurrentValues.SetValues(entity);
                //    //context.Update(entity);
                //    this.Save();
                //}

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o registro." + ex.Message);
            }
        }
    }
}
