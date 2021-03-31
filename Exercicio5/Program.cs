using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cafe = new Bebida("Cafe", 2, 4, 6);
            Bebida refri = new Bebida("Refri", 5, 10, 15);
            Bebida cerveja = new Bebida("Cerveja", 6, 12, 18);

            Aperitivo frangoP = new Aperitivo("Frango a Passarinho");
            Aperitivo isca = new Aperitivo("Isca de Peixe");

            ItemMenu[] cardapio = new ItemMenu[5];
            cardapio[0] = cafe;
            cardapio[1] = refri;
            cardapio[2] = cerveja;
            cardapio[3] = frangoP;
            cardapio[4] = isca;

            foreach (ItemMenu item in cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
