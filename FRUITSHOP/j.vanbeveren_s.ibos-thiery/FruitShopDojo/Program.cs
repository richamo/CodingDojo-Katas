using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShopDojo
{
    class Program
    {

        static void Main(string[] args)
        {
            Int32 apple = 100, cherry = 75, banane = 150;
            Int32 globalCost = 0;
            Int32 countApple;
            List<string> fruits = new List<string>();
            Console.WriteLine(apple + " " + banane + " " + cherry);
            var read = String.Empty;

            while (read != "stop")
            {
                read = Console.ReadLine();
                if (read.Contains(','))
                    fruits = splitGlobal(read);

                globalCost = Global(read, globalCost);

                fruits.Add(read);

                if (read == "cherry" && fruits.Where(f => f == "cherry").Count() == 1)
                    globalCost -= 20;

                if (read == "banana" && fruits.Where(f => f == "banana").Count() == 1)
                    globalCost -= banane;

                if (read == "pomme" && fruits.Where(f => f == "pomme").Count() == 2)
                { globalCost -= 100; }

                if (read == "mele" && fruits.Where(f => f == "mele").Count() == 1)
                { globalCost -= 100; }
                countApple = fruits.Where(f => f == "pomme").Count() + fruits.Where(f => f == "apple").Count() + fruits.Where(f => f == "mele").Count();

                if (fruits.Count() == 4)
                {
                    globalCost -= 200;
                }

                if (countApple == 3)
                { globalCost -= 100; }

                
                Console.WriteLine(globalCost);
            }

            Console.ReadLine();
        }

        public static List<string> splitGlobal(string read)
        {
            List<string> fruits = new List<string>();
            fruits = read.Split(',').ToList();

            return fruits;

        }

        public static Int32 Global(string read, int globalCost)
        {
            int _globalCost = globalCost;
            Int32 apple = 100, cherry = 75, banane = 150;
            if (read == "mele" || read == "pomme")
                read = "apple";
            switch (read)
            {
                case "banana":
                    _globalCost += banane;
                    break;
                case "apple":
                    _globalCost += apple;
                    break;
                case "cherry":
                    _globalCost += cherry;
                    break;
                default:
                    break;
            }

            return _globalCost;
        }

        //public Dictionary<string,int> CostFruit(List<string> fruits)
        //{
        //    Dictionary<string, int> fruitDictionnary = new Dictionary<string, int>();
        //    int banane, cherry, apple, globalCost = 0;
        //    foreach(var fruit in fruits){

        //        if (fruit == "banane")
        //        {
        //            banane++;
        //        }
        //        if (fruit == "cherry")
        //            cherry++;
        //        if (fruit == "apple")
        //            apple++;
        //    }
        //    foreach (var fruit in collection)
        //    {

        //    }
        //    switch (fruit)
        //    {
        //        case "banane":
        //            fruitDictionnary.Add("banane");
        //            break;
        //        case "apple":
        //            ;
        //            break;
        //        case "cherry":
        //            ;
        //            break;
        //        default:
        //            break;
        //    }

        //}
    }
}
