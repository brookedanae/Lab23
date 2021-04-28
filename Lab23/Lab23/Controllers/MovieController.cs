using Lab23.Models;
using Lab23.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Controllers
{
    public class MovieController : Controller
    {

        private readonly IMovieRepository _context;

        public MovieController(IMovieRepository context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Get());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var results = await _context.Get(id.Value);
            return View(results);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Register(MovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _context.Register(model);
            return RedirectToAction("Index");
        }

        public IActionResult SearchByGenre()
        {
            return View();
        }

        public async Task <IActionResult> SearchResultGenre(MovieSearchViewModel model)
        {
            var list = await _context.GetByGenre(model.Genre);
            return View(list);
        }

        public IActionResult SearchByTitle()
        {
            return View();
        }

        public async Task<IActionResult> SearchResultTitle(MovieSearchViewModel model)
        {
            var list = await _context.GetByName(model.Title);
            return View(list);
        }
    }
}
