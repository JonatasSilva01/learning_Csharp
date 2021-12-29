using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Aluno.Data;
using Aluno.Modelo;

namespace Aluno.Pages.Estudantes
{
    public class CreateModel : PageModel
    {
        private readonly Aluno.Data.AlunoContext _context;

        public CreateModel(Aluno.Data.AlunoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Alunos Alunos { get; set; }

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
