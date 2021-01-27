using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsList = new ProductsList();
            productsList.Add("Телевизор");
            productsList.Add("Телефон");
            productsList.Add("Стол");
            productsList.Add("Стул");
            productsList.Add("Кровать");

            productsList.SetSaleStrategy(new CashSale());
            productsList.Sale();

            productsList.SetSaleStrategy(new CashlessPaymentSale());
            productsList.Sale();

            productsList.SetSaleStrategy(new CreditSale());
            productsList.Sale();

            Console.ReadLine();
        }
    }
}
