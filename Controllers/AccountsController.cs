using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MEalAPI.Entities;
using MEalAPI.Dto.Requests;
using MEalAPI.Dto.Responses;

namespace MEalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly UserManager<EUser> _userManager;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<EUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost("Registration")]
        public async Task<ActionResult> RegisterUser([FromBody] DRegisterUserRequest userForRegistration)
        {
            if (userForRegistration == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _mapper.Map<EUser>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new DRegisterUserResponse() { Errors = errors });
            }

            return StatusCode(201);
        }
    }
}
