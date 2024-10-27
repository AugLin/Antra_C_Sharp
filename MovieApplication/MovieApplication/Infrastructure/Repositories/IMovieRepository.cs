using Dapper;
using MovieApplication.Core.Entities;
using MovieApplication.Core.Interfaces;
using MovieApplication.Infrastructure.Data;
using System.Data;

namespace MovieApplication.Infrastructure.Repositories
{
    public class IMovieRepository : IRepository<Movies>
    {
        private SqlDbConnection _dbConnection = new SqlDbConnection();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movies> GetAll()
        {
            using (IDbConnection conn = _dbConnection.GetConnection())
            {
                return conn.Query<Movies>("SELECT * FROM Movies");
            }
        }

        public Movies GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movies obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Movies obj)
        {
            throw new NotImplementedException();

        }
    }
