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
    public class IndexModel : PageModel
    {
        private readonly Aluno.Data.AlunoContext _context;

        public IndexModel(Aluno.Data.AlunoContext context)
        {
            _context = context;
        }

        public IList<Alunos> Alunos { get;set; }

        public async Task OnGetAsync()
        {
            Alunos = await _context.Alunos.ToListAsync();
        }
    }
}
