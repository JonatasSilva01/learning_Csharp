using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aluno.Data;
using Aluno.Modelo;

namespace Aluno.Pages.Estudantes
{
    public class EditModel : PageModel
    {
        private readonly Aluno.Data.AlunoContext _context;

        public EditModel(Aluno.Data.AlunoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Alunos Alunos { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Alunos = await _context.Alunos.FirstOrDefaultAsync(m => m.ID == id);

            if (Alunos == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Alunos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunosExists(Alunos.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AlunosExists(int id)
        {
            return _context.Alunos.Any(e => e.ID == id);
        }
    }
}
