using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace _4Ballers.Pages
{
    public class HistoryModel : PageModel
    {
        [BindProperty]
        public IFormFile FileInput { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
          
            if (FileInput != null && FileInput.Length > 0)
            {
                
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", FileInput.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    FileInput.CopyTo(stream);
                }

               
            }
        }
    }
}
