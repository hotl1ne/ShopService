using Microsoft.AspNetCore.Mvc;
using ShopService.Application.Services;

namespace ShopService.API.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("birth/{dateOfBirth}")]
        public async Task<ActionResult> GetUsersByBirthDate(string dateOfBirth)
        {
            if (!DateOnly.TryParse(dateOfBirth, out var parsedDate))
            {
                return BadRequest("Invalid date format. Use 'YYYY-MM-DD'.");
            }

            var users = await _userService.GetUsersByBirth(parsedDate);

            if (users.Count == 0 || users == null)
            {
                return NotFound("Users with this birth date didn`t exist yet");
            }

            return Ok(users);
        }
    }
}
