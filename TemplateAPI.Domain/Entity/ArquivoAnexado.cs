using System.ComponentModel.DataAnnotations;

namespace TemplateAPI.Domain.Entity
{
    public class ArquivoAnexado
    {
        #region Primitive Properties

        [Key]
        [Required]
        public virtual long Seq { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Nome { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Tipo { get; set; }

        [Required]
        public virtual byte[] Conteudo { get; set; }

        [Required]
        public virtual int Tamanho { get; set; }

        [Required]
        public virtual System.DateTime DataInclusao { get; set; }

        [Required]
        [StringLength(60)]
        public virtual string UsuarioInclusao { get; set; }

        public virtual Nullable<System.DateTime> DataAlteracao { get; set; }

        [StringLength(60)]
        public virtual string UsuarioAlteracao { get; set; }

        public virtual Nullable<System.Guid> UidArquivo { get; set; }

        #endregion Primitive Properties
    }
}
