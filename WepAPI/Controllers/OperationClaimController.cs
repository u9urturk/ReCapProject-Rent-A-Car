using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimController : ControllerBase
    {
        IOperationClaimService _operationClaimService;

        public OperationClaimController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }


        [HttpPost("claimadd")]
        public IActionResult ClaimAdd(OperationClaim operationClaim)
        {
            var result = _operationClaimService.AddClaim(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("claimdelete")]
        public IActionResult ClaimDelete(OperationClaim operationClaim)
        {
            var result = _operationClaimService.DeleteClaim(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallclaims")]
        public IActionResult GetAllClaims()
        {
            var result = _operationClaimService.GetAllClaims();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       
    }
}
