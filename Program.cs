using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to type a temperatur in celcius that they would like to get converted.
            Console.Write("Please enter a temperatur in Celcius, and get it converted to both Fahrenheit and Reaumur:\n");
            // Taking the input and trying to set it as a float.
            float celcius = float.Parse(Console.ReadLine());
            Console.WriteLine();
            // Writing and calculating celcius in fahrenheit
            Console.Write("Fahrenheit: " + (celcius * 1.8) + 32 + "\n");
            // Writing and calculating celcius in reamur
            Console.Write("Reamur: " + celcius * 0.8);
            Console.ReadLine();
        }
    }
}
