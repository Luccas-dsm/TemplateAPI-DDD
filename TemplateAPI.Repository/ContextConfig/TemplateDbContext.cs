using Microsoft.EntityFrameworkCore;

namespace TemplateAPI.Repository.ContextConfig
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }
    }
}
