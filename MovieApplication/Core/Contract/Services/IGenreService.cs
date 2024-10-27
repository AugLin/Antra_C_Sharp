using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract.Services
{
    public interface IGenreService
    {
        int AddGenre(Genre genre);
        int UpdateGenre(Genre genre, int id);
        int DeleteGenre(int id);
        IEnumerable<Genre> GetAllGenre();
    }
}
