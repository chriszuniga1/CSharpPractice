using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class WarmupFruitLoop1
    {
        static void Main(string[] args)
        {
            //Warm up: Fruit Loop1.cs
            /*
             * Declare and initialize an array of any six fruit names (as text). Set up a FOR loop and iterate throught them (displaying each value in the console.
             */

            Console.WriteLine("Here is a list of my favorite fruits:");
            string[] fruit = { "peaches", "apples", "cherries", "grapes", "oranges", "plums" };
            for (int i = 0; i < fruit.Length; i++)
            {
                string fruits = fruit[i];
                Console.WriteLine(fruits);
            }


            //string[] fruit = new string[6];
            //fruit[0] = "cherry";
            //fruit[1] = "apple";
            //fruit[2] = "peach";
            //fruit[3] = "orange";
            //fruit[4] = "grape";
            //fruit[5] = "plums";

            //for (int i = 0; i < fruit.Length; i++)
            //{
            //    string fruits = fruit[i];
            //    Console.WriteLine(fruits);
            //}


        }//end Main()
    }//end Class
}//end Namespace
