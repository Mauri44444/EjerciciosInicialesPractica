namespace AÑO_BICIESTO_IV;
class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingrese un año: ");
        int year;
        
        
        if (int.TryParse(Console.ReadLine(), out year))             // Se intenta convertir la entrada del usuario en un numero entero
        {
            
            if (EsAñoBiciesto(year))             // Se determina si el año es bisiesto
            {
                Console.WriteLine($"El año {year} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {year} no es un año bisiesto.");
            }
        }
        else
        {
            Console.WriteLine("La entrada no es un número válido.");
        }
    }

    static bool EsAñoBiciesto(int year)   // Usamos un metodo booleano para ver si el año cumple las condiciones para ser bisiesto
    {
        return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);         // El año es bisiesto si es divisible por 4. Excepto si es divisible por 100, pero no por 400
    }
}



