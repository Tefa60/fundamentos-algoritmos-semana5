using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE CLASIFICACIÓN DE NOTAS ===");

        // Solicitar nota
        Console.Write("Ingrese una nota (0-20): ");
        double nota = Convert.ToDouble(Console.ReadLine());

        // Validar que la nota esté en el rango correcto
        if (nota < 0 || nota > 20)
        {
            Console.WriteLine("ERROR: La nota debe estar entre 0 y 20.");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
            return;
        }

        // Convertir nota a entero para el switch (agrupando rangos)
        int notaEntera = (int)nota;
        string clasificacion = "";

        // Usar switch para clasificar la nota
        switch (notaEntera)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                clasificacion = "Desaprobado";
                break;

            case 11:
            case 12:
            case 13:
                clasificacion = "Regular";
                break;

            case 14:
            case 15:
            case 16:
            case 17:
                clasificacion = "Bueno";
                break;

            case 18:
            case 19:
            case 20:
                clasificacion = "Excelente";
                break;

            default:
                clasificacion = "Fuera de rango";
                break;
        }

        // Validaciones adicionales con operadores lógicos
        string mensajeAdicional = "";

        // Si la nota es mayor o igual a 14 y es par
        if (nota >= 14 && (int)nota % 2 == 0)
        {
            mensajeAdicional = "Buen desempeño con nota par";
        }
        // Si la nota es impar o menor a 11
        else if ((int)nota % 2 != 0 || nota < 11)
        {
            mensajeAdicional = "Necesita reforzar";
        }

        // Calcular raíz cuadrada y potencia al cubo
        double raizCuadrada = Math.Sqrt(nota);
        double potenciaCubo = Math.Pow(nota, 3);

        // Mostrar resultados
        Console.WriteLine("\n=== RESULTADO DE EVALUACIÓN ===");
        Console.WriteLine($"Nota ingresada: {nota:F2}");
        Console.WriteLine($"Clasificación: {clasificacion}");

        if (!string.IsNullOrEmpty(mensajeAdicional))
        {
            Console.WriteLine($"Observación: {mensajeAdicional}");
        }

        Console.WriteLine("\n=== CÁLCULOS MATEMÁTICOS ===");
        Console.WriteLine($"Raíz cuadrada: {raizCuadrada:F1}");
        Console.WriteLine($"Potencia al cubo: {potenciaCubo:F0}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
