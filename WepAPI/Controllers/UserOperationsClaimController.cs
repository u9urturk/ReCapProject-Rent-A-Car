using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationsClaimController : ControllerBase
    {
        IUserOperationClaimService _IUserOperationClaimService;

        public UserOperationsClaimController(IUserOperationClaimService userOperationClaimService)
        {
            _IUserOperationClaimService = userOperationClaimService;
        }


        [HttpPost("userclaimadd")]
        public IActionResult UserClaimAdd(UserOperationClaim userOperationClaim)
        {
            var result = _IUserOperationClaimService.AddUserClaim(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("userclaimdelete")]
        public IActionResult UserClaimDelete(UserOperationClaim userOperationClaim)
        {
            var result = _IUserOperationClaimService.DeleteUserClaim(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("userclaimupdate")]
        public IActionResult UserClaimUpdate(UserOperationClaim userOperationClaim)
        {
            var result = _IUserOperationClaimService.UpdateUserClaim(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserclaimbyuserid")]
        public IActionResult GetUserClaimByUserId(int userId)
        {
            var result = _IUserOperationClaimService.GetUserClaimByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
