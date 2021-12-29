using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesObjetos.Conta
{
    class Conta
    {
        // Porém, para que o código da aplicação possa ler e escrever nesses
        // atributos, precisamos declará-los utilizando a palavra public:

        public int numero { set; get; }
        public string titular { set; get; }
        public double saldo { set; get; }
    }
}
