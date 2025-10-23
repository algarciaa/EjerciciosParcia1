using System;
using System.Collections.Generic;
using System.Linq; // Necesario para el método Max()

public class GestorInventario
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- GESTOR DE INVENTARIO BÁSICO ---");

        // 1. Ingreso y Validación de la cantidad de productos
        int numTiposProducto = 0;
        bool entradaValida = false;

        do
        {
            Console.Write("\nIngrese la cantidad de tipos de productos a registrar: ");
            if (int.TryParse(Console.ReadLine(), out numTiposProducto) && numTiposProducto > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("ERROR: Ingrese un número entero positivo para la cantidad de productos.");
            }
        } while (!entradaValida);


        // 2. Inicializar las Listas
        List<string> nombresProductos = new List<string>();
        List<int> stocks = new List<int>();
        
        // Variables para el análisis
        int stockBajo = 0;
        int stockNormal = 0;
        
        Console.WriteLine($"\n--- REGISTRANDO {numTiposProducto} PRODUCTOS ---");

        // 3. Ciclo FOR para registrar Nombres y Stocks
        for (int i = 0; i < numTiposProducto; i++)
        {
            string nombre = "";
            
            // --- Ingreso y validación del Nombre ---
            do
            {
                Console.Write($"\n[Producto #{i + 1}] Ingrese el nombre: ");
                nombre = Console.ReadLine().Trim(); // .Trim() elimina espacios en blanco al inicio/fin
                
                // Validación IF: Nombre no vacío
                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("!!! ALERTA: El nombre del producto no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(nombre));

            nombresProductos.Add(nombre); // Agrega el nombre a la lista

            // --- Ingreso y validación del Stock ---
            int stock = -1; 
            bool stockValido = false;

            do
            {
                Console.Write($"[Producto #{i + 1}] Ingrese el stock inicial: ");
                
                // Intenta convertir la entrada a entero
                if (int.TryParse(Console.ReadLine(), out stock))
                {
                    // Validación IF: Stock no negativo
                    if (stock >= 0)
                    {
                        stockValido = true;
                        stocks.Add(stock); // Agrega el stock a la lista
                        
                        // 4. Análisis de Stock (IF)
                        if (stock <= 5)
                        {
                            stockBajo++;
                        }
                        else // stock > 5
                        {
                            stockNormal++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("!!! ALERTA: El stock no puede ser negativo. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("!!! ALERTA: Ingrese un número entero válido para el stock.");
                }
            } while (!stockValido);
        }

        // 5. Análisis adicional: Encontrar el producto con mayor stock
        string productoMayorStock = "N/A";
        int stockMaximo = 0;
        
        // Verifica que la lista no esté vacía antes de buscar el máximo
        if (stocks.Count > 0)
        {
            stockMaximo = stocks.Max(); // Encuentra el stock más alto
            int indiceMaximo = stocks.IndexOf(stockMaximo); // Encuentra la posición del stock máximo
            productoMayorStock = nombresProductos[indiceMaximo]; // Usa el índice para obtener el nombre del producto
        }

        // 6. Mostrar Resumen Final
        Console.WriteLine("\n=============================================");
        Console.WriteLine("             RESUMEN DE INVENTARIO           ");
        Console.WriteLine("=============================================");
        
        // Muestra el inventario completo (usando el FOR para iterar ambas listas en paralelo)
        Console.WriteLine("\n--- INVENTARIO DETALLADO ---");
        for (int i = 0; i < nombresProductos.Count; i++)
        {
            Console.WriteLine($"- {nombresProductos[i]}: {stocks[i]} unidades.");
        }
        
        Console.WriteLine("\n--- ANÁLISIS ---");
        Console.WriteLine($"Total de Tipos de Productos: {numTiposProducto}");
        Console.WriteLine($"Productos en Stock Bajo (<= 5): {stockBajo} tipos.");
        Console.WriteLine($"Productos en Stock Normal (> 5): {stockNormal} tipos.");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Producto con mayor stock ({stockMaximo} uds.): {productoMayorStock}");
        Console.WriteLine("=============================================");
        
        Console.ReadKey();
    }
}
