using Music_Manager.Data;

namespace Music_Manager.Repositories.Generic_Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext ctx;
        public Repository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }
        public void Create(T item)
        {
            ctx.Set<T>().Add(item);
            ctx.SaveChanges();
        }

        public IQueryable<T> ReadAll()
        {
            return ctx.Set<T>();
        }

        public void Delete(int id)
        {
            ctx.Set<T>().Remove(Read(id));
            ctx.SaveChanges();
        }

        public abstract T Read(int id);
        public abstract void Update(T item);

    }
}
