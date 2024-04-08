using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency Converter! \n What currency do you want to exchange into USD? \n [1] EUR \n [2] GBP \n [3] Yen");
            var currencyToConvert = (Currency)int.Parse(Console.ReadLine());

            Console.WriteLine("How much do you want to convert?");
            var amountToConvert = double.Parse(Console.ReadLine());

            var convertedAmount = $"{DollarExchange.ConvertToUSD(amountToConvert, currencyFrom)}";
            Console.WriteLine($"Your Value equals {convertedAmount} USD");
        }
    }

    static class DollarExchange
    {
        public static double ConvertToUSD(double amountValue, Currency currency)
        {
            double newAmount;
            switch (currency)
            {
                case Currency.EUR:
                    return newAmount = amountValue * 1.08;
                case Currency.GBP:
                    return newAmount = amountValue * 1.26;
                case Currency.Yen:
                    return newAmount = amountValue * 0.0066;
            }
        }
    }

    enum Currency
    {
        EUR = 1,
        GBP = 2,
        Yen = 3
    }
}