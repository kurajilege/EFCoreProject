namespace EFCoreProject.Domain.Entities
{
    using System;
    using EFCoreProject.Domain.Interfaces;

    public class User : IEntityId<long>, IAuditable
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}