namespace Cqrs.Reposatory
{
    public interface IReposatory<T> where T : class
    {
        Task<T> GetbyIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllListAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeletAsync(T entity);

    }
}
