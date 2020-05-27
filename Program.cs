using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;
            
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = RetornoImparPar(numero);

            if (resultado == 1)
                Console.WriteLine("O número informado é impar");
            else
                Console.WriteLine("O número informado é par");

            Console.ReadLine();
        }

        public static int RetornoImparPar(int numero)
        {
            int resultado = numero % 2;
            return resultado;
        }
    }
}