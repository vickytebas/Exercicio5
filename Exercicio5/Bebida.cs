using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Bebida : ItemMenu
    {
        private int tamanhoP;
        private int tamanhoM;
        private int tamanhoG;

        public Bebida(string nome, int tamanhoP, int tamanhoM, int tamanhoG) : base(nome)
        {
            this.Nome = nome;
            this.TamanhoP = tamanhoP;
            this.TamanhoM = tamanhoM;
            this.TamanhoG = tamanhoG;
        }

        public int TamanhoP { get => tamanhoP; set => tamanhoP = value; }
        public int TamanhoM { get => tamanhoM; set => tamanhoM = value; }
        public int TamanhoG { get => tamanhoG; set => tamanhoG = value; }

        public override void ImprimirPreco()
        {
            Console.WriteLine("O preco P: ${0}, M: ${1}, G: ${2}", TamanhoP, TamanhoM, TamanhoG);
        }
    }
}
