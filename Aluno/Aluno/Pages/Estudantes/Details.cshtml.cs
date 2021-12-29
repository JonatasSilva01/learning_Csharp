using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aluno.Data;
using Aluno.Modelo;

namespace Aluno.Pages.Estudantes
{
    public class DetailsModel : PageModel
    {
        private readonly Aluno.Data.AlunoContext _context;

        public DetailsModel(Aluno.Data.AlunoContext context)
        {
            _context = context;
        }

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
    }
}
