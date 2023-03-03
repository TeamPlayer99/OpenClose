using System;
using OpenCloseApp.Lib;

namespace OpenCloseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Console.WriteLine(shop.Open());
            Console.WriteLine(shop.Start());
            Console.WriteLine(shop.Stop());
            Console.WriteLine(shop.Close());
        }
    }
}
