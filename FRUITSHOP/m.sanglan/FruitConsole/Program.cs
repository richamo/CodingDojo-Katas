using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est l'age du capitaine ?");
            var result = Console.ReadLine();
            Console.WriteLine("L'age est : " + result);
            Console.ReadLine();
        }
    }
}
