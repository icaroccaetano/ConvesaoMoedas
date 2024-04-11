using System;
using System.Globalization;
using ConvesorMoedas.Dominio;

public class SamplesCultureInfo
{
    public static void Main()
    {
        decimal valor = 312.68m;
        int moeda = 4;
        ConverteMoedas converter = new ConverteMoedas();

        Console.WriteLine("Valor em R$:");
        valor = decimal.Parse(Console.ReadLine());

        Console.WriteLine("     0 - Real");
        Console.WriteLine("     1 - Dolar");
        Console.WriteLine("     2 - Libra");
        Console.WriteLine("     3 - Iene");
        Console.WriteLine("     4 - Euro");
        moeda = int.Parse(Console.ReadLine());
        
        converter.Converter(valor, moeda);  
    }
}
