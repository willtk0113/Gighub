using Gighub.Dtos;
using Gighub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Gighub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FollowingsController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public ActionResult Follow([FromForm] FollowingDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (_dbContext.Followings.Any(a => a.FollowerId == userId && a.FolloweeId == dto.FolloweeId))
                return BadRequest("The attendance already exists.");

            var following = new Following()
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId,
            };
            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}