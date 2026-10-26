
using System;

class Program
{
    static void Main()
    {
        // SECCION 1: FOR Y FOREACH
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        int suma = 0;
        double promedio;

        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        // Recorrido ascendente con for
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // Recorrido descendente con for
        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // Suma y promedio con foreach
        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }

        promedio = (double)suma / calificaciones.Length;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio:F1}");

        // Indices pares con incremento de 2
        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }

        // SECCION 2: WHILE Y DO-WHILE
        Console.WriteLine("\n=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string clave = "sena2026";
        string claveIngresada = "";

        while (claveIngresada != clave && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            claveIngresada = Console.ReadLine() ?? "";
            intentos++;

            if (claveIngresada != clave)
            {
                if (intentos < 3)
                {
                    Console.WriteLine(
                        $"Clave incorrecta. Intentos restantes: {3 - intentos}");
                }
            }
        }

        if (claveIngresada == clave)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        // Menu interactivo con do-while
        Console.WriteLine("\n=== MENÚ PRINCIPAL ===");

        int opcion;

        do
        {
            Console.WriteLine("\n1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string entrada = Console.ReadLine() ?? "";

            if (!int.TryParse(entrada, out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Promedio del grupo: {promedio:F1}");
                    break;

                case 2:
                    int mayor = calificaciones[0];

                    foreach (int calificacion in calificaciones)
                    {
                        if (calificacion > mayor)
                        {
                            mayor = calificacion;
                        }
                    }

                    Console.WriteLine($"Calificación más alta: {mayor}");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);

        // SECCION 3: BREAK Y CONTINUE
        Console.WriteLine("\n=== BUSQUEDA DE LA PRIMERA REPROBACION ===");

        // Encontrar la primera calificacion menor a 60
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine(
                    $"Primera calificación reprobatoria: {calificaciones[i]}");
                Console.WriteLine($"Posición: {i + 1}");
                break;
            }
        }

        // Mostrar solo las calificaciones aprobatorias
        Console.WriteLine("\n=== CALIFICACIONES APROBATORIAS ===");

        int aprobados = 0;

        foreach (int calificacion in calificaciones)
        {
            if (calificacion < 60)
            {
                continue;
            }

            Console.WriteLine($"Calificación aprobatoria: {calificacion}");
            aprobados++;
        }

        Console.WriteLine($"Total de estudiantes aprobados: {aprobados}");

        // Combinar break y continue
        Console.WriteLine("\n=== FILTRADO CON BREAK Y CONTINUE ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }

            if (calificaciones[i] >= 95)
            {
                break;
            }

            Console.WriteLine(
                $"Calificación procesada: {calificaciones[i]}");
        }

        Console.WriteLine("\nPrograma finalizado.");
    }
}
