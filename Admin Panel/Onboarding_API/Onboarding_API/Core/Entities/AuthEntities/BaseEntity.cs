﻿namespace Onboarding_API.Core.Entities.AuthEntities
{
    public class BaseEntity<TID>
    {
        public TID Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
