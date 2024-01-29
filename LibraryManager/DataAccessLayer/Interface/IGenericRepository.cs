namespace DataAccessLayer.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        
    }
}
