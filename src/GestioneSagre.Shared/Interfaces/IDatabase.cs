namespace GestioneSagre.Shared.Interfaces;

public interface IDatabase<T, TKey> where T : class, IEntity<TKey>
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(TKey id);
}