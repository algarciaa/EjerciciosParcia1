namespace EjerciciosParcia1
{
    public class EstructurasControl
    {
        public static void Main()
        {
            int edad = 20;

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }

            int nota = 85;

            if (nota >= 90)
            {
                Console.WriteLine("Excelente");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }

            Console.Write("Ingrese un número del 1 al 3: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elegiste uno");
                    break;
                case 2:
                    Console.WriteLine("Elegiste dos");
                    break;
                case 3:
                    Console.WriteLine("Elegiste tres");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteración: " + i);
            }

            int contador = 0;
            while (contador < 3)
            {
                Console.WriteLine("Contador: " + contador);
                contador++;
            }

            int intentos = 0;
            do
            {
                Console.WriteLine("Intento número: " + intentos);
                intentos++;
            } while (intentos < 3);

            string[] frutas = { "Manzana", "Banana", "Pera" };

            foreach (string fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("¡Se detiene en 5!");
                    break;
                }
                Console.WriteLine($"i = {i}");
            }

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue; // Salta el número 3
                }
                Console.WriteLine($"Número: {i}");
            }
        }
    }
}
