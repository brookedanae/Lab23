using Lab23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Repositories
{
    public interface IMovieRepository
    {
        Task Register(MovieViewModel movie);

        Task Delete(int id);

        Task<bool> Exists(int id);

        Task<List<MovieViewModel>> Get();

        Task<MovieViewModel> Get(int id);

        Task Update(MovieViewModel movie);
        //void Save(MovieViewModel model);
    }
}
