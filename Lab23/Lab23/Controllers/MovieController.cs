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
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _repository.Get());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var results = await _repository.Get(id.Value);
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

            await _repository.Register(model);
            return RedirectToAction("Index");
        }

        //public IActionResult SearchResultGenre(MovieSearchViewModel model)
        //{
        //    var list = _repository.Get().Where(x => x.Genre == model.Genre);
        //    return View(list);
        //}
    }
}
