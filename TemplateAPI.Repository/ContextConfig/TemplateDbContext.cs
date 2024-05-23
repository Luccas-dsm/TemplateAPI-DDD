using Microsoft.EntityFrameworkCore;
using TemplateAPI.Domain.Entity;

namespace TemplateAPI.Repository.ContextConfig
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaConhecimento>().ToTable("area_conhecimento");

            base.OnModelCreating(modelBuilder);
        }
    }
}
