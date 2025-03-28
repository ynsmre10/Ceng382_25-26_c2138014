using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Week5.Models;
using System.Collections.Generic;
using System.Linq;

namespace Week5.Pages
{
    public class IndexModel : PageModel
    {
        public static List<ClassInformationModel> ClassList { get; set; } = new List<ClassInformationModel>();

        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        public void OnGet() { }

        public IActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
                return Page();

            IndexModel.ClassList.Add(NewClass);
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int id)
        {
            var item = IndexModel.ClassList.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                IndexModel.ClassList.Remove(item);
            }
            return RedirectToPage();
        }
    }
}