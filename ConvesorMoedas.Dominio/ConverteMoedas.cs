using System.ComponentModel.Design;
using System.Globalization;

namespace ConvesorMoedas.Dominio
{
    public class ConverteMoedas
    {
        CultureInfo real = new CultureInfo("BRA", false);  // 0
        CultureInfo dolar = new CultureInfo("USA", false); // 1
        CultureInfo libra = new CultureInfo("ING", false); // 2
        CultureInfo iene = new CultureInfo("CHI", false);  // 3
        CultureInfo euro = new CultureInfo("EUR", false);  // 4

        public ConverteMoedas ()
        {
            real.NumberFormat.CurrencySymbol = "R$";
            dolar.NumberFormat.CurrencySymbol = "$";
            libra.NumberFormat.CurrencySymbol = "€";
            iene.NumberFormat.CurrencySymbol = "¥";
            euro.NumberFormat.CurrencySymbol = "£";
        }

        public void Converter (decimal valor, int moeda)
        {
            ImprimirValorFinal(ConverterReal(valor, moeda));    
        }

        private decimal ConverterReal (decimal valorEmReal, int moedaConverter)
        {
            switch (moedaConverter) 
            {
                case 0: // Real
                    return valorEmReal;
                case 1: // Dolar
                    return valorEmReal * 4.50m;
                case 2: // Libra
                    return valorEmReal * 6.95m;
                case 3: // Iene
                    return valorEmReal * 0.052m;
                case 4: // Euro
                    return valorEmReal * 6.20m;
                default:
                    return -1;
            }
        }

        public decimal ConverterTester (decimal valorEmReal, int moedaConverter)
        {
            return ConverterReal (valorEmReal, moedaConverter);
        }

        private void ImprimirValorFinal (decimal valor)
        {
            Console.WriteLine(valor.ToString("C", euro));
        }
    }
}
