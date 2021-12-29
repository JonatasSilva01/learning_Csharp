using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PageCrud.Model;

namespace PageCrud.Data
{
    public class PageCrudContext : DbContext
    {
#pragma warning disable CS8618
        public PageCrudContext (DbContextOptions<PageCrudContext> options)
#pragma warning disable CS8618
            : base(options)
        {
        }

        public DbSet<PageCrud.Model.Alunos>? Alunos { get; set; }
    }
}
