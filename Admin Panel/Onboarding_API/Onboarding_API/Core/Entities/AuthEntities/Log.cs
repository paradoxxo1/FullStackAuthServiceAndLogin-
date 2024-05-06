namespace Onboarding_API.Core.Entities.AuthEntities
{
    public class Log : BaseEntity<long>
    {
        public string? UserName { get; set; }
        public string Description { get; set; }
    }
}
