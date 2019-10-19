using Gighub.Models;
using Gighub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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


        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(GigFormViewModel viewModel)
        {
            var gig = new Gig()
            {
                Venue = viewModel.Venue,
                ArtistId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre
            };

            _dbContext.Add(gig);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}