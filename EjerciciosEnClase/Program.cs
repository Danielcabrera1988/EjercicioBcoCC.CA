using System;

namespace EjerciciosEnClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CtaCte c1 = new(1000);
            int montos;
            Random rand = new Random();
            Console.WriteLine("La cuenta se inicia con el siguiente saldo");
            c1.getSaldo();
            Console.WriteLine($"Y cuenta con un tope máximo de adelanto de {Math.Abs(CtaCte.TopeDescubierto)}");
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDeposito");
                    Console.ResetColor();
                    montos = rand.Next(1, 10001);
                    Console.WriteLine($"Monto del depósito ${montos}");
                    c1.depositar(montos);
                    c1.getSaldo();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nExtraccion");
                    Console.ResetColor();
                    montos = rand.Next(1, 10001);
                    Console.WriteLine($"Monto de la extraccion ${montos}");
                    c1.extraer(montos);
                    c1.getSaldo();
                }
            }
        }
    }
}
