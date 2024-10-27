using Core.Contract.Repositories;
using Core.Contract.Services;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repository)
        {
            _repository = repository;
        }

        public int AddGenre(Genre genre)
        {
            return _repository.Insert(genre);
        }

        public int DeleteGenre(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Genre> GetAllGenre()
        {
            return _repository.GetAll();
        }

        public int UpdateGenre(Genre genre, int id)
        {
            if (genre.Id == id)
            {
                return _repository.Update(genre);
            }
            return 0;
        }
    }
}
