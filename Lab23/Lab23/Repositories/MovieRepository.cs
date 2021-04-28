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

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task Register(MovieViewModel movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Movies.RemoveRange();
            await _context.SaveChangesAsync();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieViewModel>> Get()
        {
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

        public async Task<List<MovieViewModel>> GetByName(string title)
        {
            return await _context.Movies.Where(x => x.Title.Contains(title)).ToListAsync();

        }

        public async Task<List<MovieViewModel>> GetByGenre(string genre)
        {
            return await _context.Movies.Where(x => x.Genre.Contains(genre)).ToListAsync();
        }
    }
}
