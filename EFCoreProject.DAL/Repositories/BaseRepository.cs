namespace EFCoreProject.DAL.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using EFCoreProject.Domain.Interfaces;

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            await _dbContext.AddAsync(entity);

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            _dbContext.Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public TEntity Update(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            _dbContext.Update(entity);

            return entity;
        }
    }
}
