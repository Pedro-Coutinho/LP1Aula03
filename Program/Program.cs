using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            string str, temp;
            char c;

            // Pedir string ao utilizador
            Console.WriteLine("Insira uma string: ");
            str = Console.ReadLine();
            // Pedir carater c ao utilizador
            Console.WriteLine("Insira um carater: ");
            temp = Console.ReadLine();
            c = char.Parse(temp); 
            //Percorrer string
            foreach(char cDaStr in str)
            {
                //Imprimir caracter da string, excepto se for carater c
                if ( cDaStr != c)
                {
                    Console.Write(cDaStr);
                }
            }
            Console.WriteLine();
        }
    }
}
