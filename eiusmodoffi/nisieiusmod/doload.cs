public class Repository<TEntity> where TEntity : class
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public void Update(TEntity entityToUpdate, Expression<Func<TEntity, object>> propertyToUpdate, object id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            // Apply changes
            _context.Entry(entity).Property(propertyToUpdate).CurrentValue = _context.Entry(entityToUpdate).Property(propertyToUpdate).CurrentValue;
            _context.SaveChanges();
        }
    }
}
