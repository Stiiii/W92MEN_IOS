namespace Music_Manager.Repositories.Generic_Repository
{
    public interface IRepository<T>
    {
        //Crud
        public void Create(T item);
        public IQueryable<T> ReadAll();
        public T Read(int id);
        public void Update(T item);
        public void Delete(int id);
    }
}
