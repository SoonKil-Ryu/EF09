using EF09.Data;
using EF09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EF09.Pages.Schools
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;

        }

        public IList<Student> Students { get; set; }

        public async Task OnGetAsync()
        {
            //Students = await _context.Students.ToListAsync();

            Students = await _context.Students.Include(s => s.Score).ToListAsync();


        }

        /*
        public void OnGet()
        {
        }
         */
    }
}
