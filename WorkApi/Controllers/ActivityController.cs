using Business.IServices;
using Microsoft.AspNetCore.Mvc;

namespace workApi.Controllers
{

    [Route("api")]
    [ApiController]
    public class ActivityController : ControllerBase
    {

        private readonly IUserActivityService _userActivityService;


        public ActivityController(IUserActivityService userActivityService)
        {
            _userActivityService = userActivityService;
        }


        [HttpGet("activity")]
        public async Task<ActionResult<Boolean>> GetActivities()
        {
            try
            {

                var result = await _userActivityService.GetUsersActivity();

                return Ok(result);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
