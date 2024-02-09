using System;

namespace List6
{
    class Program
    {
        static void Main(string[] args)
        {
            int totprice = 0;
            Console.WriteLine("Skriv in namn på matvaror");
            string[] products = Console.ReadLine().Split(" ");
            Console.WriteLine("Skriv in matvarornas priser");
            string[] prices = Console.ReadLine().Split(" ");
            Console.WriteLine("Skriv in din handlingslista");
            string[] items = Console.ReadLine().Split(" ");

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < products.Length; j++)
                {
                    if (items[i] == products[j])
                    {
                        totprice += int.Parse(prices[j]);
                    }
                }
            }
            Console.WriteLine("Priset för din handlingslista är " + totprice);
        }
    }
}