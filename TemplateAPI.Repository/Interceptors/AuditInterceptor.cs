using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TemplateAPI.Domain.Entity.Base;

namespace TemplateAPI.Repository.Interceptors
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        //Faça a injeção de dependência do usuário logado.
        public AuditInterceptor()
        {

        }

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            try
            {
                if (eventData.Context is DbContext context)
                {
                    var entries = context.ChangeTracker.Entries()
                        .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified).ToList();

                    foreach (var entry in entries)
                    {
                        if (entry.Entity is EntityBase auditableEntity)
                        {
                            if (entry.State == EntityState.Added)
                            {
                                //auditableEntity.UsuarioInclusao = userId;
                                //auditableEntity.DataInclusao = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
                            }
                            else if (entry.State == EntityState.Modified)
                            {
                                //auditableEntity.UsuarioAlteracao = userId;
                                //auditableEntity.DataAlteracao = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

                                // Ignorar a atualização do campo UsuarioInclusao
                                //var propertyUsuarioInclusao = entry.Property(nameof(auditableEntity.UsuarioInclusao));
                                //var propertyDataInclusao = entry.Property(nameof(auditableEntity.DataInclusao));

                                //if (propertyUsuarioInclusao != null || propertyDataInclusao != null)
                                //{
                                //    propertyUsuarioInclusao.IsModified = false;
                                //    propertyDataInclusao.IsModified = false;
                                //}
                            }
                        }
                    }

                    return base.SavingChanges(eventData, result);
                }

                throw new Exception("Context invalido");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar. " + ex.Message);
            }


        }
    }
}
