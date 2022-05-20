using System;

namespace exercicio_4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int valor;

            Console.WriteLine("Informe o valor");
            valor = Convert.ToInt32(Console.ReadLine());
            int[] vetorint = new int[valor];
            int[] vetorcopia = new int[valor];
            int[] vetorcontarrepet = new int[valor];
            do
            {
                Console.WriteLine("Informe um valor");
                vetorint[cont] = Convert.ToInt32(Console.ReadLine());
                vetorcopia[cont] = vetorint[cont];
                cont++;

            } while (cont < vetorint.Length);

            cont = 0;
            int cont1 = 0;
            do
            {
                do
                {
                    if (cont != cont1)
                    {
                        if (vetorint[cont1] == vetorcopia[cont])
                        {
                            vetorcontarrepet[cont1]++;
                        }
                    }
                   
                    cont++;

                } while (cont < vetorint.Length);
                cont = 0;
                cont1++;

            }while (cont1 < vetorint.Length);
            cont1 = 0;
            do
            {
                Console.WriteLine(vetorcontarrepet[cont1]);
                cont1++;
            } while (cont1 < vetorcontarrepet.Length);

        }
    }
}
