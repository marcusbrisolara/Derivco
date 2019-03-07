using Derivco.Services;
using System;

namespace Derivco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu menu = new Menu();
            menu.GenerateMenu(null);
            Console.WriteLine(menu.Items.ToJson());
            Console.ReadKey();
        }
    }
}
