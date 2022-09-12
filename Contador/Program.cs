using System;

namespace Contador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número!");
            _ = int.TryParse(Console.ReadLine(), out var resposta);

            int soma = 0;
            for(int numero = 1; numero <= resposta; numero++)
            {
                if(numero % 3 == 0 || numero % 5 == 0) 
                    soma += numero;               
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
