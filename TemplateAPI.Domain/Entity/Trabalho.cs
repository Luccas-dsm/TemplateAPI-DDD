using System.ComponentModel.DataAnnotations;

namespace TemplateAPI.Domain.Entity
{
    public class Trabalho
    {
        #region Primitive Properties

        [Key]
        [Required]
        public virtual long Seq { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Titulo { get; set; }

        [Required]
        public virtual string Resumo { get; set; }

        [Required]
        public virtual long SeqSituacao { get; set; }

        public virtual Nullable<long> SeqAreaConhecimento { get; set; }

        [Required]
        public virtual System.DateTime DataInclusao { get; set; }

        [Required]
        [StringLength(60)]
        public virtual string UsuarioInclusao { get; set; }

        public virtual Nullable<System.DateTime> DataAlteracao { get; set; }

        [StringLength(60)]
        public virtual string UsuarioAlteracao { get; set; }

        #endregion Primitive Properties

        #region Navigation Properties

        public virtual AreaConhecimento AreaConhecimento { get; set; }

        public virtual Situacao Situacao { get; set; }

        public virtual IList<Topico> Topicos { get; set; }

        public virtual IList<TrabalhoAutor> Autores { get; set; }

        public virtual IList<ArquivoAnexado> Arquivos { get; set; }

        #endregion Navigation Properties
    }
}
