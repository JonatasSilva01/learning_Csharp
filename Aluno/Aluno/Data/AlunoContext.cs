using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aluno.Modelo;

namespace Aluno.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext (DbContextOptions<AlunoContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno.Modelo.Alunos> Alunos { get; set; }
    }
}
