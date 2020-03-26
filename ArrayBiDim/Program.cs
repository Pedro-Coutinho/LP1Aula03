using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Declarar variáveis
            string str;
            int linhas, colunas;
            float [,] matriz;
            float somaDasMedias = 0;
            
            // Pedir ao user nº linhas da matriz
            Console.Write("Insira o nº de linhas: ");
            linhas = int.Parse(Console.ReadLine());

            // Pedir ao user nº colunas da matriz
            Console.Write("Insira o nº de colunas: ");
            colunas = int.Parse(Console.ReadLine());

            // Inicializar a matriz
            matriz = new float[linhas, colunas];

            //Pedir ao user os valores float para colocar na matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira valor em ({i}, {j}): ");
                    str = Console.ReadLine();
                    matriz[i, j] = Convert.ToSingle(str);
                }
            }

            //Mostrar matriz e a média para cada linha
            for ( int i = 0; i < matriz.GetLength(0); i++)
            {
                float soma = 0, media;
                Console.Write("| ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                    Console.Write($"{matriz[i, j],10:f2} ");
                }
                media = soma / matriz.GetLength(1);
                Console.WriteLine($"| -> {media,10:f3}");
                somaDasMedias += media;
            }

            //Mostrar soma das médias
            Console.WriteLine("Soma das medias: {0,10:f3}", somaDasMedias);
        }
    }
}
