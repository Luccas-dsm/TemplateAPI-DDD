using System.ComponentModel.DataAnnotations;

namespace TemplateAPI.Domain.Entity
{
    public class AreaConhecimento
    {
        #region Primitive Properties

        [Key]
        [Required]
        public virtual long Seq { get; set; }

        public virtual Nullable<long> SeqPai { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Descricao { get; set; }

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

        public virtual IList<AreaConhecimento> AreasConhecimentoFilhas { get; set; }

        public virtual AreaConhecimento AreaConhecimentoPai { get; set; }

        #endregion Navigation Properties
    }
}
