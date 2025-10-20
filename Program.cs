namespace EjerciciosParcia1
{
    public class Program
    {
        public static void Main()
        {
            string nombre = "Alex";
            String apellido = new String("Garcia");

            Console.WriteLine(nombre.GetType() == apellido.GetType());

            int edad = 20;

            Console.WriteLine(edad);

            //long
            //short

            float precio = 19.99f;
            double pi = 3.14159;

            //decimal
            decimal salario = 1500.75m;

            char inicial = 'A';
            bool esActivo = true;
            bool esInactivo = false;

            byte edades = 255;
            sbyte temperatura = -50;

            DateTime hoy = DateTime.Now;

            Console.WriteLine(hoy);

            TimeOnly hora = new TimeOnly(21, 59);
            Console.WriteLine(hora);

            object dato = 42;

            int? numero = null;
            string? cadena = null;


            //1 linea
            /*
             * Varias lineas
             * otra linea
             */

            //operadores matematicos
            int numero1 = 25;
            int numero2 = 5;

            //int suma = numero1 + numero2;
            var suma = numero1 + numero2;

            Console.WriteLine(suma);

            int resta = numero1 - numero2;
            Console.WriteLine(resta);

            int multiplicacion = numero1 * numero2;
            Console.WriteLine(multiplicacion);

            int division = numero1 / numero2;
            Console.WriteLine(division);

            numero1 = 10;
            numero2 = 3;

            int modulo = numero1 % numero2;
            Console.WriteLine(modulo);

            /*
                += suma y asigna
                -= resta y asigna
                *= multiplica y asigna
                /= divide y asigna
                %= modulo y asigna
            */

            int l = 5;
            Console.WriteLine(l);
            //l = l + 5;
            l += 5;
            Console.WriteLine(l);

            int i = 0;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);

            int edadAdulto = 20;

            if (edadAdulto < 18)
            {
                Console.WriteLine("No es adulto");
            }
            else
            {
                Console.WriteLine("Es adulto");
            }

            int numeroIsPar = 8;

            string resultado = (numeroIsPar % 2 == 0) ? "Par" : "Impar";

            Console.WriteLine(resultado);

            int isMayorEdad = 15;

            string mensaje = (isMayorEdad >= 18) ? "Puede votar" : "No puede votar";

            Console.WriteLine(mensaje);

            int nota = 85;

            resultado = (nota >= 90) ? "Excelente" :
                  (nota >= 70) ? "Aprobado" :
                  (nota >= 50) ? "Suficiente" : "Reprobado";

            Console.WriteLine($"La nota {nota} es: {resultado}");
        }
    }
}