using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Aluno.Data;
using System;
using System.Linq;

namespace Aluno.Modelo
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AlunoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AlunoContext>>()))
            {
                // Look for any movies.
                if (context.Alunos.Any())
                {
                    return;   // DB has been seeded
                }

                context.Alunos.AddRange(
                    new Alunos
                    {
                        Nome = "Jonatas",
                        Nacimento = DateTime.Parse("1989-2-12"),
                        Genero = "Masculio",
                        Notas = 10
                    },

                    new Alunos
                    {
                        Nome = "Jaqueline",
                        Nacimento = DateTime.Parse("1984-3-13"),
                        Genero = "Feminina",
                        Notas = 10
                    },

                    new Alunos
                    {
                        Nome = "Nicolas",
                        Nacimento = DateTime.Parse("1986-2-23"),
                        Genero = "Masculino",
                        Notas = 10
                    },

                    new Alunos
                    {
                        Nome = "Bea",
                        Nacimento = DateTime.Parse("1959-4-15"),
                        Genero = "Feminina",
                        Notas = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
