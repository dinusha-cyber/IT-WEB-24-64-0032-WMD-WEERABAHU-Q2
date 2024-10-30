﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Q2.Data;
using Q2.Model;

namespace Q2.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly Q2.Data.Q2Context _context;

        public CreateModel(Q2.Data.Q2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public course course { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.course.Add(course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}