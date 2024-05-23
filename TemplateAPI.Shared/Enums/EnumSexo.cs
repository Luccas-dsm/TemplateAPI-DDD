using System.ComponentModel;
using System.Runtime.Serialization;

namespace TemplateAPI.Shared.Enums
{
    public enum EnumSexo
    {
        [EnumMember]
        [Description("")]
        Nenhum = 0,

        [EnumMember]
        [Description("Masculino")]
        Masculino = 1,

        [EnumMember]
        [Description("Feminino")]
        Feminino = 2
    }
}
