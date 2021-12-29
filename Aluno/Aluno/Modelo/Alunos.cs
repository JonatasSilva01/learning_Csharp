using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluno.Modelo
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Nacimento")]
        [DataType(DataType.Date)]
        public DateTime Nacimento { get; set; }
        public string Genero { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Notas { get; set; }
    }
}
