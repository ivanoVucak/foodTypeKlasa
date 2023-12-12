using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodTypeKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foodType foodType = new foodType();

            foodType.setName("banana");
            foodType.setProtein(4);
            foodType.setCarbs(93);
            foodType.setFat(3);

            foodType foodType2 = new foodType("jagoda", 1, 1, 1);
            

            Console.WriteLine(foodType.ToString());
            Console.WriteLine(foodType2.ToString());


            Console.ReadKey();
        }
    }
}
