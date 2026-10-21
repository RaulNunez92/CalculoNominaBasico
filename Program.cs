using System.Globalization;

Console.Title = "Cálculo básico de nómina";

Console.WriteLine("========================================");
Console.WriteLine("       CÁLCULO BÁSICO DE NÓMINA");
Console.WriteLine("========================================");
Console.WriteLine();

Console.Write("Nombre del empleado: ");
string nombreEmpleado = Console.ReadLine() ?? string.Empty;

decimal horasTrabajadas = LeerNumeroPositivo("Horas trabajadas: ");
decimal pagoPorHora = LeerNumeroPositivo("Pago por hora: RD$");

// Operador de multiplicación para calcular el salario bruto.
decimal salarioBruto = horasTrabajadas * pagoPorHora;

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("          RESUMEN DE NÓMINA");
Console.WriteLine("========================================");
Console.WriteLine($"Empleado: {nombreEmpleado}");
Console.WriteLine($"Horas trabajadas: {horasTrabajadas:N2}");
Console.WriteLine($"Pago por hora: RD${pagoPorHora:N2}");
Console.WriteLine("----------------------------------------");
Console.WriteLine($"SALARIO BRUTO: RD${salarioBruto:N2}");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Presione una tecla para finalizar...");
Console.ReadKey();

static decimal LeerNumeroPositivo(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine() ?? string.Empty;

        // Convierte el texto ingresado a decimal y valida que sea mayor que cero.
        bool esValido = decimal.TryParse(entrada, NumberStyles.Number,
            CultureInfo.InvariantCulture, out decimal numero) ||
            decimal.TryParse(entrada, NumberStyles.Number,
            new CultureInfo("es-DO"), out numero);

        if (esValido && numero > 0)
        {
            return numero;
        }

        Console.WriteLine("Ingrese un número mayor que cero. Ejemplo: 40 o 250.50");
    }
}
