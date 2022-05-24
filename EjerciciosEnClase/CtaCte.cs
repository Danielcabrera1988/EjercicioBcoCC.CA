using System;

namespace EjerciciosEnClase
{
    internal class CtaCte : CajaAhorro
    {
        private const double topeDescubierto = -10000;

        public static double TopeDescubierto => topeDescubierto;

        public CtaCte() : base() { }
        public CtaCte(double saldo) : base(saldo)
        {
            Saldo = saldo;
        }

        public override void getSaldo()
        {
            Console.WriteLine($"Saldo de su Cuenta Corriente ${Math.Round(Saldo, 2)}");
        }
        public override void extraer(double saldo)
        {
            if (saldo <= Saldo)
            {
                Saldo -= saldo;
            }
            else
            {                
                double saldoMasInteres = (Saldo - saldo) * 1.05;//calculo de la extracción mas interes del saldo negativo
                double intSolo = Saldo - saldo;//obtencion del saldo negativo
                int interes = Math.Abs((int)(intSolo * 0.05));//calculo del interes sobre saldo negativo

                if (saldoMasInteres > topeDescubierto)
                {
                    Saldo = (Saldo - saldo) * 1.05;
                }
                else
                {
                    Console.WriteLine($"El monto solicitado ${saldo} + (${interes} intereses) Supera su tope máximo de Adelanto");
                }
            }
        }

        public override void depositar(double saldo)
        {
            if (saldo <= 0)
            {
                Console.WriteLine("Ingrese un saldo positivo mayor a cero");
            }
            else
            {
                Saldo += saldo;
            }
        }
    }
}
