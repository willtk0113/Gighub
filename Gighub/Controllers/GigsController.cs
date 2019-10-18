using Gighub.Models;
using Gighub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Gighub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GigsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public IActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _dbContext.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}