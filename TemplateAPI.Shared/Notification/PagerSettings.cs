using TemplateAPI.Shared.Enums.Utils;

namespace TemplateAPI.Shared.Notification
{
    public class PagerSettings
    {
        public int Total { get; set; }
        public int OffSet { get; set; }
        public int Limit { get; set; }
        public EnumOrdenacao Ordenacao { get; set; }
    }
}
