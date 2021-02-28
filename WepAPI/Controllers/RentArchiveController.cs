using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentArchiveController : ControllerBase
    {
        IRentArchiveService _rentArchiveService;

        public RentArchiveController(IRentArchiveService rentArchiveService)
        {
            _rentArchiveService = rentArchiveService;
        }


        [HttpGet("getrentarchive")]
        public IActionResult GetRentArchive(RentArchive rentArchive)
        {
            var result = _rentArchiveService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
