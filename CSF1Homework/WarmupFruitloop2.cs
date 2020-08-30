using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class WarmupFruitloop2
    {
        static void Main(string[] args)
        {
            //Warm up: FruitLoop2
            /*
             * Repeat the FruitLoop1 exercise, but for each of the fruit names that you display, on the next line display a number of periods that is equal to the number of the index of the array.
             * 
             * Example:
             * "Apple"
             * .//one period
             */

            string[] fruit = new string[6];
            fruit[0] = "cherry";
            fruit[1] = "apple";
            fruit[2] = "peach";
            fruit[3] = "orange";
            fruit[4] = "grape";
            fruit[5] = "plums";

            for (int i = 0; i < fruit.Length; i++)
            {
                string fruits = fruit[i];
                Console.WriteLine(fruits);
            }

        }//end Main()
    }//end Class
}//end Namespace
