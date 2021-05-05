using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalluserdetail")]
        public IActionResult GetAllUserDetail()
        {
            var result = _userService.GetAllUserDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserbyuserid")]
        public IActionResult GetUserByUserId(int userid)
        {
            var result = _userService.GetUserByUserId(userid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("userupdate")]
        public IActionResult UserUpdate(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
