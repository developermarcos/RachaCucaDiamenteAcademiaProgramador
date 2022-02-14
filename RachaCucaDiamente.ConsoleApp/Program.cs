using System;

namespace RachaCucaDiamente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imprimir = "";
            int alturaDiamante, quantidadeEspacoParaCaraLado, x = 1;
            
            Console.WriteLine("Escreva um valor: ");
            alturaDiamante = Convert.ToInt32(Console.ReadLine());
            quantidadeEspacoParaCaraLado = (alturaDiamante -1) / 2;
            
            for (int i = quantidadeEspacoParaCaraLado; i > 0; i--)
            {
                for (int z = 1; z <= quantidadeEspacoParaCaraLado; z++)
                {
                    imprimir += " ";
                }
                for (int j = 1; j <= x; j++)
                {
                    imprimir += "X";
                }
                
                x += 2;
                imprimir += "\n";
            }
            Console.WriteLine("Resultado final\n"+imprimir);
            Console.ReadLine();
        }
    }
}
