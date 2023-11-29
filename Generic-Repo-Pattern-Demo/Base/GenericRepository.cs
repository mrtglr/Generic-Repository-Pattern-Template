using Generic_Repo_Pattern_Demo.Base.Interfaces;
using Generic_Repo_Pattern_Demo.Context;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repo_Pattern_Demo.Base
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Create(TEntity entity)
        {
            await _appDbContext.Set<TEntity>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            _appDbContext.Set<TEntity>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _appDbContext.Set<TEntity>().AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(Guid id, TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
