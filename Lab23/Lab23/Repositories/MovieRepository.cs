using Lab23.Data;
using Lab23.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        //private readonly List<MovieViewModel> _movies = new List<MovieViewModel>();

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task Register(MovieViewModel movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieViewModel>> Get()
        {
            //var result = new List<MovieViewModel>();

            //result.Add(new MovieViewModel(1, "What About Bob?", "Comedy", 100));
            //result.Add(new MovieViewModel(2, "Seven", "Thriller", 125));
            //result.Add(new MovieViewModel(3, "Whiplash", "Drama", 106));
            //result.Add(new MovieViewModel(4, "Liar Liar", "Comedy", 83));
            //result.Add(new MovieViewModel(5, "Gone in 60 Seconds", "Action", 117));
            //result.Add(new MovieViewModel(6, "The Conjuring", "Horror", 111));
            //result.Add(new MovieViewModel(7, "Space Jam", "Comedy", 87));
            //result.Add(new MovieViewModel(8, "Now and Then", "Drama", 96));
            //result.Add(new MovieViewModel(9, "Us", "Horror", 116));
            //result.Add(new MovieViewModel(10, "Jurassic Park", "Action", 126));
            //result.Add(new MovieViewModel(11, "Forrest Gump", "Drama", 142));
            //result.Add(new MovieViewModel(12, "Clueless", "Comedy", 97));
            //result.Add(new MovieViewModel(13, "The Fast and The Furious", "Action", 107));
            //result.Add(new MovieViewModel(14, "The Strangers", "Horror", 88));
            //result.Add(new MovieViewModel(15, "Annihilation", "Scifi", 115));

            ////return Task.FromResult(result);
            return await _context.Movies.ToListAsync();

        }

        public async Task<MovieViewModel> Get(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        //public void Save(MovieViewModel movie)
        //{
        //    _movies.Add(movie);
        //}

        public Task Update(MovieViewModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
