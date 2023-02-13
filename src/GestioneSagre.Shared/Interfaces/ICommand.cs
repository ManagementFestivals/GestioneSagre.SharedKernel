namespace GestioneSagre.Shared.Interfaces;

public interface ICommand<TEntity> where TEntity : class
{
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}