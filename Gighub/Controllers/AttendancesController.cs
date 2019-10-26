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
    public class AttendancesController : ControllerBase
    {
        private ApplicationDbContext _context;
    
        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpPost]
        public ActionResult Attend([FromForm] AttendanceDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == dto.GigId))
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}