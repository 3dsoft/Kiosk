using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Context.Repositories;
using WebApp.Models;

namespace Company.WebApplication1.Pages.Forms
{
    public class GeneralModel : PageModel
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public GeneralModel(IMenuItemRepository menuItemRepository, IHostingEnvironment hostingEnvironment)
        {
            _menuItemRepository = menuItemRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        [BindProperty]
        public IEnumerable<MenuItem> MenuItems { get; set; }


        public void OnGet()
        {
            MenuItems = _menuItemRepository.GetAllItems();
        }

        [BindProperty]
        public IFormFile uploadFile { get; set; }


        public IActionResult OnPost()
        {
            var stream = uploadFile.OpenReadStream();

            var uploadPath = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
            if (Directory.Exists(uploadPath) == false) Directory.CreateDirectory(uploadPath);
            var fullPath = Path.Combine(uploadPath, uploadFile.FileName);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                stream.CopyTo(fileStream);

                MenuItem.ImagePath = "/Images/" + uploadFile.FileName;
            }

            MenuItem.isUse = true;

            //if (ModelState.IsValid)
            //{
                _menuItemRepository.AddItem(MenuItem);
                _menuItemRepository.Save();

                return RedirectToPage("General");
            //}

            //return Page();            
        }
    }
}