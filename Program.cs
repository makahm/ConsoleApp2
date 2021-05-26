using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            str = str.ToUpper();
            Console.WriteLine("Полученная строка " + str);
            Console.ReadKey();
        }
    }
}
