using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE DESCUENTOS ===");

        // Solicitar precio del producto
        Console.Write("Ingrese el precio del producto: $");
        double precio = Convert.ToDouble(Console.ReadLine());

        // Solicitar código de descuento
        Console.WriteLine("\nCódigos de descuento:");
        Console.WriteLine("1 = Estudiante (10%)");
        Console.WriteLine("2 = Empleado (15%)");
        Console.WriteLine("3 = Cliente frecuente (20%)");
        Console.Write("Ingrese su código de descuento (1, 2 o 3): ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        // Variables para cálculos
        double porcentajeDescuento = 0;
        string tipoCliente = "";

        // Estructura condicional para seleccionar descuento
        if (codigo == 1)
        {
            porcentajeDescuento = 0.10; // 10%
            tipoCliente = "Estudiante";
        }
        else if (codigo == 2)
        {
            porcentajeDescuento = 0.15; // 15%
            tipoCliente = "Empleado";
        }
        else if (codigo == 3)
        {
            porcentajeDescuento = 0.20; // 20%
            tipoCliente = "Cliente frecuente";
        }
        else
        {
            Console.WriteLine("Código inválido. No se aplicará descuento.");
            porcentajeDescuento = 0;
            tipoCliente = "Sin descuento";
        }

        // Calcular descuento base
        double descuentoBase = precio * porcentajeDescuento;
        double precioConDescuentoBase = precio - descuentoBase;

        // Validación con operadores lógicos: descuento adicional si precio > 500
        double descuentoAdicional = 0;
        if (precio > 500 && codigo >= 1 && codigo <= 3)
        {
            descuentoAdicional = precioConDescuentoBase * 0.05; // 5% adicional
            Console.WriteLine("¡Descuento adicional del 5% aplicado por compra mayor a $500!");
        }

        // Calcular precio final
        double precioFinal = precioConDescuentoBase - descuentoAdicional;
        double descuentoTotal = descuentoBase + descuentoAdicional;

        // Mostrar resultados
        Console.WriteLine("\n=== RESUMEN DE COMPRA ===");
        Console.WriteLine($"Tipo de cliente: {tipoCliente}");
        Console.WriteLine($"Precio original: ${precio:F2}");
        Console.WriteLine($"Descuento base ({porcentajeDescuento * 100}%): -${descuentoBase:F2}");

        if (descuentoAdicional > 0)
        {
            Console.WriteLine($"Descuento adicional (5%): -${descuentoAdicional:F2}");
        }

        Console.WriteLine($"Descuento total: -${descuentoTotal:F2}");
        Console.WriteLine($"PRECIO FINAL: ${precioFinal:F2}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}