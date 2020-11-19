using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Extensions
{
    public static class IFormFileExtension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool MaxLength(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }



        public async static Task<string> SaveImg(this IFormFile file, string webroot, string folder)
        {
            string path = webroot;
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, folder, fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }


        public static void DeletePath(string webroot, string folder, string image)
        {
            string path = Path.Combine(webroot, folder, image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
