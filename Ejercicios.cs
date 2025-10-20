namespace EjerciciosParcia1
{
    public class Ejercicios
    {
        public static void Main()
        {
            int edad = 20;
            string nombre = "Luis";

            Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

            if (edad >= 18)
            {
                Console.WriteLine("Puedes votar.");
            }
            else
            {
                Console.WriteLine("No puedes votar.");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Tabla del 2: 2 x {i} = {2 * i}");
            }

            //calculadora
            int a = 12;
            int b = 4;

            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {a / b}");
            Console.WriteLine($"Módulo: {a % b}");
            Console.WriteLine($"Potencia: {Math.Pow(a, b)}");

            //Clasificación por edad
            edad = 17;

            if (edad < 13)
            {
                Console.WriteLine("Niño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else
            {
                Console.WriteLine("Adulto");
            }

            //Sumar los primeros 10 números pares
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                int par = i * 2;
                suma += par;
                Console.WriteLine($"Número par: {par}, Suma acumulada: {suma}");
            }
        }
    }
}
