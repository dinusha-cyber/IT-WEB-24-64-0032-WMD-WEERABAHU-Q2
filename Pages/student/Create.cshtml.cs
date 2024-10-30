using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q2.Data;
using Q2.Model;

namespace Q2.Pages.student
{
    public class CreateModel : PageModel
    {
        private readonly Q2.Data.Q2Context _context;

        public CreateModel(Q2.Data.Q2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        public IEnumerable<course> Courses { get; set; } = [];
        
        
        public async Task<IActionResult> OnGetAsync()
        {
            Courses = await _context.course.ToListAsync();
            return Page();
        }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Courses = await _context.course.ToListAsync();
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
