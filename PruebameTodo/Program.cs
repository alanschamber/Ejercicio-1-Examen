using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebameTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            float comision = 1.05f;
            float transaction = 0;
            
            transaction = ValDolar() * CantDolar() * comision;
            Confirm(transaction);
        }

        public static float ValDolar ()
        {
            float valor = 0f;
            for (int i = 0; i < 1; i++)
            {
                try
                {
                    Console.WriteLine("Ingrese la cotización del dólar");
                    valor = float.Parse(Console.ReadLine());

                    if (valor > 0) break;

                    Console.WriteLine("Valor ingresado no válido");
                    i--;
                }
                catch
                {
                    Console.WriteLine("Valor no válido");
                    i--;
                }
            }
            return valor;
        }

        public static uint CantDolar ()
        {
            uint cantidad = 0;
            for (int i = 0; i< 1; i++)
            {
                try
                {
                Console.WriteLine("Ingrese la cantidad de dólares a comprar");
                cantidad = uint.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor ingresado no válido");
                    i--;
                }
            }
            return cantidad;
        }

        public static void Confirm(float transaction)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"¿Desea confirmar la operación por {transaction} pesos? Y/N");
                string confirmar = Console.ReadLine();

                if (confirmar.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine($"La operación fue realizada por un valor de {transaction} pesos");
                    break;
                }

                if (confirmar.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine($"La operación fue cancelada");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"Caracter no válido");
                i--;
            }
            Console.ReadLine();
        }
    }
}
