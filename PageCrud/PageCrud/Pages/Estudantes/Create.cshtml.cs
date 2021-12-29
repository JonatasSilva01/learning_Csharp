using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PageCrud.Data;
using PageCrud.Model;

namespace PageCrud.Pages.Estudantes
{
    public class CreateModel : PageModel
    {
        private readonly PageCrud.Data.PageCrudContext _context;

        public CreateModel(PageCrud.Data.PageCrudContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Alunos Alunos { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Alunos.Add(Alunos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
