using System;

namespace EjerciciosEnClase
{
    internal class CajaAhorro
    {
        private double saldo;

        public CajaAhorro()
        {
            Saldo = 0;
        }

        public CajaAhorro(double saldo)
        {
            Saldo = saldo;
        }

        protected double Saldo { get => saldo; set => saldo = value; }

        public virtual void getSaldo()
        {
            Console.WriteLine($"Saldo de su Caja de Ahorro {Math.Round(Saldo, 2)}");
        }
        public virtual void extraer(double saldo)
        {
            if (saldo <= Saldo)
            {
                Saldo -= saldo;
                Console.WriteLine($"Su nuevo saldo es {Math.Round(Saldo, 2)}");
            }
            else
            {
                Console.WriteLine("La extracción exede el saldo en su cuenta");
            }
        }

        public virtual void depositar(double saldo)
        {
            if (saldo <= 0)
            {
                Console.WriteLine("Ingrese un monto mayor a cero");
            }
            else
            {
                Saldo += saldo;
                Console.WriteLine($"Su nuevo saldo es {Math.Round(Saldo, 2)}");
            }
        }
    }
}
