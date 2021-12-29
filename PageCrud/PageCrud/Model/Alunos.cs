using System;
using System.ComponentModel.DataAnnotations;

namespace PageCrud.Model
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime RealiseDate { get; set; }
        public string Genero { get; set; } = string.Empty;
        public decimal Nota { get; set; } = 0;  
    }
}
