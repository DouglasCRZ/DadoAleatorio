using System;
using System.Globalization;



namespace NovoProjeto
{

    class Program
    {

        static void Main(string[] args)
        {

            Random dado = new Random();


            Console.WriteLine("Jogue o dado, você só ganha se acertar o número 10!");

           int dice = dado.Next(1, 12);
            Console.WriteLine($"O Número sorteado foi {dice}, continue tentando..");

            while (dice != 10)
            {

                dice = dado.Next(1, 12);
                if (dice == 10)
                {

                    Console.WriteLine($"Número {dice}");
                    Console.WriteLine($"Parabéns, o número sorteado foi o {dice}");

                }
                else
                {
                    Console.WriteLine($"O Número sorteado foi: {dice}, continue tentando..");

                }
                

            }
            









        }

    }
}