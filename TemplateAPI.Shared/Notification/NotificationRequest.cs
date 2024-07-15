namespace TemplateAPI.Shared.Notification
{
    public class NotificationRequest<T>
    {
        public PagerSettings pagerSettings { get; set; }

        public T? Data { get; set; }
    }
}
