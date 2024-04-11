using System;
using System.Globalization;
using ConvesorMoedas.Dominio;

public class SamplesCultureInfo
{
    // para entender o uso do CultureInfo
    public static void Main()
    {
        decimal valor = 312.68m;
        int moeda = 4;
        ConverteMoedas converter = new ConverteMoedas();

        converter.Converter(valor, moeda);  


    }
}

/*
This code produces the following output.

DTFI/NFI PROPERTY       ORIGINAL        MODIFIED CLONE
DTFI.AMDesignator       AM              a.m.
DTFI.DateSeparator      /               -
NFI.CurrencySymbol      $               USD
NFI.NumberDecimalDigits 2               4

*/