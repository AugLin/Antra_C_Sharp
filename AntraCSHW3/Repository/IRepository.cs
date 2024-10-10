namespace AntraCSHW3.Repository;

public interface IRepository <T> where T : class
{
    // CURD operation
    void Add(T obj);
    void Remove(T obj);
    void Save(int id);
    IEnumerable<T> GetAll();
    T GetById(int id);
}