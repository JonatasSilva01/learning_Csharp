using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PageCrud.Data;
using PageCrud.Model;

namespace PageCrud.Pages.Estudantes
{
    public class IndexModel : PageModel
    {
        private readonly PageCrud.Data.PageCrudContext _context;

        public IndexModel(PageCrud.Data.PageCrudContext context)
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
