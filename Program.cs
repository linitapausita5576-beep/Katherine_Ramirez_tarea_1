namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo aplicando el ISR");
            Console.WriteLine();

            Console.WriteLine("Ingresa el sueldo anual del empleado: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El sueldo del empleado es: " + sueldo);
            Console.WriteLine();

            if (sueldo >= 416220 && sueldo <= 634329)
            {
                double ISR = Calisr(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = Calisrmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);
            }

            else if (sueldo >= 634329 && sueldo <= 867123)
            {
                double ISR = Calisrmen(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = Calisrmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);
            }

            else if (sueldo >= 867123)
            {
                double ISR = calisrmensu(sueldo);

                Console.WriteLine("El ISR a pagar anualmente es: " + ISR);
                Console.WriteLine();

                double ISRM = Calisrmensual(ISR);
                Console.WriteLine("El ISR a pagar mensualmente es: " + ISRM);
            }

            else
            {
                Console.WriteLine("ISR a pagar: N/A ");
            }
        }
        static double Calisr(double sueldo)
        {
            double ISR = (sueldo - 416222) * 0.15;
            return ISR;
        }

        static double Calisrmen(double sueldo)
        {
            double ISR = (sueldo - 634329) * 0.20;
            return ISR;
        }

        static double calisrmensu(double sueldo)
        {
            double ISR = (sueldo - 867123) * 0.25;
            return ISR;
        }

        static double Calisrmensual(double ISR)
        {
            double ISRM = ISR / 12;
            return ISRM;
        }
    }
}
