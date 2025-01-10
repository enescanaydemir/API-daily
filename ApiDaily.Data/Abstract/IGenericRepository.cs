using System;

namespace ApiDaily.Data.Abstract;

public interface IGenericRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
}
