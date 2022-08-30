using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Struggle.Common;
using Struggle.Data.Abstractions;
using System.Linq.Expressions;
namespace Struggle.Data.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public Repository(DbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public Task<T> GetColor(Color color, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(f => f.Color == color, cancellationToken);
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(f => f.Id == id, cancellationToken);
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
        }

        public Task<TDto> Get<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ProjectTo<TDto>(mapper.ConfigurationProvider).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
