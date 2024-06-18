namespace EFCoreProject.Domain.Interfaces
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> CreateAsync(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
