using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Book_web2_razor_temp.Data;
using Book_web2_razor_temp.Model;

namespace Book_web2_razor_temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _db;
        public List<Category> CategoryList { get; set; }  
        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
