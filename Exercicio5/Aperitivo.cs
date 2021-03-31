using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome) : base(nome)
        {
            Preco = 10;
        }
    }
}
