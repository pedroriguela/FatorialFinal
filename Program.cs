using System;
using System.Diagnostics;

namespace Tentativa
{
    class Program
    {
        static void Main(string[] args)
        {

            int modeloCalculo = 1;
            while (modeloCalculo != 1 || modeloCalculo != 2)
            {
                Console.WriteLine("Digite 1 para calcular usando Loop e 2 para Recursiva: ");
                var digitedText = Console.ReadLine();

                if ((int.TryParse(digitedText, out int digitedNumber) == true) && (digitedNumber==1 || digitedNumber==2))
                {
                    Console.WriteLine("Modelo imputado com sucesso!");
                    if (digitedNumber == 1)
                    {
                        Console.WriteLine("O modelo de cálculo escolhido é em Loop.");
                        var stopWatch = Stopwatch.StartNew();
                        FatorialLoop();
                        stopWatch.Stop();
                        Console.WriteLine($"O tempo de execução foi de: {stopWatch.ElapsedMilliseconds}ms");
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("O modelo de cálculo escolhido é Recursiva.");
                        var stopWatch = Stopwatch.StartNew();
                        FatorialRecursiva();
                        stopWatch.Stop();
                        Console.WriteLine($"O tempo de execução foi de: {stopWatch.ElapsedMilliseconds}ms");
                        Console.ReadLine();
                        break;
                    }

                    break;
                    
                }
                else
                {
                    Console.WriteLine("\nOps, você digitiu um número inválido. Digite o número do modelo escolhido.");
                    
                }
            }

        }
        private static void FatorialLoop()
        {
            long resultado = 1;
            Console.WriteLine("\nDigite o número que deseja calcular o fatorial: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado == 1 || numeroDigitado == 0)
            {
                Console.Write("O fatorial de {0} é sempre 1.", numeroDigitado);

            }
            for (int i = numeroDigitado; i > 0; i--)
            {
                resultado *= i;
                Console.WriteLine("O fatorial de {0} é {1}.", numeroDigitado, resultado);
            }
        }

        private static void FatorialRecursiva()
        {
            long resultado = 1;
            Console.WriteLine("Digite o número que deseja calcular o fatorial: \n");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado == 1 || numeroDigitado == 0)
            {
                Console.Write("O fatorial de {0} é sempre 1.", numeroDigitado);
                Console.ReadLine();
            }

            return numeroDigitado * (FatorialRecursiva - 1);
            Console.WriteLine("O fatorial de {0} é {1}.", numeroDigitado, resultado);
            Console.ReadLine();
        }
    }
}