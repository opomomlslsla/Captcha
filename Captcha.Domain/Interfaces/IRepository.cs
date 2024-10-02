using Captcha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Captcha.Domain.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task AddEntity(T entity);
    Task DeleteEntity(T entity);
    Task<ICollection<T>> GetAllEntitiesAsync();
    Task<ICollection<T>> GetEntitiesByAsync(Expression<Func<T, bool>> predicate);
    Task<T?> GetEntityByAsync(Expression<Func<T, bool>> predicate);
    Task<T?> GetEntityByIdAsync(Guid id);
    Task<bool> IsEntityExist(Guid id);
    Task SaveChangesAsync();
    Task UpdateEntity(T entity);
}
