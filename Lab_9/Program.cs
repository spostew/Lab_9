/*
 * Pizza.cs: This program makes uses of creating a class and using functions to alter different pizza toppings and size
 * Name: Spencer Unitt
 * Module: Lab 9
 * 
 * Algorithm
 * 1. Create a class named pizza with a private string named size and three private ints named pep, cheese, and ham
 * 2. Create constructors that use the different variables in the parameters
 * 3. Create the getters and setters for all variables
 * 4. Create a function that calculates the total cost of the pie with toppings
 * 5. Override the tostring function to display the total of the pie
 * 6. In main create four pizza objects and use the tostring to display the current value in the objects
 * 7. Use the getters and display the topping values
 * 8. Use the setters and alter values in the objects, display the results after
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            // new pizza objects
            Pizza pie1 = new Pizza();
            Pizza pie2 = new Pizza("large");
            Pizza pie3 = new Pizza(2, 3, 1);
            Pizza pie4 = new Pizza("medium", 4, 2, 2);

            // Shows constructor defaults using ToString
            Console.WriteLine(pie1.ToString());
            Console.WriteLine(pie2.ToString());
            Console.WriteLine(pie3.ToString());
            Console.WriteLine(pie4.ToString());
            Console.WriteLine("\n");

            // Shows the use of the getters
            Console.WriteLine("You have " + pie1.getCheese() + " cheese toppings, "
                               + pie1.getHam() + " ham toppings, and " 
                               + pie1.getPep() + " pepperoni toppings on the first pie.");
            Console.WriteLine("You have " + pie2.getCheese() + " cheese toppings, "
                               + pie2.getHam() + " ham toppings, and "
                               + pie2.getPep() + " pepperoni toppings on the second pie.");
            Console.WriteLine("You have " + pie3.getCheese() + " cheese toppings, "
                               + pie3.getHam() + " ham toppings, and "
                               + pie3.getPep() + " pepperoni toppings on the third pie.");
            Console.WriteLine("You have " + pie4.getCheese() + " cheese toppings, "
                               + pie4.getHam() + " ham toppings, and "
                               + pie4.getPep() + " pepperoni toppings on the fourth pie.\n");

            // Using the setters
            pie1.setCheese(2);
            pie1.setPep(1);
            pie2.setSize("medium");
            pie2.setHam(3);
            pie3.setSize("large");

            // final results after objects have been altered
            Console.WriteLine(pie1.ToString());
            Console.WriteLine(pie2.ToString());
            Console.WriteLine(pie3.ToString());
            Console.WriteLine(pie4.ToString());
            Console.WriteLine("\n");


            Console.ReadLine();
        }
    }
}
