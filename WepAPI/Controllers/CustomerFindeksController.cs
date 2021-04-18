using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerFindeksController : ControllerBase
    {
        IUserFindexPointService _userFindexPointService;
        public CustomerFindeksController(IUserFindexPointService userFindexPointService)
        {
            _userFindexPointService = userFindexPointService;
        }

        [HttpGet("getcustomerfindekspoint")]
        public IActionResult GetCustomerFindeksPoint(int customerId)
        {
            var result = _userFindexPointService.GetFindeksPointByUserId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("newcustomerfindekspoint")]
        public IActionResult NewCustomerFindeksPoint(UserFindeksPoint userFindeksPoint)
        {
            var result = _userFindexPointService.Add(userFindeksPoint);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecustomerfindekspoint")]
        public IActionResult UpdateCustomerFindeksPoint(UserFindeksPoint userFindeksPoint)
        {
            var result = _userFindexPointService.Update(userFindeksPoint);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
