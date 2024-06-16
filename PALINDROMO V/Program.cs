namespace PALINDROMO_V;
class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingrese una cadena de texto: ");
        string input = Console.ReadLine();
        
        // Eliminar espacios en blanco y convertir a minúsculas
        string processedInput = input.Replace(" ", "").ToLower();
        
        // Verificar si la cadena es un palíndromo
        if (IsPalindrome(processedInput))
        {
            Console.WriteLine("La cadena ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La cadena ingresada no es un palíndromo.");
        }
    }

    static bool IsPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
