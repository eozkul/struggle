using Struggle.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Struggle.Data.Abstractions
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetColor(Color color, CancellationToken cancellationToken);
        Task<T> Get(Guid id, CancellationToken cancellationToken);
        Task<TDto> Get<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        void Update(T entity);
        void Delete(T entity);
    }
}
