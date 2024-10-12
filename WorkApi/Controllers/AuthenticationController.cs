using Business.IServices;
using Business.Services;
using Entities.Dtos;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace workApi.Controllers
{

    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
       private readonly IUserService _userService;


        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<Boolean>> Register([FromBody] UserDTO user_dto)
        {
            try {
              
                var result=await _userService.register(user_dto);
                
                return Ok(result.Succeeded);
                
            }
            catch(Exception e) {
                return BadRequest(e.Message);
            }
        }



        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user) { 
            if (!await _userService.ValidateUser(user))
                return Unauthorized(); 
            return Ok(new { Token = await _userService.CreateToken() }); }


    }





}
