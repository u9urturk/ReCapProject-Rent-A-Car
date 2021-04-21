using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileImagesController : ControllerBase
    {
        IProfileImagesService _profileImagesService;

        public ProfileImagesController(IProfileImagesService profileImagesService)
        {
            _profileImagesService = profileImagesService;
        }

        [HttpPost("imageadd")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProfileImage profileImage)
        {
            var result = _profileImagesService.Add(file, profileImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("imagedelete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var profileImage = _profileImagesService.GetById(Id).Data;
            var result = _profileImagesService.Delete(profileImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("imageupdate")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var profileImage = _profileImagesService.GetById(Id).Data;
            var result = _profileImagesService.Update(file, profileImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getfilebyid")]
        public IActionResult GetFileById(int id)
        {
            var result = _profileImagesService.GetById(id);
            if (result.Success)
            {
                if (result.Data != null)
                {
                    var b = System.IO.File.ReadAllBytes(result.Data.ImagePath);
                    return File(b, "image/jpeg");
                }
                else
                {
                    var b = System.IO.File.ReadAllBytes(@"C:\Users\Ugur\source\repos\ReCapProject\WepAPI\wwwroot\ProfileImages\logo2.gif");
                    return File(b, "image/gif");
                }

            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _profileImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagebyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _profileImagesService.GetProfileImagesByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

