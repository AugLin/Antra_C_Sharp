using MovieApplication.Core.Entities;
using MovieApplication.Core.Interfaces;
using MovieApplication.Infrastructure.Data;

namespace MovieApplication.Infrastructure.Repositories
{
    public class IGenreRepository : IRepository<Genre>
    {
        private SqlDbConnection _dbConnection = new SqlDbConnection();

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Genre obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Genre obj)
        {
            throw new NotImplementedException();
        }
    }
}
