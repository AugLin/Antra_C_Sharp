namespace AntraDay3.Repository;

public interface IRepository <T> where T : class
{
    // CURD operation
    int Insert(T obj);
    int Update(T obj);
    int Delete(int id);
    List<T> GetAll();
    T GetById(int id);
}