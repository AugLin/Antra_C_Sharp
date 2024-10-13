namespace AntraDay4.Repository;

public interface BaseRepository<T> where T : class
{
    List<T> Search(Predicate<T> Condition);
}