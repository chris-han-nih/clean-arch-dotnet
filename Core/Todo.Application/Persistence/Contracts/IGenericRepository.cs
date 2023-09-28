namespace Todo.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(long id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    Task<T> UpdateAsync(T entity);
}