namespace EjerciciosParcia1
{
    public class Operaciones
    {
        public static void Main()
        {
            int a = 10, b = 3;
            int suma = a + b;
            Console.WriteLine(suma);
            int resta = a - b;
            Console.WriteLine(resta);
            int multiplicacion = a * b;
            Console.WriteLine(multiplicacion);
            double division = (double)a / b;
            Console.WriteLine(division);
            int modulo = a % b;
            Console.WriteLine(modulo);
            double potencia = Math.Pow(a, b); // 10^3 = 1000
            Console.WriteLine(potencia);

        }
    }
}
