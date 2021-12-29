﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly PageCrud.Data.PageCrudContext _context;

        public DeleteModel(PageCrud.Data.PageCrudContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Alunos = await _context.Alunos.FindAsync(id);

            if (Alunos != null)
            {
                _context.Alunos.Remove(Alunos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
