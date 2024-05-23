using System.ComponentModel.DataAnnotations;
using TemplateAPI.Shared.Enums;

namespace TemplateAPI.Domain.Entity
{
    public class Autor
    {
        #region Primitive Properties

        [Key]
        [Required]
        public virtual long Seq { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public virtual string Cpf { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Email { get; set; }

        [Required]
        public virtual System.DateTime DataNascimento { get; set; }

        [Required]
        public virtual EnumSexo Sexo { get; set; }

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

        public virtual IList<TrabalhoAutor> Trabalhos { get; set; }

        #endregion Navigation Properties
    }
}
