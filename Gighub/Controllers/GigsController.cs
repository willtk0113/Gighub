using Gighub.Models;
using Gighub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Gighub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GigsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Authorize]
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