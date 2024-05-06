namespace Onboarding_API.Core.Entities.AuthEntities
{
    public class Message : BaseEntity<long>
    {
        public string SenderUserName { get; set; }
        public string ReceiverUserName { get; set; }
        public string Text { get; set; }
    }
}
