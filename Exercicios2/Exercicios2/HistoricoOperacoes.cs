using System;
using System.Collections.Generic;

namespace Exercicios2
{
    public class HistoricoOperacoes
    {
        private Stack<string> _historico;

        public HistoricoOperacoes(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;

            _historico = new Stack<string>();
        }

        public string NomeUsuario { get; private set; }

        public void Adicionar(string nome)
        {
            _historico.Push(nome);
        }

        public void Desfazer()
        {
            Console.WriteLine($"Última operação desfeita.");

            _historico.Pop();
        }

        public string MostrarUltimaOperacao()
        {
            var ultimaOperacao = _historico.Peek();

            return ultimaOperacao;
        }
    }
}