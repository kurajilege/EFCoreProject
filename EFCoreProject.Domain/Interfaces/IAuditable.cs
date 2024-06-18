namespace EFCoreProject.Domain.Interfaces
{
    using System;

    public interface IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
