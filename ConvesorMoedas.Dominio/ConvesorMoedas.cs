using System.Globalization;

namespace ConvesorMoedas.Dominio
{
    public class ConvesorMoedas
    {
        CultureInfo real = new CultureInfo("BRA", false);
        CultureInfo dolar = new CultureInfo("USA", false);
        CultureInfo libra = new CultureInfo("ING", false);
        CultureInfo iene = new CultureInfo("CHI", false);
        CultureInfo euro = new CultureInfo("EUR", false);

        void inicializaMoedas ()
        {
            real.NumberFormat.CurrencySymbol = "R$";
            dolar.NumberFormat.CurrencySymbol = "$";
            libra.NumberFormat.CurrencySymbol = "€";
            iene.NumberFormat.CurrencySymbol = "¥";
            euro.NumberFormat.CurrencySymbol = "£";
        }
    }
}
