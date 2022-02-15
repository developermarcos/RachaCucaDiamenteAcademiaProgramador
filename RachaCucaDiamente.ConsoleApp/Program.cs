using System;

namespace RachaCucaDiamente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imprimir = "";
            int alturaDiamante, quantidadeEspacoParaCaraLado, quantidadeX = 1;
            //Entrada
            Console.WriteLine("Escreva um valor: ");
            alturaDiamante = Convert.ToInt32(Console.ReadLine());
            quantidadeEspacoParaCaraLado = (alturaDiamante -1) / 2;
            //Processamento
            for (int i = alturaDiamante; i > 0; i--)
            {
                if (i > (quantidadeEspacoParaCaraLado +1))
                {
                    for (int j = i; j > quantidadeEspacoParaCaraLado; j--)
                        imprimir += " ";
                    
                    for (int h = 0; h < quantidadeX; h++)
                        imprimir += "X";
                    

                    quantidadeX += 2;
                    imprimir += "\n";
                }
                else
                {
                    for (int z = (quantidadeEspacoParaCaraLado + 1); z >= i; z--)
                        imprimir += " ";
                    
                    for (int h = 0; h < quantidadeX; h++)
                        imprimir += "X";
                    
                    imprimir += "\n";
                    quantidadeX -= 2;
                }
            }
            //Saída
            Console.WriteLine("Resultado final\n"+imprimir);
            Console.ReadLine();
        }
    }
}
