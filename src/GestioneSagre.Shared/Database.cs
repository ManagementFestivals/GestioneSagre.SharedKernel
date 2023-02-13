namespace GestioneSagre.Shared;

public class Database<T, TKey> : IDatabase<T, TKey> where T : class, IEntity<TKey>
{
    public DbContext DbContext { get; }

    public Database(DbContext dbContext)
    {
        DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await DbContext.Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<T> GetByIdAsync(TKey id)
    {
        var entity = await DbContext.Set<T>().FindAsync(id);

        if (entity == null)
        {
            return null;
        }

        DbContext.Entry(entity).State = EntityState.Detached;

        return entity;
    }
}