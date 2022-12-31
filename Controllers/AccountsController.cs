﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MEalAPI.Entities;
using MEalAPI.Dto.Requests;
using MEalAPI.Dto.Responses;

// Un-comment if not using the SignInManager
//using System.Security.Claims;
//using Microsoft.AspNetCore.Authentication;

namespace MEalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly UserManager<EUser> _userManager;
        private readonly SignInManager<EUser> _signInManager;
        private readonly IMapper _mapper;

        public AccountsController(IMapper mapper, UserManager<EUser> userManager, SignInManager<EUser> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] DRegisterUserRequest userForRegistration)
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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] DUserLoginRequest userLoginRequest)
        {
            if (userLoginRequest == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _signInManager.PasswordSignInAsync(userLoginRequest.Email, userLoginRequest.Password, false, false);
            if (result.Succeeded)
            {
                return Ok(result);
            }
            else
            {
                return Unauthorized("Invalid username or password");
            }

            // You can use this instead of the SignInManager if you want more control
            //var user = await _userManager.FindByEmailAsync(userLoginRequest.Email);

            //if (user != null && await _userManager.CheckPasswordAsync(user, userLoginRequest.Password))
            //{
            //    var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
            //    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            //    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

            //    await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));
            //    return Ok();
            //}
            //else
            //{
            //    return Unauthorized("Invalid username or password");
            //}
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}
