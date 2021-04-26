using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file, string entity)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length>0)
            {
                using (var stream = new FileStream(sourcepath,FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file,entity);
            File.Move(sourcepath, result);
            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exp)
            {

                return new ErrorResult(exp.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string sourcePath,IFormFile file,string entity)
        {
            var result = newPath(file,entity);
            if (sourcePath.Length>0)
            {
                using (var stream = new FileStream(result,FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }

        private static string newPath(IFormFile file,string entity)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            string carPath = Environment.CurrentDirectory + @"\wwwroot\Images";
            string profilePath = Environment.CurrentDirectory + @"\wwwroot\ProfileImages";
            string brandPath = Environment.CurrentDirectory + @"\wwwroot\BrandLogo";
            string colorPath = Environment.CurrentDirectory + @"\wwwroot\ColorLogo";


            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            if (entity == "car")
            {
               string result = $@"{carPath}\{newPath}";
                return result;
            }
            else if(entity == "profile"){
                string result = $@"{profilePath}\{newPath}";
                return result;
            }
            else if (entity == "brand")
            {
                string result = $@"{brandPath}\{newPath}";
                return result;
            }
            else  
            {
                string result = $@"{colorPath}\{newPath}";
                return result;
            }






        }
    }
}
