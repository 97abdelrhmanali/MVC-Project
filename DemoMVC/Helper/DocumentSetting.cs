using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DemoMVC.Helper
{
    public class DocumentSetting
    {
        public static async Task<string> UploadFile(IFormFile file, string folderName)
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files",folderName);
            string FileName =$"{Guid.NewGuid()}{file.FileName}";
            string filePath = Path.Combine(FolderPath,FileName);
            using var FileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(FileStream);
            return FileName;
        }


        public static void DeleteFile(string fileName ,string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName, fileName);
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
