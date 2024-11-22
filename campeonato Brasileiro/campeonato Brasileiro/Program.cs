using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeonato_Brasileiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> times = new Dictionary<int, string>
        {
            { 1, "Botafogo" },
            { 2, "Palmeiras" },
            { 3, "Flamengo" },
            { 4, "Grêmio" },
            { 5, "Fluminense" },
            { 6, "Athletico Paranaense" },
            { 7, "São Paulo" },
            { 8, "Corinthians" },
            { 9, "Internacional" },
            { 10, "Santos" },
            { 11, "Cruzeiro" },
            { 12, "Vasco da Gama" },
            { 13, "Fortaleza" },
            { 14, "América Mineiro" },
            { 15, "Gremio" },
            { 16, "Bahia" },
            { 17, "Cuiabá" },
            { 18, "Goias" },
            { 19, "Coritiba" },
            { 20, "Atlético Mineiro" }
        };

            bool entradaInvalida = false;
            int posicao;

            do
            {
                Console.Write("\nDigite a posição do time no Campeonato Brasileiro (1 a 20): ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out posicao) && posicao >= 1 && posicao <= 20)
                {
                    entradaInvalida = true;
                }
                else
                {
                    Console.WriteLine("\nEntrada Inválida. A posição deve ser um número entre 1 e 20. Por favor, tente novamente!\n");
                }

            } while (!entradaInvalida);

            // Fetch the team based on the position
            string timeEscolhido = times[posicao];

            Console.ForegroundColor = ConsoleColor.Blue;

            if (posicao >= 1 && posicao <= 4)
                Console.WriteLine($"\nO {timeEscolhido} está classificado para a Copa Libertadores.");
            else if (posicao >= 5 && posicao <= 6)
                Console.WriteLine($"\nO {timeEscolhido} está classificado para as Qualificatórias da Copa Libertadores.");
            else if (posicao >= 7 && posicao <= 12)
                Console.WriteLine($"\nO {timeEscolhido} está classificado para a Copa Sul-Americana.");
            else if (posicao >= 17 && posicao <= 20)
                Console.WriteLine($"\nO {timeEscolhido} está em risco de Rebaixamento.");
            else
                Console.WriteLine($"\nO {timeEscolhido} está seguro na primeira divisão.");

            Console.ReadKey();
        }
    }

}
    
