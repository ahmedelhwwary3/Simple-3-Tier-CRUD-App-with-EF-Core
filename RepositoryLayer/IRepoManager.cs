

namespace RepositoryLayer
{
    public interface IRepoManager<T>
    {
        public bool Add(T obj);
        public bool DeleteByID(long ID);
        public bool Update(T obj);
        public T GetByID(long ID);
        public ICollection<T> GetAll();
        

















    }
}
