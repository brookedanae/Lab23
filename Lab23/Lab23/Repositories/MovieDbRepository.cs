using Lab23.Data;
using Lab23.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Repositories
{
    public class MovieDbRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieDbRepository(MovieDbContext context)
        {
            _context = context;
        }
        public Task Register(MovieViewModel movie)
        {
            throw new NotImplementedException();
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
            return await _context.Movies.ToListAsync();
            //SELECT *
            //FROM dbo.Movies
        }

        public async Task<List<MovieViewModel>> GetByName(string name)
        {
            return await _context.Movies.Where(x => x.Title.Contains(name)).ToListAsync();
            // SELECT *
            // FROM dbo.Movies
            // WHERE Title LIKE '%<Name>%'
        }

        public async Task<List<MovieViewModel>> GetByGenre(string genre)
        {
            return await _context.Movies.Where(x => x.Genre.Contains(genre)).ToListAsync();
        }

        public Task<MovieViewModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(MovieViewModel movie)
        {
            throw new NotImplementedException();
        }

        public void Save(MovieViewModel movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }
}
