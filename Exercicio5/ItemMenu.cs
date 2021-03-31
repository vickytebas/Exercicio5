using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class ItemMenu
    {
        private string nome;
        private float preco;

        public ItemMenu(string nome)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public string Nome { get => nome; protected set => nome = value; }
        public float Preco { get => preco; protected set => preco = value; }

        public virtual void ImprimirNome()
        {
            Console.WriteLine(Nome);
        }

        public virtual void ImprimirPreco()
        {
            Console.WriteLine(Preco);
        }
    }
}
