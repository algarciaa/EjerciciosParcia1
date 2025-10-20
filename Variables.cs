namespace EjerciciosParcia1
{
    public class Variables
    {

        enum Dia { Lunes, Martes, Miercoles } // Enumeración

        struct Punto                 // Estructura personalizada
        {
            public int x;
            public int y;
        }

        public static void Main()
        {
            /*
             * 1. Tipos de Valor
             * Estos almacenan directamente el valor en memoria.
             */

            int edad = 30;               // Entero de 32 bits
            long poblacion = 1000000000; // Entero largo
            float peso = 65.5f;          // Decimal de 32 bits (requiere 'f')
            double altura = 1.75;        // Decimal de 64 bits
            decimal precio = 99.99m;     // Alta precisión (requiere 'm')
            char inicial = 'A';          // Carácter Unicode
            bool esActivo = true;        // Booleano

            /*
             * 2. Tipos de Referencia
             * Estos almacenan una referencia a un objeto en memoria.
             */

            string nombre = "Carlos";     // Cadena de texto
            object dato = 42;             // Puede contener cualquier tipo
            dynamic variable = "Hola";    // Se evalúa en tiempo de ejecución


            /*
             * 3. Tipos Especiales
             */

            var ciudad = "Quito";         // El tipo se infiere como string
            int? edadNullable = null;     // Tipo nullable (puede ser null)
            
            Dia hoy = Dia.Martes;

            Punto p = new Punto { x = 5, y = 10 };

            /*
             * 4. Colecciones y Compuestos
             */

            int[] numeros = { 1, 2, 3 };                // Arreglo
            List<string> nombres = new List<string>()  // Lista genérica
            {
                "Ana", "Luis", "Pedro"
            };

            Dictionary<int, string> mapa = new Dictionary<int, string>() // Diccionario
            {
                {1, "Uno"},
                {2, "Dos"}
            };

            /*
             * 5. Tipos Numéricos Avanzados
             */

            byte nivel = 255;           // 0 a 255
            sbyte temperatura = -100;   // -128 a 127
            short saldo = -32000;       // Entero corto
            ushort puntos = 65000;      // Entero corto sin signo
            uint visitas = 4000000000;  // Entero sin signo
            ulong estrellas = 9000000000000000000; // Entero largo sin signo

            /*
             * Imprimir en consola
             */
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine($"Nombre: {nombre}, Altura: {altura}");

            //Comentarios de una linea

            /*
             * Comentarios
             * multilinea
             * mas lineas
             * mas lineas
             */

            //entrada
            Console.Write("¿Cuál es tu nombre? ");
            nombre = Console.ReadLine();

            Console.Write("¿Cuántos años tienes? ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

            //salida
            string producto = "Laptop";
            double valor = 799.99;
            int cantidad = 2;

            Console.WriteLine("Producto: " + producto + ", Precio: $" + valor);
            Console.WriteLine($"Total a pagar por {cantidad} {producto}s: ${valor * cantidad}");
        }
    }
}
